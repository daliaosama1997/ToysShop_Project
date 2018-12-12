using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToysShop_Core_Project.Models
{
    public class LoginModel
    {

        [Key]
        public int ID { get; set; }
        public string Username { get; set; }
        public int Password { get; set; }
    }
}
