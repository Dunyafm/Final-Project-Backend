#pragma checksum "C:\Users\dima-\Desktop\Final-Project-Backend\Worldperfumluxurybackend\Worldperfumluxury\Views\Shared\Components\Productmulti\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a329c9ac674fea6157b37bb50322687c1aed93f3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Productmulti_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Productmulti/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a329c9ac674fea6157b37bb50322687c1aed93f3", @"/Views/Shared/Components/Productmulti/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09b22c607b108b053d9d34d5745529e6fd945f7f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Productmulti_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Productmulti>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\dima-\Desktop\Final-Project-Backend\Worldperfumluxurybackend\Worldperfumluxury\Views\Shared\Components\Productmulti\Default.cshtml"
 foreach (var productmulti in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-md-3 col-sm-3 col-xs-12\">\r\n        <div class=\"slider-item\">\r\n            <div class=\"slider-image\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 212, "\"", 267, 2);
            WriteAttributeValue("", 218, "./assets/img/Kilians/Products/", 218, 30, true);
#nullable restore
#line 8 "C:\Users\dima-\Desktop\Final-Project-Backend\Worldperfumluxurybackend\Worldperfumluxury\Views\Shared\Components\Productmulti\Default.cshtml"
WriteAttributeValue("", 248, productmulti.Image, 248, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                     class=\"img-responsive\" alt=\"a\" />\r\n            </div>\r\n            <div class=\"slider-main-detail\">\r\n                <div class=\"slider-detail\">\r\n                    <div class=\"product-detail\">\r\n                        <h5>");
#nullable restore
#line 14 "C:\Users\dima-\Desktop\Final-Project-Backend\Worldperfumluxurybackend\Worldperfumluxury\Views\Shared\Components\Productmulti\Default.cshtml"
                       Write(productmulti.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <h5");
            BeginWriteAttribute("class", " class=", 567, "", 593, 1);
#nullable restore
#line 15 "C:\Users\dima-\Desktop\Final-Project-Backend\Worldperfumluxurybackend\Worldperfumluxury\Views\Shared\Components\Productmulti\Default.cshtml"
WriteAttributeValue("", 574, productmulti.Price, 574, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">340₼</h5>
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
                                <i class=""fa fa-shopping-cart""
                                   aria-hidden=""true""></i> Sifariş et
                            </a>
                        </div>
                    </div>
                </div>
 ");
            WriteLiteral("           </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 38 "C:\Users\dima-\Desktop\Final-Project-Backend\Worldperfumluxurybackend\Worldperfumluxury\Views\Shared\Components\Productmulti\Default.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Productmulti>> Html { get; private set; }
    }
}
#pragma warning restore 1591