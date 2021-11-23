using System;
using System.Collections.Generic;

namespace VideoLibrary
{
    public class VideoRepository : IRepository
    {
        List<VideoDto> _videos;
        public VideoRepository()
        {
            _videos = new List<VideoDto>
            {
                new VideoDto {Id=1, Name="Green Is Gold", Path="~/Videos/HD/GreenIsGold.mp4"},
                new VideoDto {Id=2, Name="Mountain View", Path="~/Videos/HD/MountainView.mp4"},
                new VideoDto {Id=3, Name="Be Safe Covid 19", Path="~/Videos/HD/BeSafeCovid19.mp4"},
                new VideoDto {Id=4, Name="Stay Fit Stay Healthy", Path="~/Videos/HD/stayfitstayhealthy.mp4"},
            };
        }
        public IList<VideoDto> GetAllVideoDetail()
        {
            return _videos;
        }

        public string GetVideoPath(int id)
        {
            string path = string.Empty;
            foreach (var item in _videos)
            {
                if (item.Id == id)
                {
                    path = item.Path;
                    break;
                }
            }
            return path;
        }
    }
}
