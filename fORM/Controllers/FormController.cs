using Microsoft.AspNetCore.Mvc;
using fORM.Models;
using System;
using System.Text;


namespace fORM.Controllers
{
    public class FormController : Controller
    {
        [HttpGet]
        public ActionResult Login()
        {

            return View();
        }

        //public ActionResult Index( model)
        //{
        //    return View();
        //}
    }
}
