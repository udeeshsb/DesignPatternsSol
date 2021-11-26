using System;
using System.Collections.Generic;
using System.Text;

namespace BookingLibrary
{
    class BookingContext
    {
        private IBookingSystem _state;

        public BookingContext()
        {
            _state = new GuestUserState();
        }

        public void NextState(IBookingSystem state)
        {
            _state = state;
        }

        public void Login(string userName, string password)
        {
            _state.Login(this, userName, password);
        }

        public void BookTicket()
        {
            _state.BookTicket(this);
        }

        public void ShowResult()
        {
            _state.ShowBookings(this);
        }

        public void Cancel()
        {
            _state.CancelBooking(this);
        }

        public void LogOut()
        {
            _state.Logout(this);
        }
    }
}
