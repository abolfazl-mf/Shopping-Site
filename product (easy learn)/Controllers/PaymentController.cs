using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BE;
using BLL;
using DAL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ZarinpalSandbox;

namespace product__easy_learn_.Controllers
{
    public class PaymentController : Controller
    {
        

        private UserManager<UserApp> userManager;
        public PaymentController(UserManager<UserApp> userManager)
        {
            this.userManager = userManager;
        }
        public async Task<IActionResult> Payment()
        {
            var courseIds = new List<int>();
            if (HttpContext.Session.GetString("basket") != null)
            {
                courseIds = JsonConvert.DeserializeObject<List<int>>(HttpContext.Session.GetString("basket"));
                var blc = new BLL.blcourse();
                var courses = blc.serachById(courseIds);

                var user = await userManager.FindByNameAsync(User.Identity.Name);
                blorder bl = new blorder();
                var orderCourses = new List<Order_course>();
                foreach (var item in courses)
                {
                    orderCourses.Add(new Order_course { CourseId = item.id });
                }
                bl.create(new Order
                {
                    Order_Courses = orderCourses,
                    TotalPrice = courses.Sum(s => Convert.ToInt32(s.price)),
                    userId =  user.Id 
                });
                
            }
            
            return RedirectToAction("index", "profile", new { message= "پرداخت با موفقیت انجام شد" });
        }
        public IActionResult Peyment1()
      {
            List<BE.course> o = new List<course>();
            BloggingContext db1 = new BloggingContext();
            var bl = new blcourse();
          
            
            var courseIds = new List<int>();
            if (HttpContext.Session.GetString("basket") != null)
            {
                courseIds = JsonConvert.DeserializeObject<List<int>>(HttpContext.Session.GetString("basket"));
            }
            var blc = new BLL.blcourse();
            var courses = blc.serachById(courseIds);
            
            var peyment = new Payment(courses.Sum(s => Convert.ToInt32(s.price)));
            foreach (var item in courseIds)
        {

            
            var res = peyment.PaymentRequest($"پرداخت فاکتور محصول شماره {item} ",
                "https://localhost:44330/Home/OnlinePeyment/" + item , "abulfazlmohammadi33@gmail.com", "09930013561");

            if (res.Result.Status == 100)
            {
                return Redirect("https://sandbox.zarinpal.com/pg/StartPay/" + res.Result.Authority);
                    
            }
            else
            {
                return BadRequest();
            }
        }   

        return null;
      }     
    }
}
