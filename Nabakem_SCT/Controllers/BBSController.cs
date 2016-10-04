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

            switch (type)
            {
                case "Write":
                    addr = "Notice/Write";
                    break;
                case "List":
                    addr = "Notice/List";
                    break;
                default:
                    addr = "Notice/" + id;
                    break;
            }

            return View(addr);
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
