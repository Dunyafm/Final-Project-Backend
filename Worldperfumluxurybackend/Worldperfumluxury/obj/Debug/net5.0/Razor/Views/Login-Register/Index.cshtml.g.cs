#pragma checksum "C:\Users\dima-\Desktop\Final-Project-Backend\Worldperfumluxurybackend\Worldperfumluxury\Views\Login-Register\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1495ebba242d79a6047d22f0b266ba0eb89ba9e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Register_Index), @"mvc.1.0.view", @"/Views/Login-Register/Index.cshtml")]
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
#line 1 "C:\Users\dima-\Desktop\Final-Project-Backend\Worldperfumluxurybackend\Worldperfumluxury\Views\_ViewImports.cshtml"
using Worldperfumluxury;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dima-\Desktop\Final-Project-Backend\Worldperfumluxurybackend\Worldperfumluxury\Views\_ViewImports.cshtml"
using Worldperfumluxury.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\dima-\Desktop\Final-Project-Backend\Worldperfumluxurybackend\Worldperfumluxury\Views\_ViewImports.cshtml"
using Worldperfumluxury.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\dima-\Desktop\Final-Project-Backend\Worldperfumluxurybackend\Worldperfumluxury\Views\_ViewImports.cshtml"
using Worldperfumluxury.ViewModels.Admin;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1495ebba242d79a6047d22f0b266ba0eb89ba9e", @"/Views/Login-Register/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09b22c607b108b053d9d34d5745529e6fd945f7f", @"/Views/_ViewImports.cshtml")]
    public class Views_Login_Register_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("login-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\dima-\Desktop\Final-Project-Backend\Worldperfumluxurybackend\Worldperfumluxury\Views\Login-Register\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<link href=""https://fonts.googleapis.com/css?family=Open+Sans"" rel=""stylesheet"">
<link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css""
      integrity=""sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh"" crossorigin=""anonymous"">

<link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css"" rel=""stylesheet""
      integrity=""sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3"" crossorigin=""anonymous"">
<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/animate.css/3.5.2/animate.min.css"">

<!-- FOOTER -->

<link href=""//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css"" rel=""stylesheet"" id=""bootstrap-css"">
<link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css""
      integrity=""sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO"" crossorigin=""anonymous"">
<link rel=""stylesheet"" href=""https://u");
            WriteLiteral(@"se.fontawesome.com/releases/v5.2.0/css/all.css""
      integrity=""sha384-hWVjflwFxL6sNzntih27bfxkr27PmbbK/iSvJ+a4+0owXq79v+lsFkW54bOGbiDQ"" crossorigin=""anonymous"">

<link rel=""stylesheet"" href=""./assets/css/login-register.css"">

<div class=""container mb-5"">
    <div class=""panel shadow1 mb-5"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a1495ebba242d79a6047d22f0b266ba0eb89ba9e5933", async() => {
                WriteLiteral("\r\n            <div class=\"panel-switch animated fadeIn\">\r\n                <button type=\"button\" id=\"sign_up\" class=\"active-button\">Qeydiyyat</button>\r\n                <button type=\"button\" id=\"log_in\"");
                BeginWriteAttribute("class", " class=\"", 1648, "\"", 1656, 0);
                EndWriteAttribute();
                WriteLiteral(@" disabled>Giriş</button>
            </div>
            <h1 class=""animated fadeInUp animate1"" id=""title-login"">Xoş gəlmisiniz</h1>
            <h1 class=""animated fadeInUp animate1 hidden"" id=""title-signup"">Xoş gəlmisiniz</h1>
            <fieldset id=""login-fieldset"">
                <input class=""login animated fadeInUp animate2"" name=""username"" type=""textbox"" required
                       placeholder=""İstifadəçi adi""");
                BeginWriteAttribute("value", " value=\"", 2089, "\"", 2097, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                <input class=\"login animated fadeInUp animate3\" name=\"password\" type=\"password\" required placeholder=\"Şifrə\"");
                BeginWriteAttribute("value", "\r\n                       value=\"", 2225, "\"", 2257, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n            </fieldset>\r\n            <fieldset id=\"signup-fieldset\" class=\"hidden\">\r\n                <input class=\"login animated fadeInUp animate2\" name=\"username\" type=\"textbox\" required placeholder=\"Email\"");
                BeginWriteAttribute("value", "\r\n                       value=\"", 2469, "\"", 2501, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                <input class=\"login animated fadeInUp animate2\" name=\"username\" type=\"textbox\" required\r\n                       placeholder=\"İstifadəçi adi\"");
                BeginWriteAttribute("value", " value=\"", 2661, "\"", 2669, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                <input class=\"login animated fadeInUp animate3\" name=\"password\" type=\"password\"\r\n                       placeholder=\"Şifrənizi daxil edin\" required");
                BeginWriteAttribute("value", " value=\"", 2836, "\"", 2844, 0);
                EndWriteAttribute();
                WriteLiteral(@">
            </fieldset>
            <input type=""submit"" id=""login-form-submit"" class=""login_form button animated fadeInUp animate4"" value=""Giriş"">
            <input type=""submit"" id=""signup-form-submit"" class=""login_form button animated fadeInUp animate4 hidden""
                   value=""Qeydiyyat"">
            <p><a id=""lost-password-link""");
                BeginWriteAttribute("href", " href=\"", 3196, "\"", 3203, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"animated fadeIn animate5\">Şifrəmi unutdum (!)</a></p>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
</div>


<script src=""https://code.jquery.com/jquery-3.3.1.slim.min.js""
        integrity=""sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo""
        crossorigin=""anonymous""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js""
        integrity=""sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49""
        crossorigin=""anonymous""></script>
<script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js""
        integrity=""sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy""
        crossorigin=""anonymous""></script>

<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js""></script>
<!-- FOOTER -->
<script src=""//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js""></script>
<script src=""//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js""></script>

<script src=""./assets/js/login-register.js""></script>

");
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
