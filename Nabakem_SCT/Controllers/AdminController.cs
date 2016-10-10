using Nabakem_SCT.Models.Domains;
using Nabakem_SCT.Models.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nabakem_SCT.Controllers
{
    public class AdminController : BaseController
    {
        //
        // GET: /Admin/

        public ActionResult Summary()
        {
            return View();
        }

        public ActionResult Notice(string mode)
        {
            if ("Write" == mode)
            {
                return RedirectToAction("Notice/Write","BBS");
            }
            else
            {
                return RedirectToAction("Notice/List","BBS");
            }
        }

        /*
         * 메뉴관리
         * 메뉴전체보기
         */
        public ActionResult Menus()
        {
            MenuHelper helper = new MenuHelper();
            var result = helper.GetAllMenus();

            return View(result);
        }

        /*
         * 메뉴관리
         * 클릭한 메뉴정보 가져오기
         * 코드
         */
        public JsonResult GetMenu(string code)
        {
            MenuHelper helper = new MenuHelper();
            var result = helper.GetMenu(code);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        /*
         * 메뉴관리
         * 메뉴정보 수정
         * 코드, 이름, 부모코드, 주소, 권한, 사용여부
         */
        public void UpdateMenu(string code, string name, string parentCode, string url, string role, string enabled)
        {
            MenuHelper helper = new MenuHelper();
            helper.UpdateMenu(code, name, parentCode, url, role, enabled);
            return;
        }

        /*
         * 메뉴관리
         * 메뉴추가
         * 코드, 이름, 부모코드, 주소, 권한, 사용여부
         */
        public void AddMenu(string code, string name, string parentCode, string url, string role, string enabled)
        {
            MenuHelper helper = new MenuHelper();
            helper.AddMenu(code, name, parentCode, url, role, enabled);
            return;
        }

        /*
         * 게시판관리
         * 글 전체목록
         */
        public ActionResult GetAllArticle()
        {
            BoardHelper helper = new BoardHelper();
            var result = helper.GetAllArticle();
            return View("ArticleAll", result);
        }
    }
}
