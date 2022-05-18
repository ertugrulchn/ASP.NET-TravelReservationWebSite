using Microsoft.AspNetCore.Mvc;

namespace TravelReservation.ViewComponents.Default
{
    public class _SliderPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
