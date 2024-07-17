using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BE;
using BLL;
using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json.Linq;

namespace product__easy_learn_.Controllers
{
    public class teacherController : Controller
    {
        private IWebHostEnvironment Environment;
        public teacherController(IWebHostEnvironment _environment)
        {
            Environment = _environment;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult createTeacher()
        {
            return View("createTeacher");
        }
        public IActionResult showall()
        {
            blteacher bl = new blteacher();
            return View("show teachers", bl.getskip(0));
        }

        //start crud and ...
        [HttpPost]
        public IActionResult create(Models.teacher t)
        {
            blteacher bl = new blteacher();
            BE.teacher b = new teacher();
            b.name = t.name;
            b.family = t.family;
            b.email = t.email;
            UploadFile upf = new UploadFile(Environment);
            b.picture = upf.upload(t.picture);
            bl.create(b);
            return RedirectToAction("showall","teacher");

        }
        public JsonResult tsjson()
        {
            return Json(new { redirect = "search" });
        }
        public IActionResult search(string tags)
        {
            JArray jsonArray = JArray.Parse(tags);
            List<string> split = new List<string>();
            foreach (dynamic item in jsonArray)
            {
                split.Add(item.tag.ToString());
            }
            blteacher bl = new blteacher();
            List<teacher> ll = bl.search(split);
            return View("show teachers", ll);


        }
        public void update(Models.teacher t)
        {
            blteacher bl = new blteacher();
            BE.teacher b = new teacher();
            b.id = t.id;
            b.name = t.name;
            b.family = t.family;
            b.email = t.email;
            UploadFile upf = new UploadFile(Environment);
            b.picture = upf.upload(t.picture);
            bl.update(b);
           
          
        }
        public IActionResult getskip(int c)
        {
            blteacher bl = new blteacher();
            ViewBag.pageId = c;
            return View("show teachers", bl.getskip(c));
        }
    }
    }
