#pragma checksum "D:\PROJECTS\education_app\EducationApplication\Views\Account\RolesEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc2997c520a08c107ba6eb852fdfc4607f1d8bea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_RolesEdit), @"mvc.1.0.view", @"/Views/Account/RolesEdit.cshtml")]
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
#nullable restore
#line 1 "D:\PROJECTS\education_app\EducationApplication\Views\_ViewImports.cshtml"
using EducationApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\PROJECTS\education_app\EducationApplication\Views\_ViewImports.cshtml"
using EducationApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc2997c520a08c107ba6eb852fdfc4607f1d8bea", @"/Views/Account/RolesEdit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79146968fc73c728ff3fbfba8d6537b30dc4e4b2", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_RolesEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\PROJECTS\education_app\EducationApplication\Views\Account\RolesEdit.cshtml"
  
    ViewData["Title"] = "RelesEdit";
    Layout = "~/Views/Shared/_EducationLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row mrg-top30"">
    <div class=""col-md-12"">
        <div class=""card"">
            <div class=""card-header"">
                <h5>Edit role</h5>
            </div>
            <div class=""card-body"">
                <!--tables-->
                <div class=""form-inline"">
                    <div class=""col-md-12 form-group mrg-top10"">
                        <label class=""col-md-3 control-label lbl-design"" for=""Title""><b>Name:</b></label>
                        <div class=""col-md-7"">
                            <input class=""form-control wdth100""/>
                        </div>
                    </div>
                </div>
            </div>
            <hr />
            <div class=""form-group"">
                <div class=""col-md-12"">
                    <input type=""reset"" name=""create"" class=""btn btn-success btn-md"" ");
            WriteLiteral(" value=\"Update\">\r\n                    <!--<input type=\"reset\" name=\"cancel\" class=\"btn btn-danger btn-md\"--> ");
            WriteLiteral(" <!--value=\"Close\">-->\r\n                    <input type=\"reset\" name=\"cancel\" class=\"btn btn-danger btn-md\" value=\"Close\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1249, "\"", 1306, 3);
            WriteAttributeValue("", 1259, "location.href=\'", 1259, 15, true);
#nullable restore
#line 29 "D:\PROJECTS\education_app\EducationApplication\Views\Account\RolesEdit.cshtml"
WriteAttributeValue("", 1274, Url.Action("Roles","Account"), 1274, 30, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1304, "\';", 1304, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                </div>\r\n            </div>\r\n            <!----->\r\n        </div>\r\n        <!---->\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
