using Nabakem_SCT.Models.Domains;
using Nabakem_SCT.Models.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nabakem_SCT.Controllers
{
    public class AdminController : Controller
    {
        //
        // GET: /Admin/

        public ActionResult Summary()
        {
            return View();
        }

        public ActionResult Notice(string type)
        {
            if ("Write" == type)
            {
                return RedirectToAction("Notice/Write","BBS");
            }
            else
            {
                return RedirectToAction("Notice/List","BBS");
            }
        }

        public ActionResult Menus()
        {
            MenuHelper helper = new MenuHelper();
            var result = helper.GetAllMenus();

            return View(result);
        }

        public JsonResult GetMenu(string code)
        {
            MenuHelper helper = new MenuHelper();
            var result = helper.GetMenu(code);
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}
