using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace randomPasscodeGenerator.Controllers
{
    public class HomeController : Controller
    {
        r
            int? _count = HttpContext.Session.GetInt32("Count");
            if (_count !=null)
            {
                _count += 1;
                HttpContext.Session.SetInt32("Count", (int)_count);
            }
            else
            {
                _count = 1;
                HttpContext.Session.SetInt32("Count", (int)_count);
            }
            string RandomPassword = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            string output = "";
            Random rand = new Random();
            for (var i=0; i<=14; i++)
            {
                output += RandomPassword[rand.Next(RandomPassword.Length)];

            }
            ViewBag.Count = _count;
            ViewBag.output = output;
            return View();
        }
        [HttpPost("generate")]
        public IActionResult Generate()
        {
            return RedirectToAction("Index");
        }
    }
}