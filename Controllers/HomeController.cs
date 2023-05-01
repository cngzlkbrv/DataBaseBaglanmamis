using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplicationNew.Models;

namespace WebApplicationNew.Controllers
{
    public class HomeController : Controller
    {
      
        private List<Human>humans=new List<Human>();
        public IActionResult Index()

        {
            Human human1 = new Human()
            {
                Id= 1,
                FullName="Jack",
                ImgUrl= "team-1.jpg"
            };
            Human human2 = new Human()
            {
                Id = 2,
                FullName = "Melik",
                ImgUrl = "team-2.jpg"
            };
            Human human3 = new Human()
            {
                Id = 3,
                FullName = "Kecel",
                ImgUrl = "team-3.jpg"
            };
            humans.Add(human1);
            humans.Add(human2);
            humans.Add(human3);
            return View(humans);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}