using Nabakem_SCT.Models.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nabakem_SCT.Controllers
{
    public class BaseController : Controller
    {
        public JsonResult SetMenus()
        {
            MenuHelper menuHelper = new MenuHelper();
            var menus = menuHelper.GetAllMenus();
            return Json(menus, JsonRequestBehavior.AllowGet);
        }
    }

}
