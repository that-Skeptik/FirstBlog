﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstBlog.Infrastructure;

namespace FirstBlog.Areas.Admin.Controllers
{
    [Authorize(Roles = "admin")]
    [SelectedTab("posts")]
   
    public class PostsController : Controller
    {
        //
        // GET: /Admin/Posts/

        public ActionResult Index()
        {
            return View();
        }

    }
}
