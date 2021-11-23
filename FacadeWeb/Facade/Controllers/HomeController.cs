using Contracts;
using Facade.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace Facade.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ILoginFacade _loginFacade;

        public HomeController(ILogger<HomeController> logger, ILoginFacade loginFacade)
        {
            _logger = logger;
            _loginFacade = loginFacade;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string email, string password)
        {

            //This code is show to clients, to avoid to explain this code and its details, we need to go to Facade pattern

            //var validation = new ValidationService();
            //if (validation.IsValidated(email, password))
            //{
            //    var authentication = new AuthenticationService();
            //    if (authentication.IsAuthenticated(email, password))
            //    {
            //        var authorization = new AuthorizationService();
            //        if (authentication.IsAuthenticated(email, password))
            //        {
            //            return RedirectToAction("Home");
            //        }
            //    }
            //}


            if (_loginFacade.CanLogin(email, password))
            {
                return RedirectToAction("Home");
            }
            return Index();
        }

        public IActionResult Home()
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
