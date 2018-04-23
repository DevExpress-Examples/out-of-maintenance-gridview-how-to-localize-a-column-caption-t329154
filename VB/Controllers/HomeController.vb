Imports System.Web.Mvc
Imports System.Globalization

Namespace GridViewLocalizeColumnCaptionMvc.Controllers
	Public Class HomeController
		Inherits Controller

		Public Function Index() As ActionResult
			Return View()
		End Function

		<HttpPost>
		Public Function Index(ByVal language As String) As ActionResult
			Session("CurrentCulture") = CultureInfo.GetCultureInfo(language)
			CustomLocalizationHelper.ApplyCurrentCulture()
			Return View()
		End Function

		Public Function GridViewPartial() As ActionResult
			CustomLocalizationHelper.ApplyCurrentCulture()
			Return PartialView(Invoice.GetData())
		End Function
	End Class
End Namespace