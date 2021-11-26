namespace BookingLibrary
{
    class Movie
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; }
    }

    class BookedMovie
    {
        public Movie Movie { get; set; }
        public int NoOfTickets { get; set; }
    }
}
