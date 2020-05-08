<script type="text/javascript">
    $(document).ready(function () {
        $("#Language").change(function () { $("form").submit(); });
    });
</script>

@Using (Html.BeginForm())
    @Html.DropDownList("Language", CustomLocalizationHelper.GetLanguages())
    @<br /> @<br />
    @Html.Action("GridViewPartial")
End Using