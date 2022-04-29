#pragma checksum "C:\Users\SADRA\Desktop\ZenBlog\ZenBlog\Views\Home\AboutUs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b12fc5fa5104ef88ca76b8249f6b42416d55041"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AboutUs), @"mvc.1.0.view", @"/Views/Home/AboutUs.cshtml")]
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
#line 1 "C:\Users\SADRA\Desktop\ZenBlog\ZenBlog\Views\_ViewImports.cshtml"
using ZenBlog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SADRA\Desktop\ZenBlog\ZenBlog\Views\_ViewImports.cshtml"
using ZenBlog.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\SADRA\Desktop\ZenBlog\ZenBlog\Views\_ViewImports.cshtml"
using ZenBlog.DataLayer.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\SADRA\Desktop\ZenBlog\ZenBlog\Views\_ViewImports.cshtml"
using ZenBlog.Core.DTOs;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b12fc5fa5104ef88ca76b8249f6b42416d55041", @"/Views/Home/AboutUs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc80a57813c70530e8ce6175aefdc157edac0b49", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AboutUs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Setting>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\SADRA\Desktop\ZenBlog\ZenBlog\Views\Home\AboutUs.cshtml"
  
    ViewData["Title"] = "درباره ما";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<main id=""main"">
    <section>
        <div class=""container aos-init aos-animate"" data-aos=""fade-up"">
            <div class=""row"">
                <div class=""col-lg-12 text-center mb-5"">
                    <h1 class=""page-title"">درباره ما</h1>
                </div>
            </div>

            <div class=""row mb-5"">

                <div class=""d-md-flex post-entry-2 half"">
                    <a href=""#"" class=""me-4 thumbnail"">
                        <img src=""/Blog Template/assets/img/post-landscape-2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 600, "\"", 606, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""img-fluid"">
                    </a>
                    <div class=""pe-md-5 mt-4 mt-md-0"">
                        <div class=""post-meta mt-4"">درباره</div>
                        <h2 class=""mb-4 display-4"">ZenBlog</h2>
                        <p>
                            ");
#nullable restore
#line 26 "C:\Users\SADRA\Desktop\ZenBlog\ZenBlog\Views\Home\AboutUs.cshtml"
                       Write(Html.Raw(Model.AboutUs));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </p>
                    </div>
                </div>

            </div>

            <div class=""row gy-4"">

                <div class=""col-md-4"">
                    <div class=""info-item"">
                        <i class=""bi bi-geo-alt""></i>
                        <h3>آدرس</h3>
                        <address>");
#nullable restore
#line 39 "C:\Users\SADRA\Desktop\ZenBlog\ZenBlog\Views\Home\AboutUs.cshtml"
                            Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</address>
                    </div>
                </div><!-- End Info Item -->

                <div class=""col-md-4"">
                    <div class=""info-item info-item-borders"">
                        <i class=""bi bi-phone""></i>
                        <h3>تلفن</h3>
                        <p><a");
            BeginWriteAttribute("href", " href=\"", 1606, "\"", 1630, 2);
            WriteAttributeValue("", 1613, "tel:", 1613, 4, true);
#nullable restore
#line 47 "C:\Users\SADRA\Desktop\ZenBlog\ZenBlog\Views\Home\AboutUs.cshtml"
WriteAttributeValue("", 1617, Model.Phones, 1617, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 47 "C:\Users\SADRA\Desktop\ZenBlog\ZenBlog\Views\Home\AboutUs.cshtml"
                                                  Write(Model.Phones);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a></p>
                    </div>
                </div><!-- End Info Item -->

                <div class=""col-md-4"">
                    <div class=""info-item"">
                        <i class=""bi bi-envelope""></i>
                        <h3>ایمیل</h3>
                        <p><a");
            BeginWriteAttribute("href", " href=\"", 1941, "\"", 1969, 2);
            WriteAttributeValue("", 1948, "mailto:", 1948, 7, true);
#nullable restore
#line 55 "C:\Users\SADRA\Desktop\ZenBlog\ZenBlog\Views\Home\AboutUs.cshtml"
WriteAttributeValue("", 1955, Model.Email, 1955, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 55 "C:\Users\SADRA\Desktop\ZenBlog\ZenBlog\Views\Home\AboutUs.cshtml"
                                                      Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a></p>
                    </div>
                </div><!-- End Info Item -->

            </div>
        </div>
    </section>
    
    <section>
        <div class=""container aos-init aos-animate"" data-aos=""fade-up"">
            <div class=""row justify-content-center"">
                <div class=""col-12 text-center mb-5"">
                    <div class=""row justify-content-center"">
                        <div class=""col-lg-6"">
                            <h2 class=""display-4"">تیم توسعه دهنده</h2>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-4 text-center mb-5"">
                    <img src=""/Blog Template/assets/img/69380758.png""");
            BeginWriteAttribute("alt", " alt=\"", 2716, "\"", 2722, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""img-fluid rounded-circle w-50 mb-4"">
                    <h4>محمد صدرا برومند</h4>
                    <span class=""d-block mb-3 text-uppercase"">سازنده</span>
                    <p>FullStack Developer</p>
                </div>

            </div>
        </div>
    </section>

</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Setting> Html { get; private set; }
    }
}
#pragma warning restore 1591