using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BE;
using BLL;
using DAL;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using product__easy_learn_.Models;

namespace product__easy_learn_.Controllers
{
    public class OrderController : Controller
    {
        public async Task<IActionResult> AddToBasket(int courseID)
        {
            var basketlist = new List<int>();
            //List<BasketList> c = new List<BasketList>();
            if (HttpContext.Session.GetString("basket") != null)
            {
                basketlist = JsonConvert.DeserializeObject<List<int>>(HttpContext.Session.GetString("basket")).ToList();
                //foreach (var item in basketlist)
                //{
                //    c.Add(new BasketList() { id = item });
                //}
            }

            //if (HttpContext.Session.GetString("basket") != null)
            //{
            //    c = JsonConvert.DeserializeObject<List<BasketList>>(HttpContext.Session.GetString("basket")).ToList();
            //}
            //var b = c.FirstOrDefault(t => t.id == courseID);
            //if (b != null)
            //{
            //    HttpContext.Session.SetString("basket", JsonConvert.SerializeObject(basketlist));
            //}
            //else
            //{

            //    basketlist.Add(courseID);
            //}
            basketlist.Add(courseID);
            HttpContext.Session.SetString("basket", JsonConvert.SerializeObject(basketlist));
            return RedirectToAction("details", "course", new { id = courseID });
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
