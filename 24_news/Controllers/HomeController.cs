using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _24_news.Models;

namespace _24_news.Controllers
{
    public class HomeController : Controller
    {
        dbQLTinTucDataContext data = new dbQLTinTucDataContext();
        private List<TINTUC> LayTinTuc(int count)
        {
            return data.TINTUCs.OrderByDescending(a => a.NgayCapNhat).Take(count).ToList();
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Single()
        {
            return View();
        }
    }

}