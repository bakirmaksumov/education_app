#pragma checksum "D:\Projects\education_app\EducationApplication\Views\Account\AssignRole.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5982b5224293761665efbcf77964cd2b603061e7"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5982b5224293761665efbcf77964cd2b603061e7", @"/Views/Account/AssignRole.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79146968fc73c728ff3fbfba8d6537b30dc4e4b2", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_AssignRole : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Projects\education_app\EducationApplication\Views\Account\AssignRole.cshtml"
  
    ViewData["Title"] = "AssignRole";
    Layout = "~/Views/Shared/_EducationLayout.cshtml";

#line default
#line hidden
#nullable disable
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
                        <label class=""col-md-3 control-label"" for=""Title""><b>UserID:</b></label>
                        <div class=""col-md-3"">
                            <p class=""padding-top20"">test</p>
                        </div>
                    </div>
                </div>
                <div class=""form-inline"">
                    <div class=""col-md-12 form-group"">
                        <label class=""col-md-3 control-label"" for=""Title""><b>UserName:</b></label>
                        <div class=""col-md-3"">
                            <p class=""padding-top20"">test</p>
                        </div>
                    </div>
      ");
            WriteLiteral(@"          </div>
                <div class=""form-inline"">
                    <div class=""col-md-12 form-group"">
                        <label class=""col-md-3 control-label"" for=""Title""><b>FirstName:</b></label>
                        <div class=""col-md-3"">
                            <p class=""padding-top20"">test</p>
                        </div>
                    </div>
                </div>
                <div class=""form-inline"">
                    <div class=""col-md-12 form-group"">
                        <label class=""col-md-3 control-label"" for=""Title""><b>LastName:</b></label>
                        <div class=""col-md-3"">
                            <p class=""padding-top20"">test</p>
                        </div>
                    </div>
                </div>
                <div class=""form-inline"">
                    <div class=""col-md-12 form-group mrg-top30"">
");
            WriteLiteral("                        <select class=\"col-md-6 form-control\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5982b5224293761665efbcf77964cd2b603061e75551", async() => {
                WriteLiteral("--Select--");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5982b5224293761665efbcf77964cd2b603061e76541", async() => {
                WriteLiteral("Example1");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5982b5224293761665efbcf77964cd2b603061e77529", async() => {
                WriteLiteral("Example2");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </select>
                        <button class=""margin-left5 btn btn-success"">Add Role</button>
                    </div>
                </div>
                <hr />
                <div class=""col-md-12"">
                    <div id=""assignRoleContainer""></div>
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
<script>
    $(document).ready(function () {
        $.get('");
#nullable restore
#line 74 "D:\Projects\education_app\EducationApplication\Views\Account\AssignRole.cshtml"
          Write(Url.Action("RolePartailList", "Account"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\', function (content) {\r\n            $(\"#assignRoleContainer\").html(content);\r\n        });\r\n    });\r\n\r\n</script>\r\n\r\n\r\n");
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
