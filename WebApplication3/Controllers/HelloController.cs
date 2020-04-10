using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication3.Controllers
{
    public class HelloController : Controller
    {

        public IActionResult Index(string code)
        {
            Dictionary<string, string[]> students = new Dictionary<string, string[]>(10);
            students.Add("1704BB99", new string[2] { "Beka Bershimbekov",  "dovn"});
            students.Add("1704AT99", new string[2] { "Azamat Tleubekov", "dovn" });
            students.Add("1704AK99", new string[2] { "Azamat Kenzhebayev", "dovn" });

            if (!string.IsNullOrEmpty(code))
            {
                string result = "";
                foreach (KeyValuePair<string, string[]> keyValue in students)
                {
                    if (keyValue.Key.Equals(code))
                    {
                        result = result + keyValue.Value[0];
                    }
                    
                }
                ViewData["Message"] = result;
            }
            //else if (code.Equals("1704BB99"))
            //{
            //    string result = "";
            //    foreach (KeyValuePair<string, string[]> keyValue in students)
            //    {
            //        result = result +  keyValue.Value[0];
            //    }
            //    ViewData["Message"] = result;
            //}
            else
            {
                    
            }

            return View();
        }
    }
}