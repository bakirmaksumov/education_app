#pragma checksum "D:\Projects\education_app\EducationApplication\Views\Certificate\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "252d8f44619263f5d7eef71c4a44668836e26459"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Certificate_Details), @"mvc.1.0.view", @"/Views/Certificate/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"252d8f44619263f5d7eef71c4a44668836e26459", @"/Views/Certificate/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79146968fc73c728ff3fbfba8d6537b30dc4e4b2", @"/Views/_ViewImports.cshtml")]
    public class Views_Certificate_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EducationApplication.ViewModel.ViewModels.Certificate.CertificatesVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Projects\education_app\EducationApplication\Views\Certificate\Details.cshtml"
  
    ViewBag.Title = "Index";
    Layout = "~/Views/Shared/_EducationLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row mrg-top30"">
    <div class=""col-md-12"">
        <div class=""card"">
            <div class=""card-header"">
                <h5>Certificate View</h5>
            </div>
            <div class=""card-body"">
                <!--tables-->
                <div class=""form-inline"">
                    <div class=""col-md-12 form-group"">
                        <label class=""col-md-3 control-label"" for=""Title""><b>Student ID:</b></label>
                        <div class=""col-md-3"">
                            <p class=""padding-top20"">");
#nullable restore
#line 19 "D:\Projects\education_app\EducationApplication\Views\Certificate\Details.cshtml"
                                                Write(Model.PINFL);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                        </div>
                    </div>
                </div>
                <div class=""form-inline"">
                    <div class=""col-md-12 form-group"">
                        <label class=""col-md-3 control-label"" for=""Title""><b>Student Name:</b></label>
                        <div class=""col-md-3"">
                            <p class=""padding-top20"">");
#nullable restore
#line 27 "D:\Projects\education_app\EducationApplication\Views\Certificate\Details.cshtml"
                                                Write(Model.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                        </div>
                    </div>
                </div>
                <div class=""form-inline"">
                    <div class=""col-md-12 form-group"">
                        <label class=""col-md-3 control-label"" for=""Title""><b>School Name:</b></label>
                        <div class=""col-md-3"">
                            <p class=""padding-top20"">University of Westminister</p>
                        </div>
                    </div>
                </div>
                <div class=""form-inline"">
                    <div class=""col-md-12 form-group"">
                        <label class=""col-md-3 control-label"" for=""Title""><b>Registration Number:</b></label>
                        <div class=""col-md-3"">
                            <p class=""padding-top20"">000232</p>
                        </div>
                    </div>
                </div>
                <div class=""form-inline"">
                    <div class=""col-md-12 form-group"">
         ");
            WriteLiteral("               <label class=\"col-md-3 control-label\" for=\"Title\"><b>Certificate Type:</b></label>\r\n                        <div class=\"col-md-3\">\r\n                            <p class=\"padding-top20\">");
#nullable restore
#line 51 "D:\Projects\education_app\EducationApplication\Views\Certificate\Details.cshtml"
                                                Write(Model.CertificateType);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                        </div>
                    </div>
                </div>
                <div class=""form-inline"">
                    <div class=""col-md-12 form-group"">
                        <label class=""col-md-3 control-label"" for=""Title""><b>Due Date:</b></label>
                        <div class=""col-md-3"">
                            <p class=""padding-top20"">");
#nullable restore
#line 59 "D:\Projects\education_app\EducationApplication\Views\Certificate\Details.cshtml"
                                                Write(Model.DueDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                        </div>
                    </div>
                </div>
                <div class=""form-inline"">
                    <div class=""col-md-12 form-group"">
                        <label class=""col-md-3 control-label"" for=""Title""><b>Status:</b></label>
                        <div class=""col-md-3"">
                            <p class=""padding-top20"" style=""color:green"">Valid</p>
                        </div>
                    </div>
                </div>
                <hr />
                <div class=""form-group"">
                    <input type=""reset"" name=""cancel"" class=""btn btn-danger btn-md"" style=""float:right"" value=""Close"">
                </div>
                <!----->
            </div>
            <!---->
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EducationApplication.ViewModel.ViewModels.Certificate.CertificatesVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
