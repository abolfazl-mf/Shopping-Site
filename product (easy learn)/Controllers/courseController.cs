using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BE;
using BLL;
using DAL;
using DocumentFormat.OpenXml.Office.CustomUI;
using DocumentFormat.OpenXml.Office2010.CustomUI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Globalization;

namespace product__easy_learn_.Controllers
{
    public class courseController : Controller
    {
        
        
        private IWebHostEnvironment Environment;
        public courseController(IWebHostEnvironment _environment)
        {
            Environment = _environment;
        }
        
        public IActionResult Index()
        {
            blteacher blt = new blteacher();
            ViewBag.teachers = blt.readall();
            return View();
        }
        public IActionResult readall()
        {
            blcourse blc = new blcourse();
            ViewBag.courses = blc.readall();
            return View();
        }
        public ActionResult details(int id)
        {
            blcourse blc = new blcourse();
            course c = new course();
            c = blc.searchbyid(id);
            return View(c);
        }

        //start crud and ...
        [HttpPost]
        public IActionResult create(Models.course t)
        {
            blcourse bl = new blcourse();
            BE.course b = new course();
            b.title = t.title;
            b.price = t.price;
            b.descript = t.descript;
            b.totaltime = t.totaltime;
            UploadFile upf = new UploadFile(Environment);
            b.videointro = upf.uploadVideo(t.videointro);


            UploadFile upf1 = new UploadFile(Environment);
            b.picture = upf1.upload1(t.picture);
            var c=bl.create(b);

            teacher_course tc = new teacher_course();
BloggingContext db1 = new BloggingContext();

            foreach (var item in t.teachers)
            {
                
                tc.teacherID = item;
                tc.courseID = c.id;
                db1.teacher_Courses.Add(tc);
                
            }
            db1.SaveChanges();
            return RedirectToAction("readall", "course");
        }

        public JsonResult tsjson()
        {
            return Json(new { redirect = "search" });
        }
        public IActionResult search(string s)
        {
            
            blcourse blc = new blcourse();
            List<BE.course> ll = blc.search(s);
            ViewBag.courses = ll;
            return View("readall");


        }
        public string update(Models.course t)
        {
            blcourse bl = new blcourse();
            BE.course b = new course();
            BloggingContext db = new BloggingContext();
            b.id = t.id;
            b.title = t.title;
            b.price = t.price;
            b.totaltime =t.totaltime;
            UploadFile upf1 = new UploadFile(Environment);
            b.picture = upf1.upload1(t.picture);
            if (b.videointro != null)
            {
            UploadFile upf = new UploadFile(Environment);
            b.videointro = upf.uploadVideo(t.videointro);

            }
           
            bl.update(b);
            return "";
        }
        public ActionResult edit(int id)
        {
            blcourse blc = new blcourse();
            var becourse= blc.searchbyid(id);
            blteacher blt = new blteacher();
            ViewBag.teachers = blt.readall();

            var modelCourse = new Models.course
            {
                title = becourse.title,
                price = becourse.price,
                descript = becourse.descript,
                totaltime = becourse.totaltime,
                videourl =becourse.videointro,
                pictureurl=becourse.picture,
                id=becourse.id,
                teachers=becourse.teacher_Courses.Select(s=>s.teacher.id).ToList()


            };
            return View(modelCourse);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Models.course course1)
        {
            blcourse blc = new blcourse();
            //تصویر رو کجا پر کردی
            var becourse = blc.searchbyid(course1.id);
            becourse.title = course1.title;
            becourse.id = course1.id;
            becourse.totaltime = course1.totaltime;
            becourse.price = course1.price;
            becourse.descript = course1.descript;
            BloggingContext db   =new BloggingContext ();
            var remove = becourse.teacher_Courses.ToList();
            foreach (var item in remove)
            {
                becourse.teacher_Courses.Remove(item);
            }
            foreach (var item in course1.teachers)
            {
                var teacher = db.teachers.FirstOrDefault(x => x.id == item);
                if (teacher != null)
                {
                   becourse.teacher_Courses.Add(new teacher_course { teacherID = teacher.id, courseID = becourse.id });
                    
                }//alan test konid
            }
            if (course1.picture!=null)
            {

            UploadFile upf1 = new UploadFile(Environment);
            becourse.picture = upf1.upload1(course1.picture);
            }
            if (course1.videointro != null)
            {
                UploadFile upf = new UploadFile(Environment);
                becourse.videointro = upf.uploadVideo(course1.videointro);
            }
            
           blc.update(becourse);
          return RedirectToAction("readall");
        }

        public IActionResult getskip(int c)
        {
            blteacher bl = new blteacher();
            return View("show teachers", bl.getskip(c));
        }
    


    }
}
