#pragma checksum "C:\Users\dima-\Desktop\Final-Project-Backend\Worldperfumluxurybackend\Worldperfumluxury\Views\Menshop\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed4fd884472e71d8296a70b8ca0d9b163f5799e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Menshop_Index), @"mvc.1.0.view", @"/Views/Menshop/Index.cshtml")]
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
using Worldperfumluxury.ViewModels.Unisex;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\dima-\Desktop\Final-Project-Backend\Worldperfumluxurybackend\Worldperfumluxury\Views\_ViewImports.cshtml"
using Worldperfumluxury.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed4fd884472e71d8296a70b8ca0d9b163f5799e0", @"/Views/Menshop/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e71286130c938bb1d6ebcf81ec9a0c2c613e745c", @"/Views/_ViewImports.cshtml")]
    public class Views_Menshop_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Paginate<MenshopListVM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/css/menshop.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("god-of-war-figurine"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("page-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/menshop.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\dima-\Desktop\Final-Project-Backend\Worldperfumluxurybackend\Worldperfumluxury\Views\Menshop\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";
    var date = DateTime.Now.AddDays(-2).Day;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ed4fd884472e71d8296a70b8ca0d9b163f5799e07738", async() => {
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
<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.1.3/css/bootstrap.min.css"">

<!-- ICONS FOR LINKS -->
<link rel=""stylesheet"" href=""https://use.fontawesome.com/releases/v5.2.0/css/all.css""
      integrity=""sha384-hWVjflwFxL6sNzntih27bfxkr27PmbbK/iSvJ+a4+0owXq79v+lsFkW54bOGbiDQ"" crossorigin=""anonymous"">

<!-- FILTER START -->
");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n\r\n");
            WriteLiteral(@"<!--<div class=""py-3"">
        <h5 class=""font-weight-bold"">REYTİNQ</h5>
        <form class=""rating"">
            <div class=""form-inline d-flex align-items-center py-2"">
                <label class=""tick"">
                    <span class=""fas fa-star""></span> <span class=""fas fa-star""></span> <span class=""fas fa-star""></span> <span class=""fas fa-star""></span> <span class=""fas fa-star""></span> <input type=""checkbox""> <span class=""check""></span>
                </label>
            </div>
            <div class=""form-inline d-flex align-items-center py-2"">
                <label class=""tick"">
                    <span class=""fas fa-star""></span> <span class=""fas fa-star""></span> <span class=""fas fa-star""></span> <span class=""fas fa-star""></span> <span class=""far fa-star px-1 text-muted""></span> <input type=""checkbox""> <span class=""check""></span>
                </label>
            </div>
            <div class=""form-inline d-flex align-items-center py-2"">
                <label class=""tick"">
");
            WriteLiteral(@"                    <span class=""fas fa-star""></span> <span class=""fas fa-star""></span> <span class=""fas fa-star""></span> <span class=""far fa-star px-1 text-muted""></span> <span class=""far fa-star px-1 text-muted""></span> <input type=""checkbox""> <span class=""check""></span>
                </label>
            </div>
            <div class=""form-inline d-flex align-items-center py-2"">
                <label class=""tick"">
                    <span class=""fas fa-star""></span> <span class=""fas fa-star""></span> <span class=""far fa-star px-1 text-muted""></span> <span class=""far fa-star px-1 text-muted""></span> <span class=""far fa-star px-1 text-muted""></span> <input type=""checkbox""> <span class=""check""></span>
                </label>
            </div>
            <div class=""form-inline d-flex align-items-center py-2"">
                <label class=""tick"">
                    <span class=""fas fa-star""></span> <span class=""far fa-star px-1 text-muted""></span> <span class=""far fa-star px-1 text-muted""></sp");
            WriteLiteral(@"an> <span class=""far fa-star px-1 text-muted""></span> <span class=""far fa-star px-1 text-muted""></span> <input type=""checkbox""> <span class=""check""></span>
                </label>
            </div>
        </form>
    </div>
</div>
<div class=""content py-md-0 py-3"">
    <section id=""sidebar"">
        <div class=""py-3"">
            <h5 class=""font-weight-bold"">Katergoriyalar</h5>
            <ul class=""list-group"">
                <li class=""list-group-item list-group-item-action d-flex justify-content-between align-items-center category"">
                    QADIN <span class=""badge badge-primary badge-pill""></span>
                </li>
                <li class=""list-group-item list-group-item-action d-flex justify-content-between align-items-center category"">
                    KİŞİ <span class=""badge badge-primary badge-pill""></span>
                </li>
                <li class=""list-group-item list-group-item-action d-flex justify-content-between align-items-center category"">
    ");
            WriteLiteral(@"                UNISEX <span class=""badge badge-primary badge-pill""></span>
                </li>
                <li class=""list-group-item list-group-item-action d-flex justify-content-between align-items-center category"">
                    BREND<span class=""badge badge-primary badge-pill""></span>
                </li>
            </ul>
        </div>
        <div class=""py-3"">
            <h5 class=""font-weight-bold"">BRENDLER</h5>
            <form class=""brand"">
                <div class=""form-inline d-flex align-items-center py-1"">
                    <label class=""tick"">
                        TOMFORD <input type=""checkbox""> <span class=""check""></span>
                    </label>
                </div>
                <div class=""form-inline d-flex align-items-center py-1"">
                    <label class=""tick"">
                        DİOR <input type=""checkbox"" checked> <span class=""check""></span>
                    </label>
                </div>
                <div class");
            WriteLiteral(@"=""form-inline d-flex align-items-center py-1"">
                    <label class=""tick"">
                        JO MALONE <input type=""checkbox"" checked> <span class=""check""></span>
                    </label>
                </div>
                <div class=""form-inline d-flex align-items-center py-1"">
                    <label class=""tick"">
                        GİORGİO ARMANİ
                        <input type=""checkbox""> <span class=""check""></span>
                    </label>
                </div>
                <div class=""form-inline d-flex align-items-center py-1"">
                    <label class=""tick"">
                        CAROLİNA HERRARA
                        <input type=""checkbox""> <span class=""check""></span>
                    </label>
                </div>
            </form>
        </div>
        <div class=""py-3"">
            <h5 class=""font-weight-bold"">REYTİNQ</h5>
            <form class=""rating"">
                <div class=""form-inline d-flex align-i");
            WriteLiteral(@"tems-center py-2"">
                    <label class=""tick"">
                        <span class=""fas fa-star""></span> <span class=""fas fa-star""></span> <span class=""fas fa-star""></span> <span class=""fas fa-star""></span> <span class=""fas fa-star""></span> <input type=""checkbox""> <span class=""check""></span>
                    </label>
                </div>
                <div class=""form-inline d-flex align-items-center py-2"">
                    <label class=""tick"">
                        <span class=""fas fa-star""></span> <span class=""fas fa-star""></span> <span class=""fas fa-star""></span> <span class=""fas fa-star""></span> <span class=""far fa-star px-1 text-muted""></span> <input type=""checkbox""> <span class=""check""></span>
                    </label>
                </div>
                <div class=""form-inline d-flex align-items-center py-2"">
                    <label class=""tick"">
                        <span class=""fas fa-star""></span> <span class=""fas fa-star""></span> <span class=""fas fa-");
            WriteLiteral(@"star""></span> <span class=""far fa-star px-1 text-muted""></span> <span class=""far fa-star px-1 text-muted""></span> <input type=""checkbox""> <span class=""check""></span>
                    </label>
                </div>
                <div class=""form-inline d-flex align-items-center py-2"">
                    <label class=""tick"">
                        <span class=""fas fa-star""></span> <span class=""fas fa-star""></span> <span class=""far fa-star px-1 text-muted""></span> <span class=""far fa-star px-1 text-muted""></span> <span class=""far fa-star px-1 text-muted""></span> <input type=""checkbox""> <span class=""check""></span>
                    </label>
                </div>
                <div class=""form-inline d-flex align-items-center py-2"">
                    <label class=""tick"">
                        <span class=""fas fa-star""></span> <span class=""far fa-star px-1 text-muted""></span> <span class=""far fa-star px-1 text-muted""></span> <span class=""far fa-star px-1 text-muted""></span> <span class=""f");
            WriteLiteral(@"ar fa-star px-1 text-muted""></span> <input type=""checkbox""> <span class=""check""></span>
                    </label>
                </div>
            </form>
        </div>
    </section>-->
 <!-- Products Section -->
<section id=""products"" style=""padding-right:433px"">
    <div class=""container py-3"">
        <div class=""row"">
");
#nullable restore
#line 224 "C:\Users\dima-\Desktop\Final-Project-Backend\Worldperfumluxurybackend\Worldperfumluxury\Views\Menshop\Index.cshtml"
             foreach (var menshop in Model.Datas)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-lg-4 col-md-6 col-sm-10 offset-md-0 offset-sm-1\">\r\n                    <div class=\"card\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ed4fd884472e71d8296a70b8ca0d9b163f5799e017836", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 11544, "~/assets/img/parfums/", 11544, 21, true);
#nullable restore
#line 229 "C:\Users\dima-\Desktop\Final-Project-Backend\Worldperfumluxurybackend\Worldperfumluxury\Views\Menshop\Index.cshtml"
AddHtmlAttributeValue("", 11565, menshop.Image, 11565, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        <div class=""card-body"">
                            <h6 class=""font-weight-bold pt-1"">Product title</h6>
                            <div class=""text-muted description"">Space for small product description</div>
                            <div class=""d-flex align-items-center product"">
                                <span class=""fas fa-star""></span>
                                <span class=""fas fa-star""></span> <span class=""fas fa-star""></span> <span class=""fas fa-star""></span> <span class=""far fa-star""></span>
                            </div>
                            <div class=""d-flex align-items-center justify-content-between pt-3"">
                                <div class=""d-flex flex-column"">
                                    <div class=""h6 font-weight-bold"">36.99 USD</div>
                                    <div class=""text-muted rebate"">48.56</div>
                                </div>
                                <div class=""btn btn-primary"">Sifa");
            WriteLiteral("riş et</div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 247 "C:\Users\dima-\Desktop\Final-Project-Backend\Worldperfumluxurybackend\Worldperfumluxury\Views\Menshop\Index.cshtml"



            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n\r\n    </div>\r\n</div>\r\n<!-- FILTER END -->\r\n<!-- MAIN START -->\r\n<!-- PRODUCT CARD -->\r\n\r\n\r\n<div class=\"container container-xl\">\r\n    <h2>Yeni kişi ətirləri</h2>\r\n</div>\r\n\r\n<div class=\"container\">\r\n");
#nullable restore
#line 269 "C:\Users\dima-\Desktop\Final-Project-Backend\Worldperfumluxurybackend\Worldperfumluxury\Views\Menshop\Index.cshtml"
     foreach (var item in Model.Datas.Where(m => m.Date.Day == date))

    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""card-1 card-div"">
            <div class=""like-icon-div"">
                <label for=""card-1-like"" class=""like-icon-div-child"">
                    <input type=""checkbox"" id=""card-1-like"">

                </label>
            </div>

            <div class=""gow-img-div img-div"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ed4fd884472e71d8296a70b8ca0d9b163f5799e021859", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 13417, "~/assets/img/parfums/", 13417, 21, true);
#nullable restore
#line 281 "C:\Users\dima-\Desktop\Final-Project-Backend\Worldperfumluxurybackend\Worldperfumluxury\Views\Menshop\Index.cshtml"
AddHtmlAttributeValue("", 13438, item.Image, 13438, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n            <div class=\"text-container\">\r\n\r\n                <p class=\"perfum-name\">");
#nullable restore
#line 285 "C:\Users\dima-\Desktop\Final-Project-Backend\Worldperfumluxurybackend\Worldperfumluxury\Views\Menshop\Index.cshtml"
                                  Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <div class=\"pricing-and-cart\">\r\n                    <div class=\"pricing\">\r\n                        <p class=\"previous-price\">220</p>\r\n                        <p class=\"current-price\">");
#nullable restore
#line 289 "C:\Users\dima-\Desktop\Final-Project-Backend\Worldperfumluxurybackend\Worldperfumluxury\Views\Menshop\Index.cshtml"
                                            Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("/p>\r\n                    </div>\r\n                    <a data-id=\"");
#nullable restore
#line 291 "C:\Users\dima-\Desktop\Final-Project-Backend\Worldperfumluxurybackend\Worldperfumluxury\Views\Menshop\Index.cshtml"
                           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\" add-items ad-basket btn btn-sm\"><i data-id=\"");
#nullable restore
#line 291 "C:\Users\dima-\Desktop\Final-Project-Backend\Worldperfumluxurybackend\Worldperfumluxury\Views\Menshop\Index.cshtml"
                                                                                         Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"fas fa-shopping-cart\"></i></a>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 295 "C:\Users\dima-\Desktop\Final-Project-Backend\Worldperfumluxurybackend\Worldperfumluxury\Views\Menshop\Index.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n</div>\r\n<!-- MAIN END -->\r\n");
            WriteLiteral("<div class=\"row my-3\">\r\n    <nav aria-label=\"...\">\r\n        <ul class=\"pagination\" style=\"padding-left:910px\">\r\n            <li");
            BeginWriteAttribute("class", " class=\"", 14229, "\"", 14286, 3);
            WriteAttributeValue("", 14237, "page-item", 14237, 9, true);
#nullable restore
#line 306 "C:\Users\dima-\Desktop\Final-Project-Backend\Worldperfumluxurybackend\Worldperfumluxury\Views\Menshop\Index.cshtml"
WriteAttributeValue(" ", 14246, Model.HasPrevious ? "" : "disabled", 14247, 38, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 14285, "", 14286, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed4fd884472e71d8296a70b8ca0d9b163f5799e026272", async() => {
                WriteLiteral("Previous");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 307 "C:\Users\dima-\Desktop\Final-Project-Backend\Worldperfumluxurybackend\Worldperfumluxury\Views\Menshop\Index.cshtml"
                                                             WriteLiteral(Model.CurrentPage-1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </li>\r\n");
#nullable restore
#line 309 "C:\Users\dima-\Desktop\Final-Project-Backend\Worldperfumluxurybackend\Worldperfumluxury\Views\Menshop\Index.cshtml"
             for (int i = 1; i <= Model.TotalPage; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li");
            BeginWriteAttribute("class", " class=\"", 14510, "\"", 14569, 2);
            WriteAttributeValue("", 14518, "page-item", 14518, 9, true);
#nullable restore
#line 311 "C:\Users\dima-\Desktop\Final-Project-Backend\Worldperfumluxurybackend\Worldperfumluxury\Views\Menshop\Index.cshtml"
WriteAttributeValue(" ", 14527, i==Model.CurrentPage ? "disabled" : "", 14528, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed4fd884472e71d8296a70b8ca0d9b163f5799e029457", async() => {
#nullable restore
#line 312 "C:\Users\dima-\Desktop\Final-Project-Backend\Worldperfumluxurybackend\Worldperfumluxury\Views\Menshop\Index.cshtml"
                                                                           Write(i);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 312 "C:\Users\dima-\Desktop\Final-Project-Backend\Worldperfumluxurybackend\Worldperfumluxury\Views\Menshop\Index.cshtml"
                                                                WriteLiteral(i);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </li>\r\n");
#nullable restore
#line 314 "C:\Users\dima-\Desktop\Final-Project-Backend\Worldperfumluxurybackend\Worldperfumluxury\Views\Menshop\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li");
            BeginWriteAttribute("class", " class=\"", 14714, "\"", 14766, 2);
            WriteAttributeValue("", 14722, "page-item", 14722, 9, true);
#nullable restore
#line 315 "C:\Users\dima-\Desktop\Final-Project-Backend\Worldperfumluxurybackend\Worldperfumluxury\Views\Menshop\Index.cshtml"
WriteAttributeValue(" ", 14731, Model.HasNext ? "" : "disabled", 14732, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed4fd884472e71d8296a70b8ca0d9b163f5799e032799", async() => {
                WriteLiteral("Next");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 316 "C:\Users\dima-\Desktop\Final-Project-Backend\Worldperfumluxurybackend\Worldperfumluxury\Views\Menshop\Index.cshtml"
                                                             WriteLiteral(Model.CurrentPage+1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </li>\r\n        </ul>\r\n    </nav>\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed4fd884472e71d8296a70b8ca0d9b163f5799e035170", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n");
            DefineSection("Script", async() => {
                WriteLiteral(@"
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery/3.6.0/jquery.min.js"" integrity=""sha512-894YE6QWD5I59HgZOGReFYm4dnWc1Qt5NtvYSaNcOP+u1T9qYdvdihz0PPSiiqn/+/3e7Jo4EaG7TubfWGUrMQ=="" crossorigin=""anonymous"" referrerpolicy=""no-referrer""></script>
    <script src=""//cdn.jsdelivr.net/npm/sweetalert2@11""></script>
    <script>
        var btns = document.querySelectorAll("".ad-basket"")
        console.log(btns)

        btns.forEach((val, i) => {

            val.addEventListener(""click"", function (e) {
                e.preventDefault()

                var id = this.getAttribute(""data-id"")


                $.ajax({
                    url: ""https://localhost:44334/product/AddBasket"",
                    data: {
                        id: id
                    },
                    dataType: 'json',
                    type: ""post"",
                    success: function (data) {
                        Swal.fire({
                            position: 'center',
             ");
                WriteLiteral(@"               icon: 'success',
                            title: 'Uğurla əlavə edildi',
                            showConfirmButton: false,
                            timer: 1000
                        })
                    }
                })
            })
        })
    </script>

");
            }
            );
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed4fd884472e71d8296a70b8ca0d9b163f5799e037828", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<!-- Filter -->
<script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.bundle.min.js""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js""></script>


<script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery/3.4.1/jquery.min.js""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.1.3/css/bootstrap.min.css""></script>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Paginate<MenshopListVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
