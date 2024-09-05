using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnnotations
{
    internal class Customer
    {
        [Required]
        public string Name { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Range(1, double.MaxValue, ErrorMessage = "The price must be a positive number.")]
        public int Age { get; set; }

    }
}
