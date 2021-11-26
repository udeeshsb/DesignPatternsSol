namespace BookingLibrary
{
    interface IBookingSystem
    {
        void Login(BookingContext context, string userName, string password); 
        void BookTicket(BookingContext context);
        void ShowBookings(BookingContext context);
        void CancelBooking(BookingContext context);
        void Logout(BookingContext context);
    }
}


