﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nabakem_SCT.Controllers
{
    public class AuthorizeController : Controller
    {
        //
        // GET: /Authorize/

        public ActionResult Login()
        {
            return View();
        }

    }
}
