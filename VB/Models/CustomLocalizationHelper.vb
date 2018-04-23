Imports System.Collections.Generic
Imports System.Globalization
Imports System.Threading
Imports System.Web
Imports System.Web.Mvc

Public Class CustomLocalizationHelper
	Public Shared Function GetLanguages() As List(Of SelectListItem)
		Return New List(Of SelectListItem)() From {
			New SelectListItem() With {.Text = "English", .Value = "en", .Selected = True},
			New SelectListItem() With {.Text = "Русский", .Value = "ru"},
			New SelectListItem() With {.Text = "Deutsch", .Value = "de"}
		}
	End Function
	Public Shared Sub ApplyCurrentCulture()
		If HttpContext.Current.Session("CurrentCulture") IsNot Nothing Then
			Dim ci As CultureInfo = DirectCast(HttpContext.Current.Session("CurrentCulture"), CultureInfo)
			Thread.CurrentThread.CurrentUICulture = ci
			Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(ci.Name)
		End If
	End Sub
End Class