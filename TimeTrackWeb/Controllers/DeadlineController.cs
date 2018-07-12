using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TimeTrackWeb.Controllers
{
    public class DeadlineController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


    }
}