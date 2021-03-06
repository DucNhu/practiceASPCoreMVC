#pragma checksum "C:\Users\Pc\Documents\GitHub\practiceASPCoreMVC\MoviesProjectMini\MoviesProjectMini\Pages\Cart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e75c39ab52342801dbf2ac4e5cf7b351c0ec1a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MoviesProjectMini.Pages.Pages_Cart), @"mvc.1.0.razor-page", @"/Pages/Cart.cshtml")]
namespace MoviesProjectMini.Pages
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
#line 2 "C:\Users\Pc\Documents\GitHub\practiceASPCoreMVC\MoviesProjectMini\MoviesProjectMini\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.RazorPages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Pc\Documents\GitHub\practiceASPCoreMVC\MoviesProjectMini\MoviesProjectMini\Pages\_ViewImports.cshtml"
using MoviesProjectMini.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Pc\Documents\GitHub\practiceASPCoreMVC\MoviesProjectMini\MoviesProjectMini\Pages\_ViewImports.cshtml"
using MoviesProjectMini.Infrastructure;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e75c39ab52342801dbf2ac4e5cf7b351c0ec1a1", @"/Pages/Cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85b023863d5e2c5ecc148eae86bc70cecb67b710", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Cart : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"    <table class=""table table-bordered table-striped"">
        <thead>
            <tr>
                <th>Quantity</th>
                <th>Item</th>
                <th class=""text-right"">Price</th>
                <th class=""text-right"">Subtotal</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 13 "C:\Users\Pc\Documents\GitHub\practiceASPCoreMVC\MoviesProjectMini\MoviesProjectMini\Pages\Cart.cshtml"
             foreach (var line in Model.Cart.Lines)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td class=\"text-center\">");
#nullable restore
#line 16 "C:\Users\Pc\Documents\GitHub\practiceASPCoreMVC\MoviesProjectMini\MoviesProjectMini\Pages\Cart.cshtml"
                                       Write(line.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"text-left\">");
#nullable restore
#line 17 "C:\Users\Pc\Documents\GitHub\practiceASPCoreMVC\MoviesProjectMini\MoviesProjectMini\Pages\Cart.cshtml"
                                     Write(line.Movie.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"text-right\">");
#nullable restore
#line 18 "C:\Users\Pc\Documents\GitHub\practiceASPCoreMVC\MoviesProjectMini\MoviesProjectMini\Pages\Cart.cshtml"
                                      Write(line.Movie.price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"text-right\">");
#nullable restore
#line 19 "C:\Users\Pc\Documents\GitHub\practiceASPCoreMVC\MoviesProjectMini\MoviesProjectMini\Pages\Cart.cshtml"
                                       Write((line.Quantity*line.Movie.price).ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 21 "C:\Users\Pc\Documents\GitHub\practiceASPCoreMVC\MoviesProjectMini\MoviesProjectMini\Pages\Cart.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n        <tfoot>\r\n            <tr>\r\n                <td colspan=\"3\" class=\"text-right\">Total: </td>\r\n                <td class=\"text-right\">");
#nullable restore
#line 26 "C:\Users\Pc\Documents\GitHub\practiceASPCoreMVC\MoviesProjectMini\MoviesProjectMini\Pages\Cart.cshtml"
                                  Write(Model.Cart.ComputeTotalValue().ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n        </tfoot>\r\n    </table>\r\n    <div class=\"text-center\">\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 1104, "\"", 1127, 1);
#nullable restore
#line 31 "C:\Users\Pc\Documents\GitHub\practiceASPCoreMVC\MoviesProjectMini\MoviesProjectMini\Pages\Cart.cshtml"
WriteAttributeValue("", 1111, Model.ReturnUrl, 1111, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Continue shopping</a>\r\n    </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MoviesProjectMini.Pages.CartModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MoviesProjectMini.Pages.CartModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MoviesProjectMini.Pages.CartModel>)PageContext?.ViewData;
        public MoviesProjectMini.Pages.CartModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
