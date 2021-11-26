using System;
using System.Collections.Generic;
using System.Text;

namespace BookingLibrary
{
    class CompleteState : IBookingSystem
    {
        IRepository _repository;
        public CompleteState()
        {
            _repository = SingletonRepository.GetInstance;
        }
        public void BookTicket(BookingContext context)
        {
            var newBookingState = new NewBookingState();
            context.NextState(newBookingState);

            newBookingState.BookTicket(context);
        }

        public void CancelBooking(BookingContext context)
        {
            var bookedMovies = _repository.GetBookedMovies();
            if (bookedMovies.Count > 0)
            {
                Helper.ShowBookings(bookedMovies);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Are you sure you want to cancel the booking - Y/N: ");
                Console.ForegroundColor = ConsoleColor.Green;
                var input = Console.ReadLine();

                if (input == "y" || input == "Y")
                {
                    _repository.RemoveAllBooking();
                    context.NextState(new NewBookingState());
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You have not booked any ticket yet !");
            }
        }

        public void Login(BookingContext context, string userName, string password)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You are already logged in - start booking tickets !");
        }

        public void ShowBookings(BookingContext context)
        {
            var bookedMovies = _repository.GetBookedMovies();
            if (bookedMovies.Count > 0)
            {
                Helper.ShowBookings(bookedMovies);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You have not booked any ticket yet !");
            }
        }

        public void Logout(BookingContext context)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Are you sure you want to logout - Y/N: ");
            Console.ForegroundColor = ConsoleColor.Green;
            var input = Console.ReadLine();

            if (input.ToLower() == "y")
            {
                context.NextState(new GuestUserState());
            }
        }
    }
}
