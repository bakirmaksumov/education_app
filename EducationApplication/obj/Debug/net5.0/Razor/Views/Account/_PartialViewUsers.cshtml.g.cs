#pragma checksum "D:\Projects\education_app\EducationApplication\Views\Account\_PartialViewUsers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b731c70a362ec83d66266134b5d9531247577c90"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account__PartialViewUsers), @"mvc.1.0.view", @"/Views/Account/_PartialViewUsers.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b731c70a362ec83d66266134b5d9531247577c90", @"/Views/Account/_PartialViewUsers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79146968fc73c728ff3fbfba8d6537b30dc4e4b2", @"/Views/_ViewImports.cshtml")]
    public class Views_Account__PartialViewUsers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<EducationApplication.ViewModel.ViewModels.Users.UserRoleVM>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Projects\education_app\EducationApplication\Views\Account\_PartialViewUsers.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""table-responsive"">
    <table id=""myAlldepartment"" class=""table table-striped"">
        <thead>
            <tr>
                <th>
                    ???
                </th>
                <th>
                    Username
                </th>
                <th>
                    Full Name
                </th>
                <th>
                    Email
                </th>
                <th>
                    Action
                </th>
            </tr>
        </thead>
        <tbody>

");
#nullable restore
#line 31 "D:\Projects\education_app\EducationApplication\Views\Account\_PartialViewUsers.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 35 "D:\Projects\education_app\EducationApplication\Views\Account\_PartialViewUsers.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 38 "D:\Projects\education_app\EducationApplication\Views\Account\_PartialViewUsers.cshtml"
                       Write(Html.DisplayFor(modelItem => item.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 41 "D:\Projects\education_app\EducationApplication\Views\Account\_PartialViewUsers.cshtml"
                       Write(Html.DisplayFor(modelItem => item.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 44 "D:\Projects\education_app\EducationApplication\Views\Account\_PartialViewUsers.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            <button class=\"btn btn-info\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1377, "\"", 1460, 3);
            WriteAttributeValue("", 1387, "location.href=\'", 1387, 15, true);
#nullable restore
#line 47 "D:\Projects\education_app\EducationApplication\Views\Account\_PartialViewUsers.cshtml"
WriteAttributeValue("", 1402, Url.Action("AssignRole", "Account", new  {id =item.Id }), 1402, 57, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1459, "\'", 1459, 1, true);
            EndWriteAttribute();
            WriteLiteral(">View</button>\r\n");
            WriteLiteral("                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 51 "D:\Projects\education_app\EducationApplication\Views\Account\_PartialViewUsers.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("             </tbody>\r\n    </table>\r\n</div>\r\n<script>\r\n    $(document).ready(function () {\r\n        $(\'#myAlldepartment\').DataTable();\r\n    });\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<EducationApplication.ViewModel.ViewModels.Users.UserRoleVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
