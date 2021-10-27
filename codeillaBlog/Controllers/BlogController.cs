using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace codeillaBlog.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Kategori()
        {
            return View();
        }
        public ActionResult Populer()
        {
            return View();
        }
        public ActionResult Etiket()
        {
            return View();
        }
    }
}