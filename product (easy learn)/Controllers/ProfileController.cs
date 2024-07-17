using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BLL;
using BE;
using Microsoft.AspNetCore.Authorization;

namespace product__easy_learn_.Controllers
{
    [Authorize]
    public class ProfileController : Controller
    {
    
            
        public IActionResult Index(string showBasket, string message=null)
        {
            ViewBag.showBasket = showBasket;
            if (!string.IsNullOrWhiteSpace(message))
            {
                ViewBag.SuccessPayment = message;
            }
            return View();
        }
    }
}
