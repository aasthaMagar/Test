using Formula1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Formula1.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("adduser")]
        public IActionResult AddUser(Register model)
        {
            return View();
        }

        public IActionResult UpdateUser(int Id)
        {
            return View();
        }

        public IActionResult DeleteUser(int Id)
        {
            return View();
        }
    }
}
