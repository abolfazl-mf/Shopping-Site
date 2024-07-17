using System;
using System.Collections.Generic;
using System.Text;
using BE;
using DAL;

namespace BLL
{
    public class blorder
    {
        dlorder dl = new dlorder();
        public Order create(Order c)
        {


            return dl.create(c);
        }
        public List<Order> readall()
        {
            return dl.readall();
        }
        
        public List<Order> getskip(int c)
        {

            return dl.getskip(c);
        }
        public Order serachById(int id)
        {

            return dl.serachById(id);
        }
    }
}
