#pragma checksum "C:\Users\GhostX\Desktop\c#Projects\FreelanceV2\Views\Home\AnnounmentInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17e9171961c6608b4fead93770d40e09069bf0ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AnnounmentInfo), @"mvc.1.0.view", @"/Views/Home/AnnounmentInfo.cshtml")]
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
#line 1 "C:\Users\GhostX\Desktop\c#Projects\FreelanceV2\Views\_ViewImports.cshtml"
using FreelanceV2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\GhostX\Desktop\c#Projects\FreelanceV2\Views\_ViewImports.cshtml"
using FreelanceV2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17e9171961c6608b4fead93770d40e09069bf0ae", @"/Views/Home/AnnounmentInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05f013d677ab8b215f1d0d92f862afc5b57f6d23", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AnnounmentInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FreelanceV2.Models.Announcemants>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\GhostX\Desktop\c#Projects\FreelanceV2\Views\Home\AnnounmentInfo.cshtml"
  
    ViewData["Title"] = "Подробнее";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"CenterForm\">\r\n    <div class=\"form-group text-center\">\r\n        <h2>");
#nullable restore
#line 8 "C:\Users\GhostX\Desktop\c#Projects\FreelanceV2\Views\Home\AnnounmentInfo.cshtml"
       Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <p>");
#nullable restore
#line 11 "C:\Users\GhostX\Desktop\c#Projects\FreelanceV2\Views\Home\AnnounmentInfo.cshtml"
      Write(Model.FullDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <i>");
#nullable restore
#line 14 "C:\Users\GhostX\Desktop\c#Projects\FreelanceV2\Views\Home\AnnounmentInfo.cshtml"
      Write(Model.MinWage);

#line default
#line hidden
#nullable disable
            WriteLiteral("-");
#nullable restore
#line 14 "C:\Users\GhostX\Desktop\c#Projects\FreelanceV2\Views\Home\AnnounmentInfo.cshtml"
                     Write(Model.MaxWage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i>\r\n        <i>");
#nullable restore
#line 15 "C:\Users\GhostX\Desktop\c#Projects\FreelanceV2\Views\Home\AnnounmentInfo.cshtml"
      Write(Model.Binds.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i>\r\n    </div>\r\n    <div>\r\n        <a>Оставить заявку</a>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FreelanceV2.Models.Announcemants> Html { get; private set; }
    }
}
#pragma warning restore 1591