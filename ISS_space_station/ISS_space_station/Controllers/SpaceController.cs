using ISS_space_station.Interfaces;
using ISS_space_station.Models.IIS;
using Microsoft.AspNetCore.Mvc;

namespace ISS_space_station.Controllers
{
    public class SpaceController : Controller
    {
        private IDownload _download;

        public SpaceController(IDownload download)
        {
            _download = download;
        }

        public async Task<IActionResult> Index()
        {
            var info = await _download.GetData();

            if (info == null)
            {
                return NotFound();
            }

            return View(info); 
        }
    }
}
