﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CommerceApp.Controllers
{
    public class ScheduleController : Controller
    {
        // GET: Schedule
        public ActionResult Calendar()
        {
            return View();
        }
    }
}