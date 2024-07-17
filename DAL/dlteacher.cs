using System;
using System.Collections.Generic;
using System.Linq;
using BE;

namespace DAL
{
    public class dlteacher
    {
        BloggingContext db1 = new BloggingContext();
        public void create(teacher t)
        {
            db1.teachers.Add(t);
            db1.SaveChanges();
           


        }
        public List<teacher> readall()
        {
            return db1.teachers.ToList();
        }
        public List<teacher> search(List<string> tags)
        {
            List<teacher> te = new List<teacher>();
            foreach(var item in tags)
            {
                var q = from i in db1.teachers where i.name.Contains(item.ToString()) || i.family.Contains(item.ToString()) || i.email.Contains(item.ToString()) select i;
                te=te.Concat(q.ToList()).ToList();
            }
            return te;
        }
        public void update(teacher t)
        {
            var q = from i in db1.teachers where i.id == t.id select i;
            teacher tt = new teacher();
            tt=q.Single();
            tt.name = t.name;
            tt.family = t.family;
            tt.email = t.email;
            tt.picture = t.picture;
            db1.SaveChanges();
            
        }
        public int gettotal()
        {
            return db1.teachers.Count();
        }
        public List<teacher> getskip(int c)
        {
            int t = c * 10;
            var q = db1.teachers.Skip(t).Take(10);
            return q.ToList();
        }

    }
}
