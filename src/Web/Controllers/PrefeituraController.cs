using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace Web.Controllers
{
    public class PrefeituraController : Controller
    {
        public IActionResult EquipeDeGoverno()
        {
            return View();
        }
    }
}