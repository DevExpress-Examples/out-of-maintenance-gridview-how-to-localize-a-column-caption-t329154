# GridView - How to localize a column caption


<p>This example illustrates how to localize a column caption by using the <a href="https://msdn.microsoft.com/en-us/library/system.componentmodel.dataannotations.displayattribute.aspx">DisplayAttribute</a> class from the System.ComponentModel.DataAnnotations namespace. Here is a code snippet that illustrates this:</p>


```cs
    [Display(Name = "Date", ResourceType = typeof(Localization))]
    public DateTime RegisterDate { get; set; }
```


<p>Note that localized strings are retrieved from resx files located in the Views\Home\App_LocalResources directory. In addition, we use the DropDownList element to switch between the cultures dynamically.<br><br>A preferable approach to localize the predefined elements of our extensions (such as context menus, command buttons, etc.) is to use satellite assemblies: <a href="https://documentation.devexpress.com/#AspNet/CustomDocument12050">Localizing ASP.NET Controls via Satellite Resource Assemblies</a>.</p>
<br><strong>See Also:</strong><br><a href="https://www.devexpress.com/Support/Center/p/T108044">T108044 - Best practices to change the current Culture in ASP.NET MVC Application using ComboBox Extension</a>

<br/>


