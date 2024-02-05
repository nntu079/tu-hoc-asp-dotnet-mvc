using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class TuTestController : Controller
    {
        public IActionResult Index()
        {
            //truyền data từ controller vào view 2 cách viewbag và model
            ViewBag.WelcomeString = "Chào mừng bạn với ViewBag";

            var message = new MessageModel();
            message.Welcome = "Chào mới đến với model";

            return View(message);
        }
    }
}
