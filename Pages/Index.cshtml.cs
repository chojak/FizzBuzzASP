using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using FizzBuzz.Models;

namespace FizzBuzz.Pages
{
    public class IndexModel : PageModel
    {
        public FizzBuzx fizzbuzz { get; set; }
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
        public IActionResult OnPost(FizzBuzx fizzbuzz)
        {
           if (ModelState.IsValid)
           {
                fizzbuzz.result = string.Empty;
                fizzbuzz.date = DateTime.Now;
                if (fizzbuzz.number % 3 == 0)
                    fizzbuzz.result += "Fizz";
                if (fizzbuzz.number % 5 == 0)
                    fizzbuzz.result += "Buzz";
                if (fizzbuzz.result.Length == 0)
                    fizzbuzz.result = "Liczba: " + fizzbuzz.number + " nie spelnia kryteriow Fizz/Buzz";

                HttpContext.Session.SetString("FizzBuzz", JsonConvert.SerializeObject(fizzbuzz));
                System.Diagnostics.Debug.WriteLine(JsonConvert.SerializeObject(fizzbuzz));
                return RedirectToPage("./Adress");
           }
           return Page();
        }
    }
}
