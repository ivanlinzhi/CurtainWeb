#pragma checksum "E:\source\CurtainWeb\Views\Home\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80d02e28eca97c0c3347f934a10a7257279f19d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contact), @"mvc.1.0.view", @"/Views/Home/Contact.cshtml")]
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
#line 1 "E:\source\CurtainWeb\Views\_ViewImports.cshtml"
using Curtain;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\source\CurtainWeb\Views\_ViewImports.cshtml"
using Curtain.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80d02e28eca97c0c3347f934a10a7257279f19d7", @"/Views/Home/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6d8045893aa530a9d3cc163c77838ca697fc10e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\source\CurtainWeb\Views\Home\Contact.cshtml"
  
    ViewData["Title"] = "Contact";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Content
        ============================================= -->
<section id=""content"">
    <div class=""content-wrap py-0"">

        <!-- 1. Section
        ============================================= -->
        <div class=""section bg-transparent my-0 py-0"">
            <div class=""container-fluid"">

                <div class=""clear""></div>

                <!-- 1. Section Map -->
                <!-- <div class=""row align-items-center custom-bg"" style=""--custom-bg: var(--themecolor)""> -->
                <!-- Map -->
                <!-- <div class=""col-md-6 px-lg-0 min-vh-50 min-vh-lg-100 d-flex align-self-stretch"">
                    <div class=""gmap-bg gmap h-100 position-absolute"" data-address=""Ottawa, Canada""
                    data-markers='[
                        {address: ""London"", icon:{ image: ""demos/furniture/images/map-pin.svg"", iconsize: [36,36], iconanchor: [36,36] }},
                        {address: ""San Fransisco"",html: ""San Fransisco, USA"",icon: {image: """);
            WriteLiteral(@"demos/furniture/images/map-pin.svg"",iconsize: [36,36],iconanchor: [36,36]}},
                        {address: ""Melbourne"",html: ""Melbourne, Australia"",icon: {image: ""demos/furniture/images/map-pin.svg"",iconsize: [36,36],iconanchor: [36,36]}},
                        {address: ""New York"",html: ""New York, USA"",icon: {image: ""demos/furniture/images/map-pin.svg"",iconsize: [36,36],iconanchor: [36,36]}},
                        {address: ""New York"",html: ""New York, New York"",icon: {image: ""demos/furniture/images/map-pin.svg"",iconsize: [36,36],iconanchor: [36,36]}},
                        {address: ""Los Angeles"",html: ""Los Angeles, California"",icon: {image: ""demos/furniture/images/map-pin.svg"",iconsize: [36,36],iconanchor: [36,36]}},
                        {address: ""Ottawa"",html: ""Ottawa, Canada"",icon: {image: ""demos/furniture/images/map-pin.svg"",iconsize: [36,36],iconanchor: [36,36]}},]'
                    data-styles='
                        [{""featureType"":""all"",""elementType"":""geometry.fill"",""stylers");
            WriteLiteral(@""":[{""weight"":""2.00""}]},{""featureType"":""all"",""elementType"":""geometry.stroke"",""stylers"":[{""color"":""#9c9c9c""}]},{""featureType"":""all"",""elementType"":""labels.text"",""stylers"":[{""visibility"":""on""}]},{""featureType"":""landscape"",""elementType"":""all"",""stylers"":[{""color"":""#f2f2f2""}]},{""featureType"":""landscape"",""elementType"":""geometry.fill"",""stylers"":[{""color"":""#ffffff""}]},{""featureType"":""landscape.man_made"",""elementType"":""geometry.fill"",""stylers"":[{""color"":""#ffffff""}]},{""featureType"":""poi"",""elementType"":""all"",""stylers"":[{""visibility"":""off""}]},{""featureType"":""road"",""elementType"":""all"",""stylers"":[{""saturation"":-100},{""lightness"":45}]},{""featureType"":""road"",""elementType"":""geometry.fill"",""stylers"":[{""color"":""#eeeeee""}]},{""featureType"":""road"",""elementType"":""labels.text.fill"",""stylers"":[{""color"":""#7b7b7b""}]},{""featureType"":""road"",""elementType"":""labels.text.stroke"",""stylers"":[{""color"":""#ffffff""}]},{""featureType"":""road.highway"",""elementType"":""all"",""stylers"":[{""visibility"":""simplified""}]},{""featureType"":""road.arterial"",""elementType");
            WriteLiteral(@""":""labels.icon"",""stylers"":[{""visibility"":""off""}]},{""featureType"":""transit"",""elementType"":""all"",""stylers"":[{""visibility"":""off""}]},{""featureType"":""water"",""elementType"":""all"",""stylers"":[{""color"":""#46bcec""},{""visibility"":""on""}]},{""featureType"":""water"",""elementType"":""geometry.fill"",""stylers"":[{""color"":""#c8d7d4""}]},{""featureType"":""water"",""elementType"":""labels.text.fill"",""stylers"":[{""color"":""#070707""}]},{""featureType"":""water"",""elementType"":""labels.text.stroke"",""stylers"":[{""color"":""#ffffff""}]}]'
                    data-scrollwheel=""false"" data-zoom=""4"" data-control-zoom=""true""
                    style="" top: 0; left: 0; width: 100%; z-index: 1;""></div>
                    <div class=""position-absolute pos-x-center pos-y-center m-0 text-white-50"">Map loading...</div>
                </div> -->
                <!-- Content -->
                <!-- <div class=""col-md-6 p-5 p-lg-6 dark"">
                        <h2 class=""h1 fw-normal mb-5"">Our <span  data-animate=""svg-underline-animated"" class=""svg-underline no");
            WriteLiteral(@"color""><span>Showrooms</span></span></h2>
                        <div class=""row col-mb-50"">
                            <a href=""https://www.google.com/maps/place/San+Francisco"" target=""_blank"" class=""col-sm-6"">
                                <h3 class=""h5 mb-2 fw-medium"">San Fransisco</h3>
                                <p class=""m-0 text-white-50"">795 Folsom Ave, Suite 600<br>
                                San Francisco, CA 94107</p>
                            </a>

                            <a href=""https://www.google.com/maps/place/melbourne"" target=""_blank"" class=""col-sm-6"">
                                <h3 class=""h5 mb-2 fw-medium"">Australia</h3>
                                <p class=""m-0 text-white-50"">62 Parkes Road,<br>
                                Melbourne, Victoria 3004</p>
                            </a>

                            <a href=""https://www.google.com/maps/place/london"" target=""_blank"" class=""col-sm-6"">
                                <h3 class=""h5 m");
            WriteLiteral(@"b-2 fw-medium"">London</h3>
                                <p class=""m-0 text-white-50"">115  Guild Street, Suite 893<br>
                                London, EC3A3RN</p>
                            </a>

                            <a href=""https://www.google.com/maps/place/new+york"" target=""_blank"" class=""col-sm-6"">
                                <h3 class=""h5 mb-2 fw-medium"">New York</h3>
                                <p class=""m-0 text-white-50"">996  Geraldine Lane, New York<br>
                                NY, 10004</p>
                            </a>

                            <a href=""https://www.google.com/maps/place/california"" target=""_blank"" class=""col-sm-6"">
                                <h3 class=""h5 mb-2 fw-medium"">California</h3>
                                <p class=""m-0 text-white-50"">3122  Doctors Drive, Los Angeles<br>
                                California, 90017</p>
                            </a>

                            <a href=""https://www.goog");
            WriteLiteral(@"le.com/maps/place/Ottawa,+ON,+Canada/"" target=""_blank"" class=""col-sm-6"">
                                <h3 class=""h5 mb-2 fw-medium"">Canada</h3>
                                <p class=""m-0 text-white-50"">305 Garrett Drive, Ottawa<br>
                                Canada, 21907</p>
                            </a>
                        </div>
                    </div>
                </div> -->

                <div class=""clear""></div>

                <!-- 2. Get In Touch -->
                <div class=""row flex-md-row-reverse align-items-center custom-bg"" style=""--custom-bg: #fff7de;"">
                    <!-- Image -->
                    <div class=""col-md-6 px-lg-0 min-vh-50 min-vh-lg-100 d-flex align-self-stretch"" style=""background: url('/images/contact/1.jpg') no-repeat center center; background-size: cover;"">
                    </div>

                    <!-- Content -->
                    <div class=""col-md-6 p-5 p-lg-6"">
                        <h2 class=""h1 fw-normal ");
            WriteLiteral(@"mb-5"">Get In <span data-animate=""svg-underline-animated"" class=""svg-underline nocolor""><span>Touch</span></span></h2>

                        <div class=""row col-mb-50"">
                            <div class=""col-12 col-lg-6"">
                                <h3 class=""h5 mb-2 fw-medium"">Email:</h3>
                                <a class=""m-0 op-07""><u>noreply@gmail.com</u></a>
                            </div>

                            <div class=""col-12 col-lg-6"">
                                <h3 class=""h5 mb-2 fw-medium"">Press:</h3>
                                <a class=""m-0 op-07"">
                                    <u>noreply.press@hotmail.com</u>
                                </a>
                            </div>

                            <div class=""col-12 col-lg-6"">
                                <h3 class=""h5 mb-2 fw-medium"">Call:</h3>
                                <a class=""m-0 op-07""><u>+00(111)-223344</u></a>
                            </div>

        ");
            WriteLiteral(@"                    <div class=""col-12 col-lg-6"">
                                <h3 class=""h5 mb-2 fw-medium"">WhatsApp:</h3>
                                <a class=""m-0 op-07""><u>00 111 223344</u></a>
                            </div>

                            <div class=""col-12 col-lg-12"">
                                <h3 class=""h5 mb-3 fw-medium"">Follow Us</h3>
                                <a class=""social-icon si-small si-rounded si-colored si-facebook"">
                                    <i class=""icon-facebook""></i>
                                    <i class=""icon-facebook""></i>
                                </a>
                                <a class=""social-icon si-small si-rounded si-colored si-instagram"">
                                    <i class=""icon-instagram""></i>
                                    <i class=""icon-instagram""></i>
                                </a>
                                <a class=""social-icon si-small si-rounded si-colored si-twitt");
            WriteLiteral(@"er"">
                                    <i class=""icon-twitter""></i>
                                    <i class=""icon-twitter""></i>
                                </a>
                                <a class=""social-icon si-small si-rounded si-colored si-youtube"">
                                    <i class=""icon-youtube""></i>
                                    <i class=""icon-youtube""></i>
                                </a>
                            </div>
                        </div>
                    </div>
                </div>

            </div>
        </div> <!-- Section End -->
        <!-- 6. Section Instagram
        ============================================= -->
        <div class=""section custom-bg my-0 py-1"" style=""--custom-bg: var(--themecolor);"">
            <div class=""row align-items-center no-gutters"">
                <!-- Instagram Center Col - Text -->
                <div class=""col-lg-4 py-5 order-lg-2"">
                    <div class=""text-center ");
            WriteLiteral(@"dark p-5"">
                        <svg xmlns=""http://www.w3.org/2000/svg"" width=""64"" height=""64"" fill=""#FFF"" viewBox=""0 0 256 256""><rect width=""256"" height=""256"" fill=""none""></rect><path d=""M172,36H84A47.99987,47.99987,0,0,0,36,84v88a47.99988,47.99988,0,0,0,48,48h88a47.99988,47.99988,0,0,0,48-48V84A47.99987,47.99987,0,0,0,172,36ZM128,168a40,40,0,1,1,40-40A40.0001,40.0001,0,0,1,128,168Z"" opacity=""0.2""></path><circle cx=""128"" cy=""128"" r=""40"" fill=""none"" stroke=""#FFF"" stroke-miterlimit=""10"" stroke-width=""16""></circle><rect x=""36"" y=""36"" width=""184"" height=""184"" rx=""48"" stroke-width=""16"" stroke=""#FFF"" stroke-linecap=""round"" stroke-linejoin=""round"" fill=""none""></rect><circle cx=""180"" cy=""75.99998"" r=""12""></circle></svg>

                        <h3 class=""mt-3 mb-5 fw-normal h2"">Don't Follow the Crowd, Follow us on <span data-animate=""svg-underline-animated"" class=""svg-underline nocolor""><span>Instagram</span></span></h3>

                        <a class=""button button-large button-border nott ls0 fw-normal");
            WriteLiteral(@" button-light button-white border-width-1 m-0"" style=""border-color: rgba(255,255,255,0.25)"">Instagram</a>
                    </div>
                </div>

                <!-- Instagram Left Col - Image -->
                <div class=""col-lg-4 col-md-6 order-lg-1"">
                    <div class=""row gutter-4"">
                        <div class=""col-6"">
                            <a class=""d-block instagram-image"" style=""background: url('demos/furniture/images/shop/1.jpg') no-repeat center center; background-size:cover; min-height: 33vh;""></a>
                        </div>
                        <div class=""col-6"">
                            <a class=""d-block instagram-image"" style=""background: url('demos/furniture/images/shop/2.jpg') no-repeat center center; background-size:cover; min-height: 33vh;""></a>
                        </div>
                        <div class=""col-6"">
                            <a class=""d-block instagram-image"" style=""background: url('demos/furniture/images/s");
            WriteLiteral(@"hop/3.jpg') no-repeat center center; background-size:cover; min-height: 33vh;""></a>
                        </div>
                        <div class=""col-6"">
                            <a class=""d-block instagram-image"" style=""background: url('demos/furniture/images/shop/4.jpg') no-repeat center center; background-size:cover; min-height: 33vh;""></a>
                        </div>
                    </div>
                </div>

                <!-- Instagram Right Col - Image -->
                <div class=""col-lg-4 col-md-6 order-lg-3 mt-1 mt-md-0 ps-md-1 ps-lg-0"">
                    <div class=""row gutter-4"">
                        <div class=""col-6"">
                            <a class=""d-block instagram-image"" style=""background: url('demos/furniture/images/shop/5.jpg') no-repeat center center; background-size:cover; min-height: 33vh;""></a>
                        </div>
                        <div class=""col-6"">
                            <a class=""d-block instagram-image"" style=""b");
            WriteLiteral(@"ackground: url('demos/furniture/images/shop/6.jpg') no-repeat center center; background-size:cover; min-height: 33vh;""></a>
                        </div>
                        <div class=""col-6"">
                            <a class=""d-block instagram-image"" style=""background: url('demos/furniture/images/shop/7.jpg') no-repeat center center; background-size:cover; min-height: 33vh;""></a>
                        </div>
                        <div class=""col-6"">
                            <a class=""d-block instagram-image"" style=""background: url('demos/furniture/images/shop/8.jpg') no-repeat center center; background-size:cover; min-height: 33vh;""></a>
                        </div>
                    </div>
                </div>
            </div>
        </div><!-- Section End -->

    </div>
</section><!-- #content end -->");
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
