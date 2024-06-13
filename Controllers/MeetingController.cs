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

            if(ModelState.IsValid)
            {
                Repository.CreateUser(model);
                ViewBag.UserCount = Repository.Users.Where(i=>i.WillAttend == true).Count();
                return View("Thanks", model);
            }
            else
            {
                return View();
            }

        }

        [HttpGet]
        public IActionResult List()
        {

            return View(Repository.Users);
        }


        //meeting/details/1
        //meeting/details/2
        //meeting/details/3

        [HttpGet]
        public IActionResult Details(int id)
        {
            return View(Repository.GetById(id));
        }

    }
}