using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ToysShop_Core_Project.Controllers
{
    public class ShopNowController : Controller
    {
        public IActionResult ShopNow()
        {
            return View();
        }
    }
}