using System;
using System.Collections.Generic;
using VideoLibrary;
namespace VideoGalleryPresentation.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
