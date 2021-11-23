using System.Collections.Generic;
using VideoLibrary;

namespace VideoGalleryPresentation.Proxy
{
    public class ProxyRepository : IRepository
    {
        public bool IsHDRequested { get; set; }
        List<VideoDto> _videos;
        public ProxyRepository()
        {
            _videos = new List<VideoDto>
            {
                new VideoDto {Id=1, Name="Green Is Gold", Path="~/Videos/GreenIsGold.mp4"},
                new VideoDto {Id=2, Name="Mountain View", Path="~/Videos/MountainView.mp4"},
                new VideoDto {Id=3, Name="Be Safe Covid 19", Path="~/Videos/BeSafeCovid19.mp4"},
                new VideoDto {Id=4, Name="Stay Fit Stay Healthy", Path="~/Videos/stayfitstayhealthy.mp4"},
            };
        }
        public IList<VideoDto> GetAllVideoDetail()
        {
            return _videos;
        }

        public string GetVideoPath(int id)
        {
            string path = string.Empty;
            if (IsHDRequested)
            {
                var hdRepository = new VideoRepository();
                path = hdRepository.GetVideoPath(id);
            }
            else
            {
                foreach (var item in _videos)
                {
                    if (item.Id == id)
                    {
                        path = item.Path;
                        break;
                    }
                }
            }
            return path;
        }
    }
}
