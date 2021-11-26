namespace BookingLibrary
{
    public interface IBookingSystem
    {
        void Login(string userName, string password); 
        void NewBooking();
        void ShowBookings();
        void CancelBooking();
        void Logout();
    }
}


