#pragma checksum "C:\Users\Pc\Documents\GitHub\practiceASPCoreMVC\MoviesProjectMini\MoviesProjectMini\Views\Home\components\MovieSummary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d56f05e2d4ed70c7d0e87e78b205cbddd75f6fe5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_components_MovieSummary), @"mvc.1.0.view", @"/Views/Home/components/MovieSummary.cshtml")]
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
#line 1 "C:\Users\Pc\Documents\GitHub\practiceASPCoreMVC\MoviesProjectMini\MoviesProjectMini\Views\_ViewImports.cshtml"
using MoviesProjectMini;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Pc\Documents\GitHub\practiceASPCoreMVC\MoviesProjectMini\MoviesProjectMini\Views\_ViewImports.cshtml"
using MoviesProjectMini.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Pc\Documents\GitHub\practiceASPCoreMVC\MoviesProjectMini\MoviesProjectMini\Views\_ViewImports.cshtml"
using MoviesProjectMini.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d56f05e2d4ed70c7d0e87e78b205cbddd75f6fe5", @"/Views/Home/components/MovieSummary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c141b2f67c0071d83a432ec8334d3b7cb545e3c1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_components_MovieSummary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Movie>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div class=\"col-6 col-sm-6 col-md-4 p-4 mb-4 movie--item\">\n    <div class=\"card\">\n        <iframe");
            BeginWriteAttribute("src", " src=\"", 111, "\"", 128, 1);
#nullable restore
#line 5 "C:\Users\Pc\Documents\GitHub\practiceASPCoreMVC\MoviesProjectMini\MoviesProjectMini\Views\Home\components\MovieSummary.cshtml"
WriteAttributeValue("", 117, Model.link, 117, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write;\n                encrypted-media; gyroscope; picture-in-picture\" allowfullscreen></iframe>\n        <div class=\"card-body\">\n            <h6 class=\"card-title box-title\">");
#nullable restore
#line 8 "C:\Users\Pc\Documents\GitHub\practiceASPCoreMVC\MoviesProjectMini\MoviesProjectMini\Views\Home\components\MovieSummary.cshtml"
                                        Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" | <span>");
#nullable restore
#line 8 "C:\Users\Pc\Documents\GitHub\practiceASPCoreMVC\MoviesProjectMini\MoviesProjectMini\Views\Home\components\MovieSummary.cshtml"
                                                            Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h6>\n            <p class=\"card-text\"><a");
            BeginWriteAttribute("href", " href=", 442, "", 459, 1);
#nullable restore
#line 9 "C:\Users\Pc\Documents\GitHub\practiceASPCoreMVC\MoviesProjectMini\MoviesProjectMini\Views\Home\components\MovieSummary.cshtml"
WriteAttributeValue("", 448, Model.link, 448, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">View Now</a></p>\n            <p>");
#nullable restore
#line 10 "C:\Users\Pc\Documents\GitHub\practiceASPCoreMVC\MoviesProjectMini\MoviesProjectMini\Views\Home\components\MovieSummary.cshtml"
          Write(Model.Views);

#line default
#line hidden
#nullable disable
            WriteLiteral(" vies • ");
#nullable restore
#line 10 "C:\Users\Pc\Documents\GitHub\practiceASPCoreMVC\MoviesProjectMini\MoviesProjectMini\Views\Home\components\MovieSummary.cshtml"
                              Write(Model.Time);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n            <p>");
#nullable restore
#line 11 "C:\Users\Pc\Documents\GitHub\practiceASPCoreMVC\MoviesProjectMini\MoviesProjectMini\Views\Home\components\MovieSummary.cshtml"
          Write(Model.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Movie> Html { get; private set; }
    }
}
#pragma warning restore 1591