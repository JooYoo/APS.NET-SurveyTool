#pragma checksum "C:\Users\zhuyu\Desktop\SurveyWeb\SurveyWeb\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "116207843b7c4695c2939e06452cea6a3beeccf6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\zhuyu\Desktop\SurveyWeb\SurveyWeb\Views\_ViewImports.cshtml"
using SurveyWeb;

#line default
#line hidden
#line 2 "C:\Users\zhuyu\Desktop\SurveyWeb\SurveyWeb\Views\_ViewImports.cshtml"
using SurveyWeb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"116207843b7c4695c2939e06452cea6a3beeccf6", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f6075d6c5d2e67aeac90b64470085bb553736c5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SurveyWeb.Models.User>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\zhuyu\Desktop\SurveyWeb\SurveyWeb\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(88, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "C:\Users\zhuyu\Desktop\SurveyWeb\SurveyWeb\Views\Home\Index.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
            BeginContext(120, 421, true);
            WriteLiteral(@"    <div class=""container"">
        <div class=""row justify-content-md-center"">
            <div class=""col-md-3"">
                <div>tester@mail.com</div>
                <div>1</div>
            </div>
            <div class=""col-md-6 "">
                <div id=""login-card"" class=""card row justify-content-center align-items-center shadow-lg p-3 mb-5 bg-white"">
                    <div class=""card-body "">
");
            EndContext();
            BeginContext(576, 226, true);
            WriteLiteral("                        <h4 class=\"card-title text-center mb-4 mt-1\">Login</h4>\r\n                        <hr style=\"margin-bottom: 40px; margin-top: 40px\">\r\n                        <p class=\"text-success text-center\"> </p>\r\n\r\n");
            EndContext();
            BeginContext(839, 270, true);
            WriteLiteral(@"                        <div class=""form-group"">
                            <input id=""AccountTx"" name=""accountTx"" class=""form-control"" style=""width:300px"" placeholder=""Account"" type=""email"" style=""width: 200px"">
                        </div> <!-- form-group// -->
");
            EndContext();
            BeginContext(1147, 253, true);
            WriteLiteral("                        <div class=\"form-group\">\r\n                            <input id=\"PasswordTx\" name=\"passwordTx\" class=\"form-control\" style=\"width:300px\" placeholder=\"******\" type=\"password\">\r\n                        </div> <!-- form-group// -->\r\n");
            EndContext();
            BeginContext(1441, 56, true);
            WriteLiteral("                        <div style=\"margin-top: 0px;\">\r\n");
            EndContext();
#line 32 "C:\Users\zhuyu\Desktop\SurveyWeb\SurveyWeb\Views\Home\Index.cshtml"
                              
                                if (ViewData["isOk"]== null)
                                {

#line default
#line hidden
            BeginContext(1626, 129, true);
            WriteLiteral("                                    <div id=\"ValidatorTx\" class=\"alert alert-danger\" role=\"alert\" style=\"display: none;\"></div>\r\n");
            EndContext();
#line 36 "C:\Users\zhuyu\Desktop\SurveyWeb\SurveyWeb\Views\Home\Index.cshtml"
                                }
                                else if (ViewData["isOk"].ToString().ToLower() == "false")
                                {

#line default
#line hidden
            BeginContext(1917, 192, true);
            WriteLiteral("                                    <div id=\"ValidatorTx\" class=\"alert alert-danger\" role=\"alert\">\r\n                                        Failed\r\n                                    </div>\r\n");
            EndContext();
#line 42 "C:\Users\zhuyu\Desktop\SurveyWeb\SurveyWeb\Views\Home\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(2217, 194, true);
            WriteLiteral("                                    <div id=\"ValidatorTx\" class=\"alert alert-success\" role=\"alert\">\r\n                                        Success\r\n                                    </div>\r\n");
            EndContext();
#line 48 "C:\Users\zhuyu\Desktop\SurveyWeb\SurveyWeb\Views\Home\Index.cshtml"
                                }
                            

#line default
#line hidden
            BeginContext(2477, 34, true);
            WriteLiteral("                        </div>\r\n\r\n");
            EndContext();
            BeginContext(2773, 512, true);
            WriteLiteral(@"
                        <div class=""form-group col-12"">
                            <button id=""SubmitBtn"" type=""submit"" name=""postAction"" class=""btn btn-primary btn-block"" style=""width: 250px; margin-top: 60px ""> Login </button>
                        </div> <!-- form-group// -->

                        <p class=""text-center""><a href=""#"" class=""btn"">Forgot password?</a></p>
                    </div>
                </div> <!-- card.// -->
            </div>
            <div class=""col-md-3"">
");
            EndContext();
            BeginContext(3317, 48, true);
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 71 "C:\Users\zhuyu\Desktop\SurveyWeb\SurveyWeb\Views\Home\Index.cshtml"
}

#line default
#line hidden
            BeginContext(3368, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
            BeginContext(5068, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
            BeginContext(5086, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SurveyWeb.Models.User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
