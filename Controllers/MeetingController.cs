using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    
    public class MeetingController : Controller
    {


        [HttpGet]
        public IActionResult Apply()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Apply(UserInfo model)
        {
            //database
            //list
            Repository.CreateUser(model);
            ViewBag.UserCount = Repository.Users.Where(i=>i.WillAttend == true).Count();
            return View("Thanks", model);
        }

        [HttpGet]
        public IActionResult List()
        {

            return View(Repository.Users);
        }



    }
}