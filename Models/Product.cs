using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToysShop_Core_Project.Models
{
    public class Product
    {
        [Key]
        public string ItemId { get; set; }

        [Required]
        public string CartId { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public int ProductID { get; set; }

        [Required]
        public string Brandname { get; set; }

    }
}
