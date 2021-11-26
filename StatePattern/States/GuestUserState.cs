using System;
using System.Collections.Generic;
using System.Text;

namespace BookingLibrary
{
    class GuestUserState : IBookingSystem
    {
        IRepository _repository;
        public GuestUserState()
        {
            _repository = SingletonRepository.GetInstance;
        }
        public void Login(BookingContext context, string userName, string password)
        {
            if (_repository.Authenticate(userName, password))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("USER LOGGED IN !");
                context.NextState(new NewBookingState());
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("LOGIN FAILED !");
            }
        }

        public void CancelBooking(BookingContext context)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You Must Login First !");
        }

        public void BookTicket(BookingContext context)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You Must Login First !");
        }

        public void ShowBookings(BookingContext context)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You Must Login First !");
        }

        public void Logout(BookingContext context)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You Have Not Logged In Yet !");
        }
    }
}
