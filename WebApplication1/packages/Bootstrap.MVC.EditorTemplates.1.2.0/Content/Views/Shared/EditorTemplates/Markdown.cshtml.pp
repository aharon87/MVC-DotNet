﻿@using $rootnamespace$.Utility
@model object

@{
    string guidID = Guid.NewGuid().ToString();
}

<link rel="stylesheet" type="text/css" href="/Scripts/mdd_styles.css" />
<div class="form-group@(Html.ValidationErrorFor(m => m, " has-error"))">
    @Html.LabelFor(m => m, new { @class = "control-label" })
    <div class="mdd_toolbar"></div>
    @Html.TextAreaFor(
            m => m,
            8, 15,
            ViewBag.ClearTextField == true ? new { @class = "form-control mdd_editor clear-text-field", data_mdd_preview = "#" + guidID } : new { @class = "form-control mdd_editor", data_mdd_preview = "#" + guidID })
    @Html.ValidationMessageFor(m => m, null, new { @class = "help-block" })
    <br />
    <label>Preview</label>
    <hr />
    <div class="mdd_preview" id="@guidID"></div>
    <hr />
</div>