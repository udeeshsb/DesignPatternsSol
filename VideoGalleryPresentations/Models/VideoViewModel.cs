using System.Collections.Generic;
using VideoLibrary;

namespace VideoGalleryPresentation.Models
{
    public class VideoViewModel
    {
        public IEnumerable<VideoDto> Videos { get; set; }
        public int SelectedVideoId { get; set; }
        public string Path { get; set; }
    }
}
