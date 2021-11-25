using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Command
{
    public interface ICart
    {
        void IncreaseShoppingCartItem(Book bookItem);
        void DecreaseShoppingCartItem(Book bookItem);
        void IncreaseWishListItem(Book bookItem);
        void DecreaseWishListItem(Book bookItem);
        int GetShoppingCartCount(Book bookItem);
        int GetWishListCount(Book bookItem);
    }
    public class BookShoppingCart : ICart
    {
        private readonly IStore _store;

        Dictionary<string, (Book book, int total)> _shoppingCart;
        Dictionary<string, (Book book, int total)> _wishList;

        public BookShoppingCart()
        {
            _shoppingCart = new Dictionary<string, (Book book, int total)>();
            _wishList = new Dictionary<string, (Book book, int total)>();
        }

        public int GetShoppingCartCount(Book bookItem)
        {
            if (_shoppingCart.ContainsKey(bookItem.BookId))
                return _shoppingCart[bookItem.BookId].total;

            return 0;
        }

        public int GetWishListCount(Book bookItem)
        {
            if (_wishList.ContainsKey(bookItem.BookId))
                return _wishList[bookItem.BookId].total;

            return 0;
        }

        public void IncreaseShoppingCartItem(Book bookItem)
        {
            if (_shoppingCart.ContainsKey(bookItem.BookId))
            {
                var book = _shoppingCart[bookItem.BookId];
                _shoppingCart[bookItem.BookId] = (book.book, book.total + 1);
            }
            else
            {
                _shoppingCart[bookItem.BookId] = (bookItem, 1);
            }
        }

        public void DecreaseShoppingCartItem(Book bookItem)
        {
            if (_shoppingCart.ContainsKey(bookItem.BookId))
            {
                var book = _shoppingCart[bookItem.BookId];
                _shoppingCart[bookItem.BookId] = (book.book, book.total - 1);
            }
        }

        public void IncreaseWishListItem(Book bookItem)
        {
            if (_wishList.ContainsKey(bookItem.BookId))
            {
                var book = _wishList[bookItem.BookId];
                _wishList[bookItem.BookId] = (book.book, book.total + 1);
            }
            else
            {
                _wishList[bookItem.BookId] = (bookItem, 1);
            }
        }

        public void DecreaseWishListItem(Book bookItem)
        {
            if (_wishList.ContainsKey(bookItem.BookId))
            {
                var book = _wishList[bookItem.BookId];
                _wishList[bookItem.BookId] = (book.book, book.total - 1);
            }
        }
    }
}
