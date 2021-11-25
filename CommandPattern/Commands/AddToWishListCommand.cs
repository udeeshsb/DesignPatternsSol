using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Command.Commands
{
    public class AddToWishListCommand : ICommand
    {
        private readonly Book _book;
        private readonly IStore _bookStore;
        private readonly ICart _cart;

        public AddToWishListCommand(Book book, IStore bookStore, ICart cart)
        {
            _book = book;
            _bookStore = bookStore;
            _cart = cart;
        }
        public bool CanExecute()
        {
            return _bookStore.GetTotalStock(_book.BookId) > 0;
        }

        public void Execute()
        {
            _bookStore.DecreaseStock(_book.BookId);
            _cart.IncreaseWishListItem(_book);
        }

        public void Undo()
        {
            _bookStore.IncreaseStock(_book.BookId);
            _cart.DecreaseWishListItem(_book);
        }
    }
}
