<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128550447/19.2.7%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T329154)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [HomeController.cs](./CS/t329154/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/t329154VB/Controllers/HomeController.vb))
* [CustomLocalizationHelper.cs](./CS/t329154/Models/CustomLocalizationHelper.cs) (VB: [CustomLocalizationHelper.vb](./VB/t329154VB/Models/CustomLocalizationHelper.vb))
* [Invoice.cs](./CS/t329154/Models/Invoice.cs) (VB: [Invoice.vb](./VB/t329154VB/Models/Invoice.vb))
* [GridViewPartial.cshtml](./CS/t329154/Views/Home/GridViewPartial.cshtml)
* [Index.cshtml](./CS/t329154/Views/Home/Index.cshtml)
<!-- default file list end -->
# GridView - How to localize a column caption
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/t329154/)**
<!-- run online end -->


<p>This example illustrates how to localize a column caption by using the <a href="https://msdn.microsoft.com/en-us/library/system.componentmodel.dataannotations.displayattribute.aspx">DisplayAttribute</a> class from the System.ComponentModel.DataAnnotations namespace. Here is a code snippet that illustrates this:</p>


```cs
    [Display(Name = "Date", ResourceType = typeof(Localization))]
    public DateTime RegisterDate { get; set; }
```


<p>Note that localized strings are retrieved from resx files located in the Views\Home\App_LocalResources directory. In addition, we use the DropDownList element to switch between the cultures dynamically.<br><br>A preferable approach to localize the predefined elements of our extensions (such as context menus, command buttons, etc.) is to use satellite assemblies: <a href="https://documentation.devexpress.com/#AspNet/CustomDocument12050">Localizing ASP.NET Controls via Satellite Resource Assemblies</a>.</p>
<br><strong>See Also:</strong><br><a href="https://www.devexpress.com/Support/Center/p/T108044">T108044 - Best practices to change the current Culture in ASP.NET MVC Application using ComboBox Extension</a>

<br/>


