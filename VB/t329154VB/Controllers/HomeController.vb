Imports System.Globalization

Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
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