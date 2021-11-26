using BookingLibrary;
using System;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is State Design Pattern under Behavioral Pattern\n");
            Console.WriteLine("\nThis pattern is used when there are one too many relationships between objects such as if one object is modified, its dependent objects are to be notified automatically. State Design Pattern is used to alter the behavior of an object when it’s internal state changes.In this pattern, an object is created which represent various states and a context object whose behavior varies as it's state object changes.\n\n");

            Console.WriteLine("State Design Pattern allows an object to alter its behavior when its internal state changes. In simple words, we can say that the State Pattern is a design pattern that allows an object to completely change its behavior depending upon its current internal state\n\n");
            NowShowingMovies();
            var bookingSystem = new BookingContext();

            // show instructions
            Console.WriteLine("Movie Ticket Booking System");
            Console.WriteLine("1: Login");
            Console.WriteLine("2: New Booking");
            Console.WriteLine("3: Show Result");
            Console.WriteLine("4: Cancel Ticket");
            Console.WriteLine("5: Logout");

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\nEnter Request: ");
                string command = Console.ReadLine();

                if (int.Parse(command) > 5)
                {
                    Console.WriteLine("Invalid Request - Please enter valid request number.");
                    break;
                }

                switch (command)
                {
                    case "1":
                        bookingSystem.Login("DummyUser", "DummyPassword");
                        break;
                    case "2":
                        bookingSystem.BookTicket();
                        break;
                    case "3":
                        bookingSystem.ShowResult();
                        break;
                    case "4":
                        bookingSystem.Cancel();
                        break;
                    case "5":
                        bookingSystem.LogOut();
                        break;
                }
            }
        }

        private static void NowShowingMovies()
        {
            Console.WriteLine("\n\t\t\tNow Showing");
            Console.WriteLine("-----------------------------------------------------------");

            var movies = SingletonRepository.GetInstance.GetAllMovies();
            int serialNumber = 1;
            foreach (var movie in movies)
            {
                Console.Write($"{serialNumber}. {movie.MovieName} \t");
                serialNumber++;
            }

            Console.WriteLine("\n-----------------------------------------------------------\n");
        }
    }
}
