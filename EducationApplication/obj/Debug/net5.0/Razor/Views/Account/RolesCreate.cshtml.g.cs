#pragma checksum "D:\Projects\education_app\EducationApplication\Views\Account\RolesCreate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a8fcc8e43f7023a31bc63eb9b5055e8ffe5a8d07"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_RolesCreate), @"mvc.1.0.view", @"/Views/Account/RolesCreate.cshtml")]
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
#line 1 "D:\Projects\education_app\EducationApplication\Views\_ViewImports.cshtml"
using EducationApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\education_app\EducationApplication\Views\_ViewImports.cshtml"
using EducationApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8fcc8e43f7023a31bc63eb9b5055e8ffe5a8d07", @"/Views/Account/RolesCreate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79146968fc73c728ff3fbfba8d6537b30dc4e4b2", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_RolesCreate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EducationApplication.ViewModel.ViewModels.Account.RolesCreateVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Projects\education_app\EducationApplication\Views\Account\RolesCreate.cshtml"
  
    ViewData["Title"] = "RolesCreate";
    Layout = "~/Views/Shared/_EducationLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"row mrg-top30\">\r\n    <div class=\"col-md-12\">\r\n");
#nullable restore
#line 10 "D:\Projects\education_app\EducationApplication\Views\Account\RolesCreate.cshtml"
         using (Html.BeginForm("RolesCreate", "Account", FormMethod.Post, new { @enctype = "multipart/form-data" }))
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Projects\education_app\EducationApplication\Views\Account\RolesCreate.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""card"">
                <div class=""card-header"">
                    <h5>Create new role</h5>
                </div>
                <div class=""card-body"">
                    <!--tables-->
                    <div class=""form-inline"">
                        <div class=""col-md-12 form-group mrg-top10"">
                            ");
#nullable restore
#line 21 "D:\Projects\education_app\EducationApplication\Views\Account\RolesCreate.cshtml"
                       Write(Html.LabelFor(m => m.Name, new { @class = "col-md-3 control-label lbl-design" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <div class=\"col-md-7\">\r\n                                ");
#nullable restore
#line 23 "D:\Projects\education_app\EducationApplication\Views\Account\RolesCreate.cshtml"
                           Write(Html.TextBoxFor(m => m.Name, new { @class = "form-control wdth100" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                ");
#nullable restore
#line 24 "D:\Projects\education_app\EducationApplication\Views\Account\RolesCreate.cshtml"
                           Write(Html.ValidationMessageFor(model => model.Name, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>
                        </div>
                    </div>
                </div>
                <hr />
                <div class=""form-group"">
                    <div class=""col-md-12"">
                        <input type=""submit"" name=""create"" class=""btn btn-success btn-md"" value=""Create"">
                    </div>
                </div>
                <!----->
            </div>
            <!---->
");
#nullable restore
#line 38 "D:\Projects\education_app\EducationApplication\Views\Account\RolesCreate.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EducationApplication.ViewModel.ViewModels.Account.RolesCreateVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
