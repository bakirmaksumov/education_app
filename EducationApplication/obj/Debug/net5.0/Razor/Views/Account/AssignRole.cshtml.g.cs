#pragma checksum "D:\PROJECTS\education_app\EducationApplication\Views\Account\AssignRole.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd01f564e01e19f86c03a90d2347ee0adc5e39b9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_AssignRole), @"mvc.1.0.view", @"/Views/Account/AssignRole.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd01f564e01e19f86c03a90d2347ee0adc5e39b9", @"/Views/Account/AssignRole.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79146968fc73c728ff3fbfba8d6537b30dc4e4b2", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_AssignRole : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EducationApplication.ViewModel.ViewModels.Users.UserRoleViewVM>
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
#line 2 "D:\PROJECTS\education_app\EducationApplication\Views\Account\AssignRole.cshtml"
  
    ViewData["Title"] = "AssignRole";
    Layout = "~/Views/Shared/_EducationLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cd01f564e01e19f86c03a90d2347ee0adc5e39b94548", async() => {
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
                <h5>Student View</h5>
            </div>
            <div class=""card-body"">
                <!--tables-->
                <div class=""form-inline"">
                    <div class=""col-md-12 form-group"">
                        ");
#nullable restore
#line 18 "D:\PROJECTS\education_app\EducationApplication\Views\Account\AssignRole.cshtml"
                   Write(Html.LabelFor(m => m.Id, htmlAttributes: new { @class = "col-md-3 control-label font-bold" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-md-3\">\r\n                            <p class=\"padding-top20\">");
#nullable restore
#line 20 "D:\PROJECTS\education_app\EducationApplication\Views\Account\AssignRole.cshtml"
                                                Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-inline\">\r\n                    <div class=\"col-md-12 form-group\">\r\n                        ");
#nullable restore
#line 26 "D:\PROJECTS\education_app\EducationApplication\Views\Account\AssignRole.cshtml"
                   Write(Html.LabelFor(m => m.UserName, htmlAttributes: new { @class = "col-md-3 control-label font-bold" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-md-3\">\r\n                            <p class=\"padding-top20\">");
#nullable restore
#line 28 "D:\PROJECTS\education_app\EducationApplication\Views\Account\AssignRole.cshtml"
                                                Write(Model.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-inline\">\r\n                    <div class=\"col-md-12 form-group\">\r\n                        ");
#nullable restore
#line 34 "D:\PROJECTS\education_app\EducationApplication\Views\Account\AssignRole.cshtml"
                   Write(Html.LabelFor(m => m.FirstName, htmlAttributes: new { @class = "col-md-3 control-label font-bold" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-md-3\">\r\n                            <p class=\"padding-top20\">");
#nullable restore
#line 36 "D:\PROJECTS\education_app\EducationApplication\Views\Account\AssignRole.cshtml"
                                                Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-inline\">\r\n                    <div class=\"col-md-12 form-group\">\r\n                        ");
#nullable restore
#line 42 "D:\PROJECTS\education_app\EducationApplication\Views\Account\AssignRole.cshtml"
                   Write(Html.LabelFor(m => m.LastName, htmlAttributes: new { @class = "col-md-3 control-label font-bold" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <div class=\"col-md-3\">\r\n                            <p class=\"padding-top20\">");
#nullable restore
#line 44 "D:\PROJECTS\education_app\EducationApplication\Views\Account\AssignRole.cshtml"
                                                Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                ");
#nullable restore
#line 48 "D:\PROJECTS\education_app\EducationApplication\Views\Account\AssignRole.cshtml"
           Write(Html.HiddenFor(m => m.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n");
#nullable restore
#line 49 "D:\PROJECTS\education_app\EducationApplication\Views\Account\AssignRole.cshtml"
                 using (Html.BeginForm())
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"form-inline\">\r\n                        <div class=\"col-md-12 form-group mrg-top30\">\r\n                            ");
#nullable restore
#line 53 "D:\PROJECTS\education_app\EducationApplication\Views\Account\AssignRole.cshtml"
                       Write(Html.DropDownList("rolesList", ViewBag.RolesList as List<SelectListItem>, new { @class = "col-md-6 form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <button class=\"margin-left5 btn btn-success\">Add Role</button>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 57 "D:\PROJECTS\education_app\EducationApplication\Views\Account\AssignRole.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <hr />\r\n                <div class=\"col-md-12\">\r\n");
            WriteLiteral(@"                    <div class=""table-responsive"">
                        <table id=""myAllRoles"" class=""table table-striped"">
                            <thead>
                                <tr>
                                    <th>Role ID</th>
                                    <th>Role Name</th>
                                    <th>Action</th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 72 "D:\PROJECTS\education_app\EducationApplication\Views\Account\AssignRole.cshtml"
                                 foreach (var item in Model.getRoleList.OrderBy(m => m.Name))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 76 "D:\PROJECTS\education_app\EducationApplication\Views\Account\AssignRole.cshtml"
                                       Write(Html.DisplayFor(model => item.RoleId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 79 "D:\PROJECTS\education_app\EducationApplication\Views\Account\AssignRole.cshtml"
                                       Write(Html.DisplayFor(model => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n");
#nullable restore
#line 82 "D:\PROJECTS\education_app\EducationApplication\Views\Account\AssignRole.cshtml"
                                             using (Html.BeginForm("DeleteRole", "Account", FormMethod.Post))
                                            {
                                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 4398, "\"", 4415, 1);
#nullable restore
#line 86 "D:\PROJECTS\education_app\EducationApplication\Views\Account\AssignRole.cshtml"
WriteAttributeValue("", 4406, Model.Id, 4406, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"userId\"/>\r\n                                                <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 4502, "\"", 4522, 1);
#nullable restore
#line 87 "D:\PROJECTS\education_app\EducationApplication\Views\Account\AssignRole.cshtml"
WriteAttributeValue("", 4510, item.RoleId, 4510, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"roleId\"/>\r\n                                                <button type=\"submit\" class=\"btn btn-danger\" data-attachid=\"");
#nullable restore
#line 88 "D:\PROJECTS\education_app\EducationApplication\Views\Account\AssignRole.cshtml"
                                                                                                       Write(item.RoleId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Delete</button>\r\n");
#nullable restore
#line 89 "D:\PROJECTS\education_app\EducationApplication\Views\Account\AssignRole.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 93 "D:\PROJECTS\education_app\EducationApplication\Views\Account\AssignRole.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </tbody>
                        </table>
                    </div>

                </div>
                <div class=""form-group"">
                    <input type=""reset"" name=""cancel"" onclick=""history.back()"" class=""btn btn-danger btn-md"" style=""float:right"" value=""Close"">
                </div>
                <!----->
            </div>
            <!---->
        </div>
    </div>
</div>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd01f564e01e19f86c03a90d2347ee0adc5e39b915593", async() => {
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
            WriteLiteral("\r\n<script>\r\n    $(document).ready(function () {\r\n        $.get(\'");
#nullable restore
#line 111 "D:\PROJECTS\education_app\EducationApplication\Views\Account\AssignRole.cshtml"
          Write(Url.Action("RolePartailList", "Account"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\', function (content) {\r\n            $(\"#assignRoleContainer\").html(content);\r\n        });\r\n\r\n        $(document).ready(function () {\r\n            $(\'#myAllRoles\').DataTable();\r\n        });\r\n    });\r\n\r\n</script>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EducationApplication.ViewModel.ViewModels.Users.UserRoleViewVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
