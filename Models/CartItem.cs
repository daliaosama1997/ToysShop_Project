using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToysShop_Core_Project.Models
{
    public class CartItem
    {
        [Key]
        public string ItemId { get; set; }

        [Required]
        public string CartId { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public System.DateTime DateCreated { get; set; }

        [Required]
        public int ProductId { get; set; }

        [Required]
        public virtual Product Product { get; set; }
    }
}
