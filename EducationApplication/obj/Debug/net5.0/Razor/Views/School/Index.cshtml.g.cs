#pragma checksum "D:\PROJECTS\education_app\EducationApplication\Views\School\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b98e079eb001919d56d0e92ff32c83706d8f20f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_School_Index), @"mvc.1.0.view", @"/Views/School/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b98e079eb001919d56d0e92ff32c83706d8f20f", @"/Views/School/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79146968fc73c728ff3fbfba8d6537b30dc4e4b2", @"/Views/_ViewImports.cshtml")]
    public class Views_School_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<EducationApplication.ViewModel.ViewModels.School.SchoolVM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/dataTables.bootstrap4.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/datatable.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\PROJECTS\education_app\EducationApplication\Views\School\Index.cshtml"
  
    ViewBag.Title = "Index";
    Layout = "~/Views/Shared/_EducationLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8b98e079eb001919d56d0e92ff32c83706d8f20f4504", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<div class=""row mrg-top30"">
    <div class=""col-md-12"">
        <div class=""card"">
            <div class=""card-header"">
                <h5>School List</h5>
            </div>
            <div class=""card-body"">
                <!--tables-->
                <div class=""table-responsive"">
                    <table id=""example"" class=""table table-striped dt-responsive nowrap""
                           style=""width: 100%; cellspacing: 0;"">
                        <thead>
                            <tr>
                                <th>");
#nullable restore
#line 21 "D:\PROJECTS\education_app\EducationApplication\Views\School\Index.cshtml"
                               Write(Html.DisplayNameFor(m => m.FirstOrDefault().Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <th>");
#nullable restore
#line 22 "D:\PROJECTS\education_app\EducationApplication\Views\School\Index.cshtml"
                               Write(Html.DisplayNameFor(m => m.FirstOrDefault().Street));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <th>");
#nullable restore
#line 23 "D:\PROJECTS\education_app\EducationApplication\Views\School\Index.cshtml"
                               Write(Html.DisplayNameFor(m => m.FirstOrDefault().Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <th>");
#nullable restore
#line 24 "D:\PROJECTS\education_app\EducationApplication\Views\School\Index.cshtml"
                               Write(Html.DisplayNameFor(m => m.FirstOrDefault().BuildingType));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <th>");
#nullable restore
#line 25 "D:\PROJECTS\education_app\EducationApplication\Views\School\Index.cshtml"
                               Write(Html.DisplayNameFor(m => m.FirstOrDefault().BuildingStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <th>Settings</th>\r\n                            </tr>\r\n                        </thead>\r\n                        <tfoot>\r\n                            <tr>\r\n                                <th>");
#nullable restore
#line 31 "D:\PROJECTS\education_app\EducationApplication\Views\School\Index.cshtml"
                               Write(Html.DisplayNameFor(m => m.FirstOrDefault().Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <th>");
#nullable restore
#line 32 "D:\PROJECTS\education_app\EducationApplication\Views\School\Index.cshtml"
                               Write(Html.DisplayNameFor(m => m.FirstOrDefault().Street));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <th>");
#nullable restore
#line 33 "D:\PROJECTS\education_app\EducationApplication\Views\School\Index.cshtml"
                               Write(Html.DisplayNameFor(m => m.FirstOrDefault().Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <th>");
#nullable restore
#line 34 "D:\PROJECTS\education_app\EducationApplication\Views\School\Index.cshtml"
                               Write(Html.DisplayNameFor(m => m.FirstOrDefault().BuildingType));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <th>");
#nullable restore
#line 35 "D:\PROJECTS\education_app\EducationApplication\Views\School\Index.cshtml"
                               Write(Html.DisplayNameFor(m => m.FirstOrDefault().BuildingStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <th>Settings</th>\r\n                            </tr>\r\n                        </tfoot>\r\n                        <tbody>\r\n");
#nullable restore
#line 40 "D:\PROJECTS\education_app\EducationApplication\Views\School\Index.cshtml"
                              
                                foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>");
#nullable restore
#line 44 "D:\PROJECTS\education_app\EducationApplication\Views\School\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 45 "D:\PROJECTS\education_app\EducationApplication\Views\School\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Street));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 46 "D:\PROJECTS\education_app\EducationApplication\Views\School\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>\r\n");
#nullable restore
#line 48 "D:\PROJECTS\education_app\EducationApplication\Views\School\Index.cshtml"
                                             if (item.BuildingType == "3")
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <p>Education</p>");
#nullable restore
#line 49 "D:\PROJECTS\education_app\EducationApplication\Views\School\Index.cshtml"
                                                              }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </td>\r\n                                        <td>\r\n");
#nullable restore
#line 52 "D:\PROJECTS\education_app\EducationApplication\Views\School\Index.cshtml"
                                             if (item.BuildingStatus == "2")
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<p style=\"color:green\">Active</p>");
#nullable restore
#line 53 "D:\PROJECTS\education_app\EducationApplication\Views\School\Index.cshtml"
                                                                              }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<p style=\"color:red\">Inactive</p> ");
#nullable restore
#line 55 "D:\PROJECTS\education_app\EducationApplication\Views\School\Index.cshtml"
                                                                               }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </td>\r\n                                        <td>\r\n                                            <button class=\"btn btn-info\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3263, "\"", 3342, 3);
            WriteAttributeValue("", 3273, "location.href=\'", 3273, 15, true);
#nullable restore
#line 58 "D:\PROJECTS\education_app\EducationApplication\Views\School\Index.cshtml"
WriteAttributeValue("", 3288, Url.Action("Details", "School", new  {id =item.Id }), 3288, 53, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3341, "\'", 3341, 1, true);
            EndWriteAttribute();
            WriteLiteral(">View</button>\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 61 "D:\PROJECTS\education_app\EducationApplication\Views\School\Index.cshtml"
                                    }
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                         </tbody>\r\n                    </table>\r\n                </div>\r\n                <!----->\r\n            </div>\r\n            <!---->\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b98e079eb001919d56d0e92ff32c83706d8f20f14116", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<script>\r\n    $(document).ready(function () {\r\n        $(\'#example\').DataTable();\r\n    });\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<EducationApplication.ViewModel.ViewModels.School.SchoolVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
