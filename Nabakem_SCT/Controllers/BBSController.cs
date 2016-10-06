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
        private BoardHelper helper;
        private string url;

        /*
         * 공지사항
         */
        public ActionResult Notice(string mode, string id)
        {
            string addr = null;

            if ("List" == mode)
            {
                addr = "Notice/List";
                helper = new BoardHelper();
                var result = helper.GetAllContents();
                
                return View(addr, result);
            }
            else if ("Write" == mode)
            {
                addr = "Notice/Write";
                return View(addr);
            }
            else if("View" == mode && id != null)
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

        [ValidateInput(false)]
        public ActionResult NoticeCRUD(string mode, string id, string subject, string contents, string author)
        {
            if ("Write" == mode)
            {
                helper = new BoardHelper();
                int result = helper.NoticeAdd(subject, contents, author);

                if (0 != result)
                {
                    return RedirectToAction("Notice/View/" + id, "BBS");
                }
                else
                {
                    return RedirectToAction("Notice/Write", "BBS");
                }
            }
            //else if ("Edit" == mode)      // 수정모드 업데이트 해야됨.
            //{
            //    helper = new BoardHelper();

            //    int result = helper.EditContents(type, id, subject, contents);

            //    if (0 != result)
            //    {
            //        url = string.Format("{0}/View/{1}", type, id);
            //        return RedirectToAction(url, "Customer");
            //    }
            //    else
            //    {
            //        url = string.Format("{0}/View/{1}", type, id);
            //        return RedirectToAction(url, "Customer");
            //    }
            //}
            //else if ("Delete" == mode)
            //{
            //    helper = new BoardHelper();
            //    int result = helper.DeleteContents(type, id);

            //    if (0 != result)
            //    {
            //        return RedirectToAction(type, "Customer");
            //    }
            //    else
            //    {
            //        url = string.Format("{0}/View/{1}", type, id);
            //        return RedirectToAction(url, "Customer");
            //    }
            //}
            else
            {
                return RedirectToAction(mode, "BBS");
            }
        }
    }
}
