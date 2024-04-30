using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace TrainingASPCORE3._1.Controllers
{
    public class Dino : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult ROAR()
        {
            string path = @"C:\Users\E01491\Desktop\Training ASP\Hello.txt";
            if (!System.IO.File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = System.IO.File.CreateText(path))
                {
                    sw.WriteLine("Hello");
                    sw.WriteLine("And");
                    sw.WriteLine("Welcome");
                }
            }
            return View("Dino");
        }
    }
}
