#pragma checksum "C:\Jonathan\Curtain\Curtain\Views\Home\Order.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40b6462a328bff3d7c6702324f20ed19addf5c4d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Order), @"mvc.1.0.view", @"/Views/Home/Order.cshtml")]
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
#line 1 "C:\Jonathan\Curtain\Curtain\Views\_ViewImports.cshtml"
using Curtain;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Jonathan\Curtain\Curtain\Views\_ViewImports.cshtml"
using Curtain.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40b6462a328bff3d7c6702324f20ed19addf5c4d", @"/Views/Home/Order.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6d8045893aa530a9d3cc163c77838ca697fc10e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Order : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Jonathan\Curtain\Curtain\Views\Home\Order.cshtml"
  
    ViewData["Title"] = "Order";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section class=""min-md-100"">

    <div class=""container"">
        <div class=""row min-md-100 justify-content-center align-items-md-start align-items-center text-center pt-md-5"">
            <div class=""col-lg-6 mt-lg-3"">
                <h3 class=""display-4 fw-medium mb-5"">Your Cart</h3>
            </div>
        </div>

    </div>

</section>
<br>
<div class=""row"">
    <div class=""col-lg-8 mx-auto"">

        <!-- List group-->
        <ul id=""orderList"" class=""list-group shadow"">
        </ul>
");
            WriteLiteral("        <!-- End -->\r\n    </div>\r\n</div>");
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
