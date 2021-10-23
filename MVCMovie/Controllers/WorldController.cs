using Microsoft.AspNetCore.Mvc;

namespace MVCMovie.Controllers
{
    public class WorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //public string Index()
        //{
        //    return "This is my default action...";
        //}

        // 
        // GET: /HelloWorld/Welcome/ 

        public IActionResult Welcome(string name, int id = 1)
        {
            ViewData["msg"] = "WELCOME" + name;
            ViewData["ID"] = id;
            return View();
        }
    }

}
