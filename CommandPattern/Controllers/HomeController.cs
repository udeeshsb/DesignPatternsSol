using CommandPattern.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Command.Commands;
using Command;


namespace CommandPattern.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger; 
        ICommandManager _commandManager;
        private readonly IStore _store;
        private readonly ICart _cart;

        public HomeController(ILogger<HomeController> logger, IStore store, ICart cart, ICommandManager commandManager)
        {
            _logger = logger;
            _store = store;
            _cart = cart;
            _commandManager = commandManager;
        }

        public IActionResult Index()
        {
            DisplayCartDetail();
            return View();
        }

        [HttpPost]
        public IActionResult AddToCart()
        {
            _commandManager.Invoke(
                new AddToShoppingCartCommand(GetBook(), _store, _cart));

            DisplayCartDetail();
            return View("Index");
        }

        [HttpPost]
        public IActionResult MoveToWishList()
        {
            _commandManager.Invoke(
               new AddToWishListCommand(GetBook(), _store, _cart));

            DisplayCartDetail();
            return View("Index");
        }

        [HttpPost]
        public IActionResult Undo()
        {
            _commandManager.Undo();

            DisplayCartDetail();
            return View("Index");
        }

        private void DisplayCartDetail()
        {
            Book book = GetBook();

            ViewBag.TotalCartItems = _cart.GetShoppingCartCount(book);
            ViewBag.TotalWishListItems = _cart.GetWishListCount(book);
        }

        private Book GetBook()
        {
            return _store.GetBook("B001");
        } 
        
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
