#pragma checksum "C:\Users\GhostX\Desktop\c#Projects\FreelanceV2\Areas\Orderer\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62ce9ef3506238df3d446a8765a2f267b1560c8f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Orderer_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Orderer/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\GhostX\Desktop\c#Projects\FreelanceV2\Areas\Orderer\Views\_ViewImports.cshtml"
using FreelanceV2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\GhostX\Desktop\c#Projects\FreelanceV2\Areas\Orderer\Views\_ViewImports.cshtml"
using FreelanceV2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62ce9ef3506238df3d446a8765a2f267b1560c8f", @"/Areas/Orderer/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05f013d677ab8b215f1d0d92f862afc5b57f6d23", @"/Areas/Orderer/Views/_ViewImports.cshtml")]
    public class Areas_Orderer_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<FreelanceV2.Models.Announcemants>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AnnounmentInfo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-dark nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\GhostX\Desktop\c#Projects\FreelanceV2\Areas\Orderer\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Мои объявления";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"CenterForm\">\r\n");
#nullable restore
#line 7 "C:\Users\GhostX\Desktop\c#Projects\FreelanceV2\Areas\Orderer\Views\Home\Index.cshtml"
     foreach(var a in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62ce9ef3506238df3d446a8765a2f267b1560c8f4638", async() => {
                WriteLiteral(@"
            <div class=""card border-left-success shadow h-100 py-2"">
                <div class=""card-body"">
                    <div class=""row no-gutters align-items-lg-center"">
                        <div class=""col mr-2"">
                            <div class=""text-xs font-weight-bold text-uppercase mb-1"">
                                <h3>");
#nullable restore
#line 15 "C:\Users\GhostX\Desktop\c#Projects\FreelanceV2\Areas\Orderer\Views\Home\Index.cshtml"
                               Write(a.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n                            </div>\r\n                            <div class=\"h5 mb-0 font-weight-bold text-gray-800\">\r\n                                <h5>");
#nullable restore
#line 18 "C:\Users\GhostX\Desktop\c#Projects\FreelanceV2\Areas\Orderer\Views\Home\Index.cshtml"
                               Write(a.WageType.WageType);

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\GhostX\Desktop\c#Projects\FreelanceV2\Areas\Orderer\Views\Home\Index.cshtml"
                                                   Write(a.MinWage);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n                                <h5>");
#nullable restore
#line 19 "C:\Users\GhostX\Desktop\c#Projects\FreelanceV2\Areas\Orderer\Views\Home\Index.cshtml"
                               Write(a.Binds.Count);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 26 "C:\Users\GhostX\Desktop\c#Projects\FreelanceV2\Areas\Orderer\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<FreelanceV2.Models.Announcemants>> Html { get; private set; }
    }
}
#pragma warning restore 1591
