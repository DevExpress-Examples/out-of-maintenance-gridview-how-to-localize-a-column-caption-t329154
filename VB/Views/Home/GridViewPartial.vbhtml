@Html.DevExpress().GridView( _
    Sub(settings)
            settings.Name = "GridView"
            settings.KeyFieldName = "Id"
            settings.CallbackRouteValues = New With {.Controller = "Home", .Action = "GridViewPartial"}
            settings.Columns.Add("Description")
            settings.Columns.Add("Price")
            settings.Columns.Add("RegisterDate")
    End Sub).Bind(Model).GetHtml()