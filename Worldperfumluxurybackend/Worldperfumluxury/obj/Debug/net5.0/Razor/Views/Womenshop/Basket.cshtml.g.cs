#pragma checksum "C:\Users\dima-\Desktop\Final-Project-Backend\Worldperfumluxurybackend\Worldperfumluxury\Views\Womenshop\Basket.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97a55c3b3a1018e601e0471ce28eb5e4ea31e0ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Womenshop_Basket), @"mvc.1.0.view", @"/Views/Womenshop/Basket.cshtml")]
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
#line 7 "C:\Users\dima-\Desktop\Final-Project-Backend\Worldperfumluxurybackend\Worldperfumluxury\Views\_ViewImports.cshtml"
using Worldperfumluxury.ViewModels.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\dima-\Desktop\Final-Project-Backend\Worldperfumluxurybackend\Worldperfumluxury\Views\_ViewImports.cshtml"
using Worldperfumluxury.ViewModels.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\dima-\Desktop\Final-Project-Backend\Worldperfumluxurybackend\Worldperfumluxury\Views\_ViewImports.cshtml"
using Worldperfumluxury.ViewModels.Unisex;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\dima-\Desktop\Final-Project-Backend\Worldperfumluxurybackend\Worldperfumluxury\Views\_ViewImports.cshtml"
using Worldperfumluxury.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97a55c3b3a1018e601e0471ce28eb5e4ea31e0ea", @"/Views/Womenshop/Basket.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32168a0107ed2ee7d1a6a5420b3fe9cfefae0aa1", @"/Views/_ViewImports.cshtml")]
    public class Views_Womenshop_Basket : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BasketDetailVM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("150"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("product_image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\dima-\Desktop\Final-Project-Backend\Worldperfumluxurybackend\Worldperfumluxury\Views\Womenshop\Basket.cshtml"
  
    ViewData["Title"] = "Basket";
    Layout = "~/Views/Shared/_Layout.cshtml";
    int count = 1;
    decimal totalPrice = 0;


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <div class=""row"">

        <div class=""col-lg-12 grid-margin stretch-card"">
            <div class=""card"">
                <div class=""card-body"">
                    <div class=""header d-flex justify-content-between my-5"">

                        <h1 class=""card-title my-3"">Basket</h1>

                    </div>
                    <div class=""table-responsive"">
                        <table class=""table table-bordered"">
                            <thead>
                                <tr>
                                    <th> # </th>
                                    <th> Image </th>
                                    <th> Name </th>
                                    <th> Count </th>
                                    <th> Price </th>

                                </tr>

                            </thead>
                            <tbody>

");
#nullable restore
#line 36 "C:\Users\dima-\Desktop\Final-Project-Backend\Worldperfumluxurybackend\Worldperfumluxury\Views\Womenshop\Basket.cshtml"
                                 foreach (var womenshop in Model)
                                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 41 "C:\Users\dima-\Desktop\Final-Project-Backend\Worldperfumluxurybackend\Worldperfumluxury\Views\Womenshop\Basket.cshtml"
                                       Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n\r\n                                        <td>\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "97a55c3b3a1018e601e0471ce28eb5e4ea31e0ea7779", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1494, "~/assets/img/parfums/", 1494, 21, true);
#nullable restore
#line 45 "C:\Users\dima-\Desktop\Final-Project-Backend\Worldperfumluxurybackend\Worldperfumluxury\Views\Womenshop\Basket.cshtml"
AddHtmlAttributeValue("", 1515, womenshop.Image, 1515, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n                                        </td>\r\n\r\n                                        <td>\r\n\r\n                                            ");
#nullable restore
#line 52 "C:\Users\dima-\Desktop\Final-Project-Backend\Worldperfumluxurybackend\Worldperfumluxury\Views\Womenshop\Basket.cshtml"
                                       Write(womenshop.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 55 "C:\Users\dima-\Desktop\Final-Project-Backend\Worldperfumluxurybackend\Worldperfumluxury\Views\Womenshop\Basket.cshtml"
                                       Write(womenshop.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 59 "C:\Users\dima-\Desktop\Final-Project-Backend\Worldperfumluxurybackend\Worldperfumluxury\Views\Womenshop\Basket.cshtml"
                                       Write(womenshop.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₼\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 62 "C:\Users\dima-\Desktop\Final-Project-Backend\Worldperfumluxurybackend\Worldperfumluxury\Views\Womenshop\Basket.cshtml"
                                    count++;
                                    totalPrice += womenshop.Price;
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"my-5\">\r\n                                    <span>Total price: ");
#nullable restore
#line 66 "C:\Users\dima-\Desktop\Final-Project-Backend\Worldperfumluxurybackend\Worldperfumluxury\Views\Womenshop\Basket.cshtml"
                                                  Write(totalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₼ </span>\r\n                                </div>\r\n\r\n                            </tbody>\r\n\r\n                        </table>\r\n\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BasketDetailVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
