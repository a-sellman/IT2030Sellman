#pragma checksum "C:\Users\april\source\repos\a-sellman\IT2030Sellman\6-1\6-1\Views\Home\General.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4132308595c4fea097b59708677e06b935c6b53d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_General), @"mvc.1.0.view", @"/Views/Home/General.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4132308595c4fea097b59708677e06b935c6b53d", @"/Views/Home/General.cshtml")]
    public class Views_Home_General : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\april\source\repos\a-sellman\IT2030Sellman\6-1\6-1\Views\Home\General.cshtml"
  
    ViewData["Title"] = "Home Page";


#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4132308595c4fea097b59708677e06b935c6b53d2970", async() => {
                WriteLiteral(@"

    <style>

        h3 {
            margin-left: 200px;
            margin-top: 25px;
        }

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

        .vertical-menu {
            width: 200px; /* Set a width if you like */
        }

            .vertical-menu a {
                background-color: #eee; /*");
                WriteLiteral(@" Grey background color */
                color: black; /* Black text color */
                display: block; /* Make the links appear below each other */
                padding: 12px; /* Add some padding */
                text-decoration: none; /* Remove underline from links */
            }

                .vertical-menu a:hover {
                    background-color: #ccc; /* Dark grey background on mouse-over */
                }

                .vertical-menu a.active {
                    background-color: #4CAF50; /* Add a green color to the ""active/current"" link */
                    color: white;
                }

        .stylish {
            text-align: left;
            margin-left: 230px;
            margin-top: 5px;
            margin-bottom: 5px;
        }
    </style>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4132308595c4fea097b59708677e06b935c6b53d5821", async() => {
                WriteLiteral("\r\n\r\n    <div class=\"jumbotron vertical col-sm-8 col-md-10 col-lg-12\">\r\n        <br />\r\n        <h1>Frequently Asked Questions</h1>\r\n        <br />\r\n    </div>\r\n    <form id=\"form1\" runat=\"server\">\r\n        <ul>\r\n            <li>");
#nullable restore
#line 93 "C:\Users\april\source\repos\a-sellman\IT2030Sellman\6-1\6-1\Views\Home\General.cshtml"
           Write(Html.ActionLink("All FAQ's", "Index"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n            <li>");
#nullable restore
#line 94 "C:\Users\april\source\repos\a-sellman\IT2030Sellman\6-1\6-1\Views\Home\General.cshtml"
           Write(Html.ActionLink("C#", "Csharp"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n            <li>");
#nullable restore
#line 95 "C:\Users\april\source\repos\a-sellman\IT2030Sellman\6-1\6-1\Views\Home\General.cshtml"
           Write(Html.ActionLink("Bootstrap", "BootStrap"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n            <li>");
#nullable restore
#line 96 "C:\Users\april\source\repos\a-sellman\IT2030Sellman\6-1\6-1\Views\Home\General.cshtml"
           Write(Html.ActionLink("Javascript", "JavaScript"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n        </ul>\r\n    </form>\r\n\r\n    <div class=\"vertical-menu col-sm-8 col-md-10 col-lg-12\">\r\n        ");
#nullable restore
#line 101 "C:\Users\april\source\repos\a-sellman\IT2030Sellman\6-1\6-1\Views\Home\General.cshtml"
   Write(Html.ActionLink("General", "General"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
#nullable restore
#line 102 "C:\Users\april\source\repos\a-sellman\IT2030Sellman\6-1\6-1\Views\Home\General.cshtml"
   Write(Html.ActionLink("History", "History"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    </div>
    <div class=""col-sm-8 col-md-10 col-lg-12"">
        <div class=""col-sm-8 col-md-10 col-lg-12"">
            <h3 class=""stylish col-sm-8 col-md-10 col-lg-12""><b>What Is Bootstrap?</b></h3><br />
            <p class=""stylish col-sm-8 col-md-10 col-lg-12""> A CSS framework for creating responsive web apps for multiple screen sizes</p>
        </div>
    </div>

    <br />
    <div class=""outline col-sm-8 col-md-10 col-lg-12"">
        <div class=""col-sm-8 col-md-10 col-lg-12"">
            <h3 class=""stylish col-sm-8 col-md-10 col-lg-12""><b>What Is C#?</b></h3> <br /> <p class=""stylish""> A general purpose object oriented language that uses a concise, Java-like syntax</p>
        </div>
    </div>

    <br />

    <div class=""outline col-sm-8 col-md-10 col-lg-12"">
        <div class=""col-sm-8 col-md-10 col-lg-12"">
            <h3 class=""stylish col-sm-8 col-md-10 col-lg-12""><b>What Is Javascript?</b></h3> <br /> <p class=""stylish""> A general purpose scripting language that executes");
                WriteLiteral(" in the web browser</p>\r\n        </div>\r\n    </div>\r\n");
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
