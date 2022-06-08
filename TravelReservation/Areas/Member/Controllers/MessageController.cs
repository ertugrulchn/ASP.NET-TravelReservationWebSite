using Microsoft.AspNetCore.Mvc;

namespace TravelReservation.Areas.Member.Controllers
{
    public class MessageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
