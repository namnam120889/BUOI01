using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BUOI01.Controllers
{
    public class DefaultController : Controller
    {
        //TAO ACTION KHAC
        public string CHUOi()
        {
            return "Hello";
        }

        public int SO()
        {
            return new Random().Next(1000,10000);
        }

       

        public IActionResult Index()
        {
            return View();
        }
    }
}