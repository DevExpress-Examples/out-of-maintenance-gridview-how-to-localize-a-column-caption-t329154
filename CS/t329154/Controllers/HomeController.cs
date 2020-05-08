using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using t329154.Models;

namespace t329154.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string language)
        {
            Session["CurrentCulture"] = CultureInfo.GetCultureInfo(language);
            CustomLocalizationHelper.ApplyCurrentCulture();
            return View();
        }

        public ActionResult GridViewPartial()
        {
            CustomLocalizationHelper.ApplyCurrentCulture();
            return PartialView(Invoice.GetData());
        }
    }
}