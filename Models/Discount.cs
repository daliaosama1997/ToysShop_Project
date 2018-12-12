using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToysShop_Core_Project.Models
{
    public class Discount
    {
        [Key]
        public int DisID { get; set; }

        [Required]
        public string ToyName { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [Required]
        public decimal totalDiscount { get; set; }
    }
}
