using System.Collections.Generic;

namespace VideoLibrary
{
    public interface IRepository
    {
        IList<VideoDto> GetAllVideoDetail();
        string GetVideoPath(int id);
    }
}
