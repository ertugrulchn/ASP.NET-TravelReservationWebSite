using Microsoft.AspNetCore.Mvc;

namespace TravelReservation.Areas.Member.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
