#pragma checksum "C:\Users\dima-\Desktop\Final-Project-Backend\Worldperfumluxurybackend\Worldperfumluxury\Views\Wishlist\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1fcbe6cff68479c19e43de33002e7b421f7366a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Wishlist_Index), @"mvc.1.0.view", @"/Views/Wishlist/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fcbe6cff68479c19e43de33002e7b421f7366a6", @"/Views/Wishlist/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cb96e96330129b805c4e65075114610263929bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Wishlist_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\dima-\Desktop\Final-Project-Backend\Worldperfumluxurybackend\Worldperfumluxury\Views\Wishlist\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<link href=""//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css"" rel=""stylesheet"" id=""bootstrap-css"">
<link rel=""stylesheet"" href=""./assets/css/wishlist.css"">

<div class=""cart-wrap"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""main-heading mb-10"">Mənim Sevimlilərim</div>
                <div class=""table-wishlist"">
                    <table cellpadding=""0"" cellspacing=""0"" border=""0"" width=""100%"">
                        <thead>
                            <tr>
                                <th width=""45%"">Məhsulun adi</th>
                                <th width=""15%"">Qiyməti</th>
                                <th width=""15%"">Stok Statusu</th>
                                <th width=""15%""></th>
                                <th width=""10%""></th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                 ");
            WriteLiteral(@"               <td width=""45%"">
                                    <div class=""display-flex align-center"">
                                        <div class=""img-product"">
                                            <img src=""./assets/img/parfums/Women/Products/DeMarly-Oriana.jfif""");
            BeginWriteAttribute("alt", " alt=\"", 1401, "\"", 1407, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""mCS_img_loaded"">
                                        </div>
                                        <div class=""name-product"">
                                            Oriana
                                        </div>
                                    </div>
                                </td>
                                <td width=""15%"" class=""price""style=""font-size:2.9370rem"">340₼</td>
                                <td width=""15%""><span class=""in-stock-box"">Stokda</span></td>
                                <td width=""15%""><button class=""round-black-btn small-btn"">Sifariş et</button></td>
                                <td width=""10%"" class=""text-center""><a href=""#"" class=""trash-icon""><i class=""far fa-trash-alt""></i></a></td>
                            </tr>
                            <tr>
                                <td width=""45%"">
                                    <div class=""display-flex align-center"">
                                        <div class");
            WriteLiteral("=\"img-product\">\r\n                                            <img src=\"./assets/img/Kilians/Products/KILIANSHARE.jfif\"");
            BeginWriteAttribute("alt", " alt=\"", 2550, "\"", 2556, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""mCS_img_loaded"">
                                        </div>
                                        <div class=""name-product"">
                                            Angel Share
                                        </div>
                                    </div>
                                </td>
                                <td width=""15%"" class=""price"" style=""font-size:2.9370rem"">350₼</td>
                                <td width=""15%""><span class=""in-stock-box"">Stokda </span></td>
                                <td width=""15%""><button class=""round-black-btn small-btn"">Sifariş et</button></td>
                                <td width=""10%"" class=""text-center""><a href=""#"" class=""trash-icon""><i class=""far fa-trash-alt""></i></a></td>
                            </tr>
                            <tr>
                                <td width=""45%"">
                                    <div class=""display-flex align-center"">
                                        <di");
            WriteLiteral("v class=\"img-product\">\r\n                                            <img src=\"./assets/img/parfums/Men/CreedAventus.jfif\"");
            BeginWriteAttribute("alt", " alt=\"", 3702, "\"", 3708, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""mCS_img_loaded"">
                                        </div>
                                        <div class=""name-product"">
                                            Creed Aventus
                                        </div>
                                    </div>
                                </td>
                                <td width=""15%"" class=""price""style=""font-size:2.9370rem"">200₼</td>
                                <td width=""15%""><span class=""in-stock-box"">Stokda</span></td>
                                <td width=""15%""><button class=""round-black-btn small-btn"">Sifariş et</button></td>
                                <td width=""10%"" class=""text-center""><a href=""#"" class=""trash-icon""><i class=""far fa-trash-alt""></i></a></td>
                            </tr>
                        </tbody>
                    </table>
                </div>
            </div>
        </div>
    </div>
</div>


<script src=""//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/j");
            WriteLiteral("s/bootstrap.min.js\"></script>\r\n<script src=\"//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js\"></script>\r\n\r\n");
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
