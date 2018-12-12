using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToysShop_Core_Project.Models
{
    public class Toy
    {
        [Key]
        public string ItemId { get; set; }

        [Required]
        public string ToyName { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public string ToyColor { get; set; }

        [Required]
        public decimal Price { get; set; }

        public string Dalia { get; set; }
    }
}
