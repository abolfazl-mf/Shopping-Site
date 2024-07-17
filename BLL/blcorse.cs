using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class blcourse
    {
        public course create(course t)
        {
            dlcourse dl = new dlcourse();
            return dl.create(t);
        }
        public List<course> readall()
        {
            dlcourse dl = new dlcourse();
            return dl.readall();

        }
        public List<course> readallByTeachers()
        {
            dlcourse dl = new dlcourse();
            return dl.readallByTeachers();

        }
        public List<course> search(string s)
        {
            dlcourse dl = new dlcourse();
            return dl.search(s);
        }
        public void update(course t)
        {
            dlcourse d = new dlcourse();
            d.update(t);
        }
        public int gettotal()
        {
            dlcourse d = new dlcourse();
            return d.gettotal();
        }
        public List<course> getskip(int c)
        {
            dlcourse d = new dlcourse();
            return d.getskip(c);
        }
        public course searchbyid(int id)
        {
            dlcourse dl = new dlcourse();
           return dl.searchbyid(id);
        }
        public List<course> serachById(List<int> ids)
        {
            dlcourse dl = new dlcourse();

            return dl.serachById(ids);
        }
    }
}
