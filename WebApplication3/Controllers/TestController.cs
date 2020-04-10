using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication3.Controllers
{
    public class TestController : Controller
    {

        Dictionary<string, string[]> students = new Dictionary<string, string[]>(10);

        [HttpGet]
        public IActionResult Login()
        {
           

            return View();
        }
        [HttpPost]
        public IActionResult Login(string name, string group, string date, string search)
        {
            if (string.IsNullOrEmpty(search))
            {
                string authData = $"Name: {name}   Group: {group}   Date: {date}";
                string code = "";


                code = code + date[2] + date[3];


                string[] name1 = name.Split(new char[] { ' ' });

                foreach (string s in name1)
                {
                    code = code + s[0];
                }
                Console.WriteLine(code);

                code = code + group;

                //code = code + 
                //students.Add("1704BB99", new string[2] { "Beka Bershimbekov", "dovn" });

                students.Add(code, new string[3] { name, group, date });
                ViewData["Message"] = authData + " Code: " + code;

                return View();
            }
            else
            {
                string result = "";
                foreach (KeyValuePair<string, string[]> keyValue in students)
                {
                    if (keyValue.Key.Equals(search))
                    {
                        result = result + keyValue.Value[0];
                    }

                }
                ViewData["Message"] = result+ "hz";

                return View();

            }
            
            // Content(authData);
        }
    }
}