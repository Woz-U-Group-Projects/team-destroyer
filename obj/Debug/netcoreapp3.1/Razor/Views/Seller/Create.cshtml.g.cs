#pragma checksum "C:\Users\morga\Desktop\FinalProjectPhase\NerdCraft\Views\Seller\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c0adea62f28e4652f9383b3f70aefaa2d172cdb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Seller_Create), @"mvc.1.0.view", @"/Views/Seller/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c0adea62f28e4652f9383b3f70aefaa2d172cdb", @"/Views/Seller/Create.cshtml")]
    public class Views_Seller_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NerdCraft.Models.seller>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\morga\Desktop\FinalProjectPhase\NerdCraft\Views\Seller\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>seller</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""SellerID"" class=""control-label""></label>
                <input asp-for=""SellerID"" class=""form-control"" />
                <span asp-validation-for=""SellerID"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""ItemID"" class=""control-label""></label>
                <input asp-for=""ItemID"" class=""form-control"" />
                <span asp-validation-for=""ItemID"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""SellerName"" class=""control-label""></label>
                <input asp-for=""SellerName"" class=""form-control"" />
                <span asp-validation-for=""SellerName"" class=""text-danger""></sp");
            WriteLiteral(@"an>
            </div>
            <div class=""form-group"">
                <label asp-for=""SellerDesc"" class=""control-label""></label>
                <input asp-for=""SellerDesc"" class=""form-control"" />
                <span asp-validation-for=""SellerDesc"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""SellerEmail"" class=""control-label""></label>
                <input asp-for=""SellerEmail"" class=""form-control"" />
                <span asp-validation-for=""SellerEmail"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""SellerPhone"" class=""control-label""></label>
                <input asp-for=""SellerPhone"" class=""form-control"" />
                <span asp-validation-for=""SellerPhone"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
            </div");
            WriteLiteral(">\r\n        </form>\r\n    </div>\r\n</div>\r\n\r\n<div>\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 57 "C:\Users\morga\Desktop\FinalProjectPhase\NerdCraft\Views\Seller\Create.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NerdCraft.Models.seller> Html { get; private set; }
    }
}
#pragma warning restore 1591