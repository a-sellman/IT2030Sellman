#pragma checksum "C:\Users\april\Source\Repos\a-sellman\IT2030Sellman\6-1\6-1\Views\Home\BootStrap.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b836be2c69ae6187c52d0a709394b86473e8443"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_BootStrap), @"mvc.1.0.view", @"/Views/Home/BootStrap.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b836be2c69ae6187c52d0a709394b86473e8443", @"/Views/Home/BootStrap.cshtml")]
    public class Views_Home_BootStrap : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\april\Source\Repos\a-sellman\IT2030Sellman\6-1\6-1\Views\Home\BootStrap.cshtml"
  
    ViewData["Title"] = "BootStrap";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!DOCTYPE html>
<html>
<style>

    .jumbotron {
        background-color: teal;
        color: white;
        text-align: center;
        font-size: 1.5rem;
        margin-left: 25px;
        margin-right: 25px;
        margin-top: 25px;
    }

    ul {
        list-style-type: none;
        margin-left: 200px;
        margin-top: 20px;
        padding: 0;
        overflow: hidden;
    }

    li {
        float: left;
    }

        li a {
            font-size: 20px;
            color: black;
            text-align: center;
            padding: 14px 16px;
            text-decoration: none;
        }

    /* Vertical NavBar*/
</style>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b836be2c69ae6187c52d0a709394b86473e84433455", async() => {
                WriteLiteral("\r\n    <div class=\"jumbotron vertical col-sm-8 col-md-10 col-lg-12\">\r\n        <br />\r\n        <h1>Frequently Asked Questions</h1>\r\n        <br />\r\n    </div>\r\n\r\n    <form id=\"form1\" runat=\"server\">\r\n        <ul>\r\n            <li>");
#nullable restore
#line 50 "C:\Users\april\Source\Repos\a-sellman\IT2030Sellman\6-1\6-1\Views\Home\BootStrap.cshtml"
           Write(Html.ActionLink("All FAQ's", "Index"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n            <li>");
#nullable restore
#line 51 "C:\Users\april\Source\Repos\a-sellman\IT2030Sellman\6-1\6-1\Views\Home\BootStrap.cshtml"
           Write(Html.ActionLink("C#", "Csharp"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n            <li>");
#nullable restore
#line 52 "C:\Users\april\Source\Repos\a-sellman\IT2030Sellman\6-1\6-1\Views\Home\BootStrap.cshtml"
           Write(Html.ActionLink("Bootstrap", "BootStrap"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n            <li>");
#nullable restore
#line 53 "C:\Users\april\Source\Repos\a-sellman\IT2030Sellman\6-1\6-1\Views\Home\BootStrap.cshtml"
           Write(Html.ActionLink("Javascript", "JavaScript"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n        </ul>\r\n    </form>\r\n    <br />\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
