#pragma checksum "C:\Users\bboys\Desktop\KLOVE_Mando\KLOVE_Mando\Views\Home\Favorites.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "539946fd3b1f58f1a924d304ea733af129de1bc5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Favorites), @"mvc.1.0.view", @"/Views/Home/Favorites.cshtml")]
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
#line 1 "C:\Users\bboys\Desktop\KLOVE_Mando\KLOVE_Mando\Views\_ViewImports.cshtml"
using KLOVE_Mando;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\bboys\Desktop\KLOVE_Mando\KLOVE_Mando\Views\_ViewImports.cshtml"
using KLOVE_Mando.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"539946fd3b1f58f1a924d304ea733af129de1bc5", @"/Views/Home/Favorites.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75f90e5f79aea5c4f615fda7af93f3f519f8dfc3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Favorites : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Verse>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\bboys\Desktop\KLOVE_Mando\KLOVE_Mando\Views\Home\Favorites.cshtml"
  
    ViewData["Title"] = "My Favorites";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 5 "C:\Users\bboys\Desktop\KLOVE_Mando\KLOVE_Mando\Views\Home\Favorites.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n");
#nullable restore
#line 7 "C:\Users\bboys\Desktop\KLOVE_Mando\KLOVE_Mando\Views\Home\Favorites.cshtml"
 if (Model.Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\" style=\"margin-top:20px;\">\r\n\r\n");
#nullable restore
#line 11 "C:\Users\bboys\Desktop\KLOVE_Mando\KLOVE_Mando\Views\Home\Favorites.cshtml"
         foreach (var verse in Model)
        {
            string animation = "card animate__animated animate__fadeInUp";


#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-sm-6 col-lg-4\">\r\n                <div");
            BeginWriteAttribute("class", " class=\"", 368, "\"", 386, 1);
#nullable restore
#line 16 "C:\Users\bboys\Desktop\KLOVE_Mando\KLOVE_Mando\Views\Home\Favorites.cshtml"
WriteAttributeValue("", 376, animation, 376, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width: 22rem; margin:5px;\">\r\n                    <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 469, "\"", 491, 1);
#nullable restore
#line 17 "C:\Users\bboys\Desktop\KLOVE_Mando\KLOVE_Mando\Views\Home\Favorites.cshtml"
WriteAttributeValue("", 475, verse.ImageLink, 475, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 492, "\"", 518, 1);
#nullable restore
#line 17 "C:\Users\bboys\Desktop\KLOVE_Mando\KLOVE_Mando\Views\Home\Favorites.cshtml"
WriteAttributeValue("", 498, verse.ReferenceText, 498, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <div class=\"card-body\">\r\n                        <h5 class=\"card-title\">");
#nullable restore
#line 19 "C:\Users\bboys\Desktop\KLOVE_Mando\KLOVE_Mando\Views\Home\Favorites.cshtml"
                                          Write(verse.ReferenceText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <p class=\"card-text\" style=\"max-height:250px;\">");
#nullable restore
#line 20 "C:\Users\bboys\Desktop\KLOVE_Mando\KLOVE_Mando\Views\Home\Favorites.cshtml"
                                                                  Write(verse.VerseText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 760, "\"", 792, 1);
#nullable restore
#line 21 "C:\Users\bboys\Desktop\KLOVE_Mando\KLOVE_Mando\Views\Home\Favorites.cshtml"
WriteAttributeValue("", 767, verse.BibleReferenceLink, 767, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-warning\" target=\"_blank\">NTL Read</a>\r\n\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 884, "\"", 934, 1);
#nullable restore
#line 23 "C:\Users\bboys\Desktop\KLOVE_Mando\KLOVE_Mando\Views\Home\Favorites.cshtml"
WriteAttributeValue("", 891, verse.getSocialLink(Verse.Social.FACEBOOK), 891, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"fa fa-facebook social\" target=\"_blank\"></a>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1014, "\"", 1063, 1);
#nullable restore
#line 24 "C:\Users\bboys\Desktop\KLOVE_Mando\KLOVE_Mando\Views\Home\Favorites.cshtml"
WriteAttributeValue("", 1021, verse.getSocialLink(Verse.Social.TWITTER), 1021, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"fa fa-twitter social\" target=\"_blank\"></a>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1142, "\"", 1193, 1);
#nullable restore
#line 25 "C:\Users\bboys\Desktop\KLOVE_Mando\KLOVE_Mando\Views\Home\Favorites.cshtml"
WriteAttributeValue("", 1149, verse.getSocialLink(Verse.Social.PINTEREST), 1149, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"fa fa-pinterest social\" target=\"_blank\"></a>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 29 "C:\Users\bboys\Desktop\KLOVE_Mando\KLOVE_Mando\Views\Home\Favorites.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 32 "C:\Users\bboys\Desktop\KLOVE_Mando\KLOVE_Mando\Views\Home\Favorites.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Verse>> Html { get; private set; }
    }
}
#pragma warning restore 1591
