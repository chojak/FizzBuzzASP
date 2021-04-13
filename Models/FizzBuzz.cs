using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FizzBuzz.Models
{
    public class FizzBuzx
    {
        public void FizzBuzzCheck()
        {
            this.result = string.Empty;
            this.date = DateTime.Now;
            if (this.number % 3 == 0)
                this.result += "Fizz";
            if (this.number % 5 == 0)
                this.result += "Buzz";
            if (this.result.Length == 0)
                this.result = "Liczba: " + this.number + " nie spelnia kryteriow Fizz/Buzz";
        }
        public string result { get; set; }
        [Range(1, 1000, ErrorMessage = "Invalid input data")]
        [Required]
        public int number { get; set; }
        public DateTime date { get; set; } 
    }
}
