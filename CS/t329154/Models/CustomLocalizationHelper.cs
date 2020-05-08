using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace t329154.Models
{
    public class CustomLocalizationHelper
    {
        public static List<SelectListItem> GetLanguages()
        {
            return new List<SelectListItem>() {
                new SelectListItem() { Text = "English", Value = "en", Selected = true },
                new SelectListItem() { Text = "Русский", Value = "ru" },
                new SelectListItem() { Text = "Deutsch", Value = "de" }
            };
        }
        public static void ApplyCurrentCulture()
        {
            if (HttpContext.Current.Session["CurrentCulture"] != null)
            {
                CultureInfo ci = (CultureInfo)HttpContext.Current.Session["CurrentCulture"];
                Thread.CurrentThread.CurrentUICulture = ci;
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(ci.Name);
            }
        }
    }
}