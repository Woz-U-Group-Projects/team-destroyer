#pragma checksum "C:\Users\morga\Desktop\FinalProjectPhase\NerdCraft\Views\Returnment\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8fad37b112c2df14214d2797026dcf3578446185"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Returnment_Edit), @"mvc.1.0.view", @"/Views/Returnment/Edit.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8fad37b112c2df14214d2797026dcf3578446185", @"/Views/Returnment/Edit.cshtml")]
    public class Views_Returnment_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NerdCraft.Models.returnment>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\morga\Desktop\FinalProjectPhase\NerdCraft\Views\Returnment\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Edit</h1>

<h4>returnment</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Edit"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <input type=""hidden"" asp-for=""OrderID"" />
            <input type=""hidden"" asp-for=""ItemID"" />
            <div class=""form-group"">
                <label asp-for=""Quantity"" class=""control-label""></label>
                <input asp-for=""Quantity"" class=""form-control"" />
                <span asp-validation-for=""Quantity"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Comments"" class=""control-label""></label>
                <input asp-for=""Comments"" class=""form-control"" />
                <span asp-validation-for=""Comments"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Approval"" class=""control-label""></label>
                <input asp-for=""Ap");
            WriteLiteral(@"proval"" class=""form-control"" />
                <span asp-validation-for=""Approval"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Save"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 44 "C:\Users\morga\Desktop\FinalProjectPhase\NerdCraft\Views\Returnment\Edit.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NerdCraft.Models.returnment> Html { get; private set; }
    }
}
#pragma warning restore 1591