using Nabakem_SCT.Models.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nabakem_SCT.Controllers
{
    public class BBSController : Controller
    {
        /*
         * 공지사항
         */
        public ActionResult Notice(string type, string id)
        {
            string addr = null;
            BoardHelper helper;

            if ("List" == type)
            {
                addr = "Notice/List";
                helper = new BoardHelper();
                var result = helper.GetAllContents();
                
                return View(addr, result);
            }
            else if ("Write" == type)
            {
                addr = "Notice/Write";
                return View(addr);
            }
            else if("View" == type && id != null)
            {
                addr = "Notice/View/" + id;
                return View(addr);
            }
            else
            {
                return View("Error");
            }
        }
        /*
         * 제품문의
         */
        public ActionResult QnA(string id)
        {
            if (id != null && id != "")
            {
                return View("QnA/Detail/" + id);
            }
            else
            {
                return View("QnA/List");
            }
        }

        /*
         * 견적요청
         */
        public ActionResult Estimate(string id)
        {
            if (id != null && id != "")
            {
                return View("Estimate/Detail/" + id);
            }
            else
            {
                return View("Estimate/List");
            }
        }
    }
}
