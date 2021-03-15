using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Zaj2.Models
{
    public class Address
    {
        [Display(Name = "Twoja ulubiona ulica"),StringLength(60, MinimumLength = 3,ErrorMessage = "Pole Street musi zawierać od 3 do 60 znaków"),Required(ErrorMessage = "Pole Street jest obowiązkowe")]
        public string Street { get; set; }
        [Required(ErrorMessage = "Pole ZipCode jest obowiązkowe")]
        public string ZipCode { get; set; }
        [Required(ErrorMessage ="Pole City jest obowiązkowe")]
        public string City { get; set; }
        [Required]
        public int Number { get; set; }

    }
}
