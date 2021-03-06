﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ECommerce.Areas.Admin.Models;

namespace ECommerce.Controllers
{
    public class BrandController : Controller
    {
        // GET: Brand
        public PartialViewResult List()
        {
            ECommerce_2019_DbEntities db = new ECommerce_2019_DbEntities();
            return PartialView(db.Brands.ToList());
        }
    }
}