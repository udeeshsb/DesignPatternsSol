using System.Collections.Generic;

namespace BookingLibrary
{
    interface IRepository
    {
        List<Movie> GetAllMovies();
        List<BookedMovie> GetBookedMovies();
        void AddBooking(int movieId, int noOfTicket);
        void RemoveAllBooking();
        bool Authenticate(string userName, string password);
    }

    class MovieRepository : IRepository
    {
        List<Movie> _movieList;
        Dictionary<int, int> _bookedMovies;
        public MovieRepository()
        {
            _movieList = new List<Movie>
            {
                new Movie {MovieId=1, MovieName="Titanic"},
                new Movie {MovieId=2, MovieName="Cast Away"},
                new Movie {MovieId=3, MovieName="Saving Private Ryan"}
            };

            _bookedMovies = new Dictionary<int, int>();
        }
        public void AddBooking(int movieId, int noOfTicket)
        {
            if (_bookedMovies.ContainsKey(movieId))
                return;


            _bookedMovies[movieId] = noOfTicket;
        }

        public void RemoveAllBooking()
        {
            _bookedMovies.Clear();
        }

        public List<Movie> GetAllMovies()
        {
            return _movieList;
        }

        public List<BookedMovie> GetBookedMovies()
        {
            List<BookedMovie> bookedMovies = new List<BookedMovie>();
            foreach (var movieId in _bookedMovies)
            {
                BookedMovie bookedMovie = new BookedMovie();
                var movie = _movieList.Find(x => x.MovieId == movieId.Key);

                bookedMovie.Movie = movie;
                bookedMovie.NoOfTickets = movieId.Value;

                bookedMovies.Add(bookedMovie);
            }

            return bookedMovies;
        }

        public bool Authenticate(string userName, string password)
        {
            return true;
        }
    }
}
