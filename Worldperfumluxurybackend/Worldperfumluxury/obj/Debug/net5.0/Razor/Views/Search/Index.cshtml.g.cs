#pragma checksum "C:\Users\dima-\Desktop\Final-Project-Backend\Worldperfumluxurybackend\Worldperfumluxury\Views\Search\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "459d93b282d97b221e14544bba87d832fe247a3d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Search_Index), @"mvc.1.0.view", @"/Views/Search/Index.cshtml")]
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
using Worldperfumluxury.Utilites.Pagination;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\dima-\Desktop\Final-Project-Backend\Worldperfumluxurybackend\Worldperfumluxury\Views\_ViewImports.cshtml"
using Worldperfumluxury.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\dima-\Desktop\Final-Project-Backend\Worldperfumluxurybackend\Worldperfumluxury\Views\_ViewImports.cshtml"
using Worldperfumluxury.ViewModels.Basket;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\dima-\Desktop\Final-Project-Backend\Worldperfumluxurybackend\Worldperfumluxury\Views\_ViewImports.cshtml"
using Worldperfumluxury.ViewModels.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\dima-\Desktop\Final-Project-Backend\Worldperfumluxurybackend\Worldperfumluxury\Views\_ViewImports.cshtml"
using Worldperfumluxury.ViewModels.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\dima-\Desktop\Final-Project-Backend\Worldperfumluxurybackend\Worldperfumluxury\Views\_ViewImports.cshtml"
using Worldperfumluxury.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"459d93b282d97b221e14544bba87d832fe247a3d", @"/Views/Search/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cb96e96330129b805c4e65075114610263929bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Search_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("flex-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\dima-\Desktop\Final-Project-Backend\Worldperfumluxurybackend\Worldperfumluxury\Views\Search\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<link href=""//maxcdn.bootstrapcdn.com/bootstrap/3.3.0/css/bootstrap.min.css"" rel=""stylesheet"" id=""bootstrap-css"">
<script src=""//maxcdn.bootstrapcdn.com/bootstrap/3.3.0/js/bootstrap.min.js""></script>
<script src=""//code.jquery.com/jquery-1.11.1.min.js""></script>
<!-- ICONS FOR LINKS -->
<link rel=""stylesheet"" href=""https://use.fontawesome.com/releases/v5.2.0/css/all.css""
      integrity=""sha384-hWVjflwFxL6sNzntih27bfxkr27PmbbK/iSvJ+a4+0owXq79v+lsFkW54bOGbiDQ"" crossorigin=""anonymous"">

<link href=""//maxcdn.bootstrapcdn.com/font-awesome/4.2.0/css/font-awesome.min.css"" rel=""stylesheet"">
<link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css""
      integrity=""sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm"" crossorigin=""anonymous"">
<link rel=""stylesheet"" href=""./assets/css/search.css"">


<div class=""container"">

    <header>
        <h2><a href=""home.html""><i class=""ion-plane""></i>worldperfumluxury</a></h2>
        <nav>
     ");
            WriteLiteral(@"       <ul>
                <li>
                    <a href=""product.html"" title=""Ətirlər"">ƏTİRLƏR</a>
                </li>
                <li>
                    <a href=""womenshop.html"" title=""Qadın"">QADIN</a>
                </li>
                <li>
                    <a href=""menshop.html"" title=""Kişi"">KİŞİ</a>
                </li>
                <li>
                    <a href=""unisexshop.html"" title=""Unisex"">UNİSEX</a>
                </li>
                <li>
                    <a class=""btn"" href=""login-register.html"" title=""Qeydiyyat / Giriş"">Qeydiyyat / Giriş</a>
                </li>
            </ul>
        </nav>
    </header>

    <div class=""cover"">
        <h1>AXTAR</h1>
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "459d93b282d97b221e14544bba87d832fe247a3d7270", async() => {
                WriteLiteral("\r\n            <input type=\"search\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 1911, "\"", 1925, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n            <input type=\"submit\" value=\"Search\">\r\n        ");
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
            WriteLiteral("\r\n\r\n    </div>\r\n\r\n</div>\r\n\r\n");
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
