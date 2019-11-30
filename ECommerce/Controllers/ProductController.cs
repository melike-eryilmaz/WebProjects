using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ECommerce.Areas.Admin.Models;

namespace ECommerce.Controllers
{
    public class ProductController : Controller
    {
        ECommerce_2019_DbEntities db = new ECommerce_2019_DbEntities();

        // GET: Product
        public ActionResult Index()
        {

            return View(db.Products.ToList());
        }
        public ActionResult ProductDetails(int id)
        {
            Products product = db.Products.Find(id);

            if (product!=null)
            {

                return View(product);
            }
            return View();
            
        }
    }
}