using System;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Web.Controllers
{
    public class VideoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}