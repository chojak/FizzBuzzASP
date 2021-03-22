using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FizzBuzz.Models
{
    public class FizzBuzx
    {
        public string result { get; set; }
        [Range(1, 1000, ErrorMessage = "Invalid input data")]
        [Required]
        public int number { get; set; }
        public DateTime date { get; set; } 
    }
}
