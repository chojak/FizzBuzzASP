using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using FizzBuzz.Models;

namespace FizzBuzz.Pages
{ 
    public class AdressModel : PageModel
    {
        public FizzBuzx fizzbuzz1 { get; set; }

        public void OnGet()
        {
            string FizzBuxx = HttpContext.Session.GetString("FizzBuzz");

            

            if (FizzBuxx != null)
                fizzbuzz1 = JsonConvert.DeserializeObject<FizzBuzx>(FizzBuxx);
        }

    }
}
