using Microsoft.AspNetCore.Mvc;

namespace Event_Management_System.Controllers
{
    public class EventController : Controller
    {
        public IActionResult LogIN()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
    }
}
