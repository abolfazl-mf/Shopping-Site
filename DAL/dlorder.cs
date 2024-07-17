using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BE;


namespace DAL
{
    public class dlorder
    {
        BloggingContext db1 = new BloggingContext();
        public Order create(Order c)
        {
            db1.Orders.Add(c);
            db1.SaveChanges();
            return c;
        }
        public List<Order> readall()
        {
            return db1.Orders.ToList();
        }
        
        public List<Order> getskip(int c)
        {
            int t = c * 10;
            var q = db1.Orders.Skip(t).Take(10);
            return q.ToList();
        }
        public Order serachById(int id)
        {
            BloggingContext db = new BloggingContext();
            var q = from i in db.Orders where i.Id == id select i;
            return q.SingleOrDefault();
        }

    }
}
