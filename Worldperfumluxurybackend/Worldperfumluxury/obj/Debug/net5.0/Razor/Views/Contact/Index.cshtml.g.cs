#pragma checksum "C:\Users\dima-\Desktop\Final-Project-Backend\Worldperfumluxurybackend\Worldperfumluxury\Views\Contact\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2f9b48c3c410e1b1da5ac3274f4ec0469c60c1a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Index), @"mvc.1.0.view", @"/Views/Contact/Index.cshtml")]
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
using Worldperfumluxury.ViewModels.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\dima-\Desktop\Final-Project-Backend\Worldperfumluxurybackend\Worldperfumluxury\Views\_ViewImports.cshtml"
using Worldperfumluxury.ViewModels.Admin;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2f9b48c3c410e1b1da5ac3274f4ec0469c60c1a", @"/Views/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4100628ee4a71303eb6a4546000d7759fec8621", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ContactVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("required", new global::Microsoft.AspNetCore.Html.HtmlString("required"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "tel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Contact", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString("Göndər"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("line-height:3.5;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "contact", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\dima-\Desktop\Final-Project-Backend\Worldperfumluxurybackend\Worldperfumluxury\Views\Contact\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css""
      integrity=""sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh"" crossorigin=""anonymous"">
<link rel=""stylesheet"" href=""./assets/css/all.min.css"">
<!-- Product slider multi -->
<link rel=""stylesheet"" type=""text/css"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"">

<!-- ICONS FOR LINKS -->
<link rel=""stylesheet"" href=""https://use.fontawesome.com/releases/v5.2.0/css/all.css""
      integrity=""sha384-hWVjflwFxL6sNzntih27bfxkr27PmbbK/iSvJ+a4+0owXq79v+lsFkW54bOGbiDQ"" crossorigin=""anonymous"">

<link rel=""stylesheet"" href=""./assets/css/contact.css"">


<!-- CONTAT US START -->
<section class=""contact"">
    <div class=""content"">
        <h2>BİZİMLƏ ƏLAQƏ</h2>

    </div>
    <div class=""container"">
        <div class=""contactInfo"">
            <div class=""box"">
                <div class=""icon"">
                    <i class=""fa fa-map-marke");
            WriteLiteral(@"r"" aria-hidden=""true""></i>
                </div>
                <div class=""text"">
                    <h3>Address</h3>
                    <p><br>Baki, Azərbaycan</p>
                </div>
            </div>
            <div class=""box"">
                <div class=""icon"">
                    <i class=""fa fa-phone"" aria-hidden=""true""></i>
                </div>
                <div class=""text"">
                    <h3>Telefon</h3>
                    <p>055-317-66-85</p>
                </div>
            </div>
            <div class=""box"">
                <div class=""icon"">
                    <i class=""fas fa-envelope-square""></i>
                </div>
                <div class=""text"">
                    <h3>Email</h3>
                    <p>worldperfumluxury@gmail.com</p>
                </div>
            </div>
        </div>
        <div class=""contactForm"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2f9b48c3c410e1b1da5ac3274f4ec0469c60c1a10077", async() => {
                WriteLiteral("\r\n                <h2>Messaj göndərin</h2>\r\n                <div class=\"inputBox\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d2f9b48c3c410e1b1da5ac3274f4ec0469c60c1a10444", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 60 "C:\Users\dima-\Desktop\Final-Project-Backend\Worldperfumluxurybackend\Worldperfumluxury\Views\Contact\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.UserName);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    <span>İstifadəçi adiniz</span>\r\n                </div>\r\n                <div class=\"inputBox\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d2f9b48c3c410e1b1da5ac3274f4ec0469c60c1a12413", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 64 "C:\Users\dima-\Desktop\Final-Project-Backend\Worldperfumluxurybackend\Worldperfumluxury\Views\Contact\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Email);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    <span>Email</span>\r\n                </div>\r\n                <div class=\"inputBox\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d2f9b48c3c410e1b1da5ac3274f4ec0469c60c1a14367", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 68 "C:\Users\dima-\Desktop\Final-Project-Backend\Worldperfumluxurybackend\Worldperfumluxury\Views\Contact\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Phone);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    <span>Əlaqə nömrəniz</span>
                </div>
                <div class=""inputBox"">
                    <textarea required=""required""></textarea>
                    <span>Sizin messajiniz...</span>
                </div>
                <div class=""inputBox"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d2f9b48c3c410e1b1da5ac3274f4ec0469c60c1a16508", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </div>\r\n\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
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
</section>

<!-- MULTI PRODUCT SLIDER -->
<div class=""container mb-5"">
    <div class=""row mb-5"">
        <div class=""col-md-6 col-sm-6 col-xs-12"">

        </div>
        <div class=""col-md-6 col-sm-6 col-xs-6 hidden-xs"">
            <div class=""controls pull-right"">
                <a class=""left fa fa-chevron-left btn btn-info "" href=""#product-slider-bootstrap""
                   data-slide=""prev""></a><a class=""right fa fa-chevron-right btn btn-info""
                                            href=""#product-slider-bootstrap"" data-slide=""next""></a>
            </div>
        </div>
    </div>
    <div id=""product-slider-bootstrap"" class=""carousel slide hidden-xs"" data-ride=""carousel"" data-type=""multi"">
        <div class=""carousel-inner"">
            <div class=""item active"">
                <div class=""row"">
                    <div class=""col-md-3 col-sm-3 col-xs-12"">
                        <div class=""slider-item"">
                            <div cla");
            WriteLiteral(@"ss=""slider-image"">
                                <img src=""./assets/img/Kilians/Products/Kilian-rosesonice.jfif""
                                     class=""img-responsive"" alt=""a"" />
                            </div>
                            <div class=""slider-main-detail"">
                                <div class=""slider-detail"">
                                    <div class=""product-detail"">
                                        <h5>RosesOnice</h5>
                                        <h5 class=""detail-price"">340₼</h5>
                                    </div>
                                </div>
                                <div class=""cart-section"">
                                    <div class=""row"">
                                        <div class=""col-md-6 col-sm-12 col-xs-6 review"">
                                            <i class=""fa fa-star"" aria-hidden=""true""></i>
                                            <i class=""fa fa-star"" aria-hidden=""true""></i>
  ");
            WriteLiteral(@"                                          <i class=""fa fa-star"" aria-hidden=""true""></i>
                                            <i class=""fa fa-star-o"" aria-hidden=""true""></i>
                                            <i class=""fa fa-star-o"" aria-hidden=""true""></i>
                                        </div>
                                        <div class=""col-md-6 col-sm-12 col-xs-6"">
                                            <a href=""#"" class=""AddCart btn btn-info"">
                                                <i class=""fa fa-shopping-cart""
                                                   aria-hidden=""true""></i>Sifariş et
                                            </a>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""col-md-3 col-sm-3 col-xs-12"">
                        ");
            WriteLiteral(@"<div class=""slider-item"">
                            <div class=""slider-image"">
                                <img src=""./assets/img/parfums/Women/Products/rose31.jfif"" class=""img-responsive""
                                     alt=""a"" />
                            </div>
                            <div class=""slider-main-detail"">
                                <div class=""slider-detail"">
                                    <div class=""product-detail"">
                                        <h5>Rose31</h5>
                                        <h5 class=""detail-price"">450₼</h5>
                                    </div>
                                </div>
                                <div class=""cart-section"">
                                    <div class=""row"">
                                        <div class=""col-md-6 col-sm-12 col-xs-6 review"">
                                            <i class=""fa fa-star"" aria-hidden=""true""></i>
                                       ");
            WriteLiteral(@"     <i class=""fa fa-star"" aria-hidden=""true""></i>
                                            <i class=""fa fa-star"" aria-hidden=""true""></i>
                                            <i class=""fa fa-star-o"" aria-hidden=""true""></i>
                                            <i class=""fa fa-star-o"" aria-hidden=""true""></i>
                                        </div>
                                        <div class=""col-md-6 col-sm-12 col-xs-6"">
                                            <a href=""#"" class=""AddCart btn btn-info"">
                                                <i class=""fa fa-shopping-cart""
                                                   aria-hidden=""true""></i>Sifariş et
                                            </a>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""c");
            WriteLiteral(@"ol-md-3 col-sm-3 col-xs-12"">
                        <div class=""slider-item"">
                            <div class=""slider-image"">
                                <img src=""assets/img/parfums/Unisex/ArmaniPrive-Malachite.jfif""
                                     class=""img-responsive"" alt=""a"" />
                            </div>
                            <div class=""slider-main-detail"">
                                <div class=""slider-detail"">
                                    <div class=""product-detail"">
                                        <h5>Privé Rouge Malachite</h5>
                                        <h5 class=""detail-price"">320₼</h5>
                                    </div>
                                </div>
                                <div class=""cart-section"">
                                    <div class=""row"">
                                        <div class=""col-md-6 col-sm-12 col-xs-6 review"">
                                            <i class=""fa");
            WriteLiteral(@" fa-star"" aria-hidden=""true""></i>
                                            <i class=""fa fa-star"" aria-hidden=""true""></i>
                                            <i class=""fa fa-star"" aria-hidden=""true""></i>
                                            <i class=""fa fa-star-o"" aria-hidden=""true""></i>
                                            <i class=""fa fa-star-o"" aria-hidden=""true""></i>
                                        </div>
                                        <div class=""col-md-6 col-sm-12 col-xs-6"">
                                            <a href=""#"" class=""AddCart btn btn-info"">
                                                <i class=""fa fa-shopping-cart""
                                                   aria-hidden=""true""></i> Sifariş et
                                            </a>
                                        </div>
                                    </div>
                                </div>
                            </div>
                  ");
            WriteLiteral(@"      </div>
                    </div>
                    <div class=""col-md-3 col-sm-3 col-xs-12"">
                        <div class=""slider-item"">
                            <div class=""slider-image"">
                                <img src=""./assets/img/parfums/Women/Products/mixed-emotions.jfif""
                                     class=""img-responsive"" alt=""a"" />
                            </div>
                            <div class=""slider-main-detail"">
                                <div class=""slider-detail"">
                                    <div class=""product-detail"">
                                        <h5>Mixed Emotions</h5>
                                        <h5 class=""detail-price"">270₼</h5>
                                    </div>
                                </div>
                                <div class=""cart-section"">
                                    <div class=""row"">
                                        <div class=""col-md-6 col-sm-12 col-");
            WriteLiteral(@"xs-6 review"">
                                            <i class=""fa fa-star"" aria-hidden=""true""></i>
                                            <i class=""fa fa-star"" aria-hidden=""true""></i>
                                            <i class=""fa fa-star"" aria-hidden=""true""></i>
                                            <i class=""fa fa-star-o"" aria-hidden=""true""></i>
                                            <i class=""fa fa-star-o"" aria-hidden=""true""></i>
                                        </div>
                                        <div class=""col-md-6 col-sm-12 col-xs-6"">
                                            <a href=""#"" class=""AddCart btn btn-info"">
                                                <i class=""fa fa-shopping-cart""
                                                   aria-hidden=""true""></i> Sifariş et
                                            </a>
                                        </div>
                                    </div>
                       ");
            WriteLiteral(@"         </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""item"">
                <div class=""row"">
                    <div class=""col-md-3 col-sm-3 col-xs-12"">
                        <div class=""slider-item"">
                            <div class=""slider-image"">
                                <img src=""./assets/img/parfums/Women/Products/Myway-intense.jfif""
                                     class=""img-responsive"" alt=""a"" />
                            </div>
                            <div class=""slider-main-detail"">
                                <div class=""slider-detail"">
                                    <div class=""product-detail"">
                                        <h5>My way intense</h5>
                                        <h5 class=""detail-price"">180₼</h5>
                                    </div>
                                </div>
         ");
            WriteLiteral(@"                       <div class=""cart-section"">
                                    <div class=""row"">
                                        <div class=""col-md-6 col-sm-12 col-xs-6 review"">
                                            <i class=""fa fa-star"" aria-hidden=""true""></i>
                                            <i class=""fa fa-star"" aria-hidden=""true""></i>
                                            <i class=""fa fa-star"" aria-hidden=""true""></i>
                                            <i class=""fa fa-star-o"" aria-hidden=""true""></i>
                                            <i class=""fa fa-star-o"" aria-hidden=""true""></i>
                                        </div>
                                        <div class=""col-md-6 col-sm-12 col-xs-6"">
                                            <a href=""#"" class=""AddCart btn btn-info"">
                                                <i class=""fa fa-shopping-cart""
                                                   aria-hidden=""true""><");
            WriteLiteral(@"/i>Sifariş et
                                            </a>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""col-md-3 col-sm-3 col-xs-12"">
                        <div class=""slider-item"">
                            <div class=""slider-image"">
                                <img src=""./assets/img/Kilians/Products/VodkaRocks.jfif"" class=""img-responsive""
                                     alt=""a"" />
                            </div>
                            <div class=""slider-main-detail"">
                                <div class=""slider-detail"">
                                    <div class=""product-detail"">
                                        <h5>Vodka on the Rocks</h5>
                                        <h5 class=""detail-price"">520₼</h5>
                             ");
            WriteLiteral(@"       </div>
                                </div>
                                <div class=""cart-section"">
                                    <div class=""row"">
                                        <div class=""col-md-6 col-sm-12 col-xs-6 review"">
                                            <i class=""fa fa-star"" aria-hidden=""true""></i>
                                            <i class=""fa fa-star"" aria-hidden=""true""></i>
                                            <i class=""fa fa-star"" aria-hidden=""true""></i>
                                            <i class=""fa fa-star-o"" aria-hidden=""true""></i>
                                            <i class=""fa fa-star-o"" aria-hidden=""true""></i>
                                        </div>
                                        <div class=""col-md-6 col-sm-12 col-xs-6"">
                                            <a href=""#"" class=""AddCart btn btn-info"">
                                                <i class=""fa fa-shopping-cart""
       ");
            WriteLiteral(@"                                            aria-hidden=""true""></i> Sifariş et
                                            </a>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""col-md-3 col-sm-3 col-xs-12"">
                        <div class=""slider-item"">
                            <div class=""slider-image"">
                                <img src=""./assets/img/Kilians/Products/Kilian-A kiss.jfif"" class=""img-responsive""
                                     alt=""a"" />
                            </div>
                            <div class=""slider-main-detail"">
                                <div class=""slider-detail"">
                                    <div class=""product-detail"">
                                        <h5>A Kiss From A Rose</h5>
                                     ");
            WriteLiteral(@"   <h5 class=""detail-price"">550₼</h5>
                                    </div>
                                </div>
                                <div class=""cart-section"">
                                    <div class=""row"">
                                        <div class=""col-md-6 col-sm-12 col-xs-6 review"">
                                            <i class=""fa fa-star"" aria-hidden=""true""></i>
                                            <i class=""fa fa-star"" aria-hidden=""true""></i>
                                            <i class=""fa fa-star"" aria-hidden=""true""></i>
                                            <i class=""fa fa-star-o"" aria-hidden=""true""></i>
                                            <i class=""fa fa-star-o"" aria-hidden=""true""></i>
                                        </div>
                                        <div class=""col-md-6 col-sm-12 col-xs-6"">
                                            <a href=""#"" class=""AddCart btn btn-info"">
                   ");
            WriteLiteral(@"                             <i class=""fa fa-shopping-cart""
                                                   aria-hidden=""true""></i> Sifariş et
                                            </a>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""col-md-3 col-sm-3 col-xs-12"">
                        <div class=""slider-item"">
                            <div class=""slider-image"">
                                <img src=""./assets/img/parfums/Women/Products/gucci-bloom.jfif""
                                     class=""img-responsive"" alt=""a"" />
                            </div>
                            <div class=""slider-main-detail"">
                                <div class=""slider-detail"">
                                    <div class=""product-detail"">
                                  ");
            WriteLiteral(@"      <h5>Gucci bloom</h5>
                                        <h5 class=""detail-price"">150₼</h5>
                                    </div>
                                </div>
                                <div class=""cart-section"">
                                    <div class=""row"">
                                        <div class=""col-md-6 col-sm-12 col-xs-6 review"">
                                            <i class=""fa fa-star"" aria-hidden=""true""></i>
                                            <i class=""fa fa-star"" aria-hidden=""true""></i>
                                            <i class=""fa fa-star"" aria-hidden=""true""></i>
                                            <i class=""fa fa-star-o"" aria-hidden=""true""></i>
                                            <i class=""fa fa-star-o"" aria-hidden=""true""></i>
                                        </div>
                                        <div class=""col-md-6 col-sm-12 col-xs-6"">
                                         ");
            WriteLiteral(@"   <a href=""#"" class=""AddCart btn btn-info"">
                                                <i class=""fa fa-shopping-cart""
                                                   aria-hidden=""true""></i>Sifariş et
                                            </a>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>


<!-- Product slider multi -->
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/owl-carousel/1.3.3/owl.carousel.js""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/owl-carousel/1.3.3/owl.theme.min.css""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/owl-carousel/1.3.3/owl.carousel.css""></script>
<script src=""https://maxcdn.b");
            WriteLiteral("ootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js\"></script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ContactVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
