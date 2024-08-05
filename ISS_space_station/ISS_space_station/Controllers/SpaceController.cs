using Microsoft.AspNetCore.Mvc;

namespace ISS_space_station.Controllers
{
    public class SpaceController : Controller
    {
        public IActionResult Index()
        {
            return View(); 
        }
    }
}
