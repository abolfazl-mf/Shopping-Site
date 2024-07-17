using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BE;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using product__easy_learn_.Models;

namespace product__easy_learn_.Controllers
{
    public class AccountController : Controller
    {



        private UserManager<UserApp> UserManager;
        private SignInManager<UserApp> SignInManager;
        public AccountController(UserManager<UserApp> userManager, SignInManager<UserApp> signInManager)
        {
            this.UserManager = userManager;
            SignInManager = signInManager;
        }
        public async Task<IActionResult> Login()
        {
            return View();
        }



        [HttpPost]
        public async Task<IActionResult> Login(RegisterModel model)
        {
            if (model.UserName==null)
            {
                ModelState.AddModelError("", "لطفا نام کاربری را وارد نمائید");
                return View(model);
            }
            if (model.Password==null)
            {
                ModelState.AddModelError("", "لطفا رمز عبور را وارد نمائید");
                return View(model);
            }
            var user = await UserManager.FindByNameAsync(model.UserName);
            if (user==null)
            {
                ModelState.AddModelError("", "کاربری با این نام کاربری پیدا نشد");
                return View(model);
            }
            var SignInResult = await SignInManager.PasswordSignInAsync(user, model.Password, true, false);
            if (!SignInResult.Succeeded)
            {
                ModelState.AddModelError("", "نام کاربری یا رمز عبور شما اشتباه است");
                return View(model);
            }

            return RedirectToAction("index", "Home");
        }


        public async Task<IActionResult> Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            if (model.FirstName==null)
            {
                ModelState.AddModelError("", "لطفا نام را وارد نمائید");
                return View(model);
            }
            if (model.LastName == null)
            {
                ModelState.AddModelError("", "لطفا نام خانوادگی را وارد نمائید");
                return View(model);
            }
            if (model.UserName == null)
            {
                ModelState.AddModelError("", "لطفا نام کاربری را وارد نمائید");
                return View(model);
            }
            if (model.Email == null)
            {
                ModelState.AddModelError("", "لطفا ایمیل را وارد نمائید");
                return View(model);
            }
            if (model.Password == null)
            {
                ModelState.AddModelError("", "لطفا رمز عبور را وارد نمائید");
                return View(model);
            }
            if (model.PasswordTwo == null)
            {
                ModelState.AddModelError("", "لطفا تکرار رمز عبور را وارد نمائید");
                return View(model);
            }
            var user = await UserManager.FindByNameAsync(model.UserName);
            if (user != null)
            {
                ModelState.AddModelError("", "این نام کاربری در سیستم وجود دارد");
                return View(model);
            }

            if (model.Password.Length < 4)
            {
                ModelState.AddModelError("", "رمز وارد شده کمتر از 4 رقم است");
                return View(model);
            }
            if (model.Password != model.PasswordTwo)
            {
                ModelState.AddModelError("", "رمز عبور همسان نیست");
                return View(model);
            }
            
              var user1 = new UserApp
            {
                UserName = model.UserName,
                Email=model.Email,
                FirstName=model.FirstName,
                LastName=model.LastName
            };
            var addResult =await UserManager.CreateAsync(user1, model.Password);
            if (addResult.Succeeded)
            {
                ModelState.AddModelError("", "تبریک ثبت نام با موفقیت انجام شد");
                return View(model);
            }

            return RedirectToAction("Index","Home");
        }
        public async Task<IActionResult> Logout()
        {
            if (User.Identity.IsAuthenticated)
            {
                await SignInManager.SignOutAsync();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
