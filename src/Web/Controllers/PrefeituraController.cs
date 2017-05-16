using System;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Web.Controllers
{
    public class PrefeituraController : Controller
    {
        public IActionResult EquipeDeGoverno()
        {
            return View(LoadJson());
        }

        public IActionResult Unidades()
        {
            return View(LoadJson());
        }

        public dynamic LoadJson()
        {
            dynamic dados;
            using (StreamReader r = System.IO.File.OpenText("dados.json"))
            {
                string json = r.ReadToEnd();
                dados = JsonConvert.DeserializeObject(json);
            }
            return dados;
        }
    }
}