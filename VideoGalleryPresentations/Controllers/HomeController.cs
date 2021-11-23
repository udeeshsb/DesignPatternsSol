using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VideoGalleryPresentation.Models;
using VideoGalleryPresentation.Proxy; 
using VideoLibrary;

namespace VideoGalleryPresentation.Controllers
{
    public class HomeController : Controller
    {
        private bool _isHD;
        private readonly IRepository _repository;

        public HomeController(IRepository repository)
        {
            _repository = repository;
        }
        public IActionResult Index(int videoId)
        {
            var videoModel = new VideoViewModel
            {
                Videos = _repository.GetAllVideoDetail(),
            };

            ((ProxyRepository)_repository).IsHDRequested = _isHD;
            videoModel.Path = _repository.GetVideoPath(videoId);
            return View(videoModel);
        }
        [HttpPost]
        public IActionResult Index(VideoViewModel viewModel, string HD)
        {
            _isHD = string.IsNullOrEmpty(HD) ? false : true;
            return Index(viewModel.SelectedVideoId);
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
