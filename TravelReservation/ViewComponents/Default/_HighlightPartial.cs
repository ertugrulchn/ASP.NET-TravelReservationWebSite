using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TravelReservation.ViewComponents.Default
{
    public class _HighlightPartial : ViewComponent
    {
        HighlightManager highlightManager = new HighlightManager(new EfHighlightDal());

        public IViewComponentResult Invoke()
        {
            var values = highlightManager.TGetList();
            return View(values);
        }
    }
}
