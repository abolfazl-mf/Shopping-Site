using System;
using BE;
using DAL;
using System.Collections.Generic;

namespace BLL
{
    public class blteacher
    {
        public void create(teacher t)
        {
            dlteacher dl = new dlteacher();
            dl.create(t);
        }
        public List<teacher> readall()
        {
            dlteacher dl = new dlteacher();
            return dl.readall();
            
        }
        public List<teacher> search(List<string> tags)
        {
            dlteacher dl = new dlteacher();
            return dl.search(tags);
        }
        public void update(teacher t)
        {
            dlteacher d = new dlteacher();
            d.update(t);
        }
        public int gettotal()
        {
            dlteacher d = new dlteacher();
            return d.gettotal();
        }
        public List<teacher> getskip(int c)
        {
            dlteacher d = new dlteacher();
            return d.getskip(c);
        }
    }
}
