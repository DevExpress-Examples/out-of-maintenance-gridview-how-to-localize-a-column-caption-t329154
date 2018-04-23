using System.Web.Mvc;
using System.Globalization;

namespace GridViewLocalizeColumnCaptionMvc.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string language) {
            Session["CurrentCulture"] = CultureInfo.GetCultureInfo(language);
            CustomLocalizationHelper.ApplyCurrentCulture();
            return View();
        }

        public ActionResult GridViewPartial() {
            CustomLocalizationHelper.ApplyCurrentCulture();
            return PartialView(Invoice.GetData());
        }
    }
}