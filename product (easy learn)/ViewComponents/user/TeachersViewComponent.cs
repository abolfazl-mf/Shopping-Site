using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace product__easy_learn_.view_components.user
{
    public class TeachersViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            BLL.blteacher bl = new BLL.blteacher();
            return View("_teachers", bl.readall());
        }
    }
}
