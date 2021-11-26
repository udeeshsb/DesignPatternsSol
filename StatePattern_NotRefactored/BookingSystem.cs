using System;
using System.Collections.Generic;
using System.Text;

namespace BookingLibrary
{
    public class BookingSystem : IBookingSystem
    {
        private bool _isUserLoggedIn = false;
        private bool _isTicketBooked = false;
        private bool _isNew = false;

        IRepository _repository;
        public BookingSystem()
        {
            _repository = SingletonRepository.GetInstance;
        }
      
        public void Login(string userName, string password)
        {
            if(_repository.Authenticate(userName, password))
            {
                _isUserLoggedIn = true;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("User logged in successfully");
                _isNew = true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Login failed");
            }
        }

        public void NewBooking()
        {
            if(_isUserLoggedIn == true)
            {
                if (_isNew == true)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\tEnter movie number: ");
                    var movieId = int.Parse(Console.ReadLine());
                    Console.Write("\tHow many tickets you need: ");
                    var noOfTicket = int.Parse(Console.ReadLine());

                    _repository.AddBooking(movieId, noOfTicket);

                    _isTicketBooked = true;

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Ticket booked successfully !");
                }
                else
                {
                    Console.WriteLine("You cannot book a ticket at this time");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You must login to book a ticket !");
            }
        }

        public void ShowBookings()
        {
            if (_isUserLoggedIn == true)
            {
                if(_isTicketBooked == true)
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
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid action ! Login and start booking ticket");
            }
        }

        public void CancelBooking()
        {
            if (_isUserLoggedIn == true)
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
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You have not booked any ticket yet !");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid action ! Login and start booking ticket");
            }
        }

        public void Logout()
        {
            if (_isUserLoggedIn == true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Are you sure you want to logout - Y/N: ");

                Console.ForegroundColor = ConsoleColor.Green;
                var input = Console.ReadLine();

                if (input == "y" || input == "Y")
                {
                    _isUserLoggedIn = false;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid action ! Login and start booking ticket");
            }
        }

    }
}
