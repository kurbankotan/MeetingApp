using MeetingApp.Models;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class HomeController: Controller
    {
        public IActionResult Index()
        {

            int saat = DateTime.Now.Hour;
            //ViewBag.selamlama = saat>12 ? "İyi Günler":"Günaydın";
            ViewData["Selamlama"] = saat>12 ? "İyi Günler":"Günaydın";
            int UserCount = Repository.Users.Where(i=>i.WillAttend == true).Count();
            //ViewBag.UserName = "Mustafa";

            var meetingInfo = new MeetingInfo()
            {
                Id = 1,
                Location = "Düzce, Konuarlp Kongre Mezkezi",
                Date = new DateTime(2024,06,01, 19,0,0),
                NumberOfPeople = UserCount
            };
            
            return View(meetingInfo);
        }
    }
}