using Microsoft.AspNetCore.Mvc;

namespace Lab2.Controllers
{
    public class ResolveController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SubmitForm(string name, string email, string tourType)
        {
            ViewBag.Name = name;
            ViewBag.Email = email;
            ViewBag.TourType = tourType;
            return View("ThankYou");
        }
    }
}
