using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace product__easy_learn_.ViewComponents.user
{
    public class CoursesViewComponent: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            BLL.blcourse bl = new BLL.blcourse();
            return View("_courses", bl.readallByTeachers());
        }
    }
}
