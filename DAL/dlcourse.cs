using System;
using System.Collections.Generic;
using System.Text;
using BE;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DAL
{
   public class dlcourse
    {

        BloggingContext db1 = new BloggingContext();
        public course create(course c)
        {
            db1.courses.Add(c);
            db1.SaveChanges();
            return c;
        }
        public List<course> readall()
        {
            return db1.courses.ToList();
        }
        public List<course> readallByTeachers()
        {
            return db1.courses.Include(s => s.teacher_Courses).ThenInclude(s => s.teacher).ToList();
        }
        public List<course> search(string s)
        {
            //int n;
            var q = from i in db1.courses where i.title.Contains(s.ToString()) || /*(int.TryParse(s, out n) ? i.price == n : false)*/ i.price.Contains(s.ToString()) select i;//قبل علامت سوال شرط و اون دو نقطه هم یا هستش  // بعد اینکه من اون و کامنت کردم چون اون موقعی استافاده میشه که تایپ فیلد از نوع فلوت(float)باشه
                  
            return q.ToList();
        }
        public course searchbyid(int id)
        {
            var q = from i in db1.courses.Include(s=> s.teacher_Courses).ThenInclude(s=> s.teacher)
                    where i.id == id select i;  

            return q.SingleOrDefault();
        }
        public void update(course c)
        {
            var q = db1.courses.FirstOrDefault(x => x.id == c.id);
          var d= db1.teacher_Courses.Where(x => x.courseID == q.id).ToList();
            db1.teacher_Courses.RemoveRange(d);

            //db1.SaveChanges();
            //course co = new course();
            q.title = c.title;
            q.totaltime = c.totaltime;
            q.videointro = c.videointro;
            q.picture = c.picture;
            q.teacher_Courses = c.teacher_Courses;
            q.descript = c.descript;
            q.price = c.price;
            db1.SaveChanges();

        }
        public int gettotal()
        {
            return db1.courses.Count();
        }
        public List<course> getskip(int c)
        {
            int t = c * 10;
            var q = db1.courses.Skip(t).Take(10);
            return q.ToList();
        }
        public List<course> serachById(List<int> ids)
        {
            BloggingContext db = new BloggingContext();
            var q = from i in db.courses where ids.Contains(i.id) select i;
            return q.ToList();
        }

    }
}
