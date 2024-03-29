#pragma checksum "C:\Users\SADRA\Desktop\ZenBlog\ZenBlog\Views\Category\ShowCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c0bb37e5f7bbdaae9894cfdeba31e0ae974d97c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_ShowCategory), @"mvc.1.0.view", @"/Views/Category/ShowCategory.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c0bb37e5f7bbdaae9894cfdeba31e0ae974d97c", @"/Views/Category/ShowCategory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc80a57813c70530e8ce6175aefdc157edac0b49", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_ShowCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GetCategoryViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("ms-4 thumbnail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ShowCategory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("active"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\SADRA\Desktop\ZenBlog\ZenBlog\Views\Category\ShowCategory.cshtml"
  
    ViewData["Title"] = "نمایش گروه";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<main id=\"main\">\r\n    <section>\r\n        <div class=\"container\">\r\n            <div class=\"row\">\r\n\r\n                <div class=\"col-md-9 aos-init aos-animate\" data-aos=\"fade-up\">\r\n                    <h3 class=\"category-title\">گروه: ");
#nullable restore
#line 12 "C:\Users\SADRA\Desktop\ZenBlog\ZenBlog\Views\Category\ShowCategory.cshtml"
                                                Write(ViewData["categoryTitle"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n");
#nullable restore
#line 14 "C:\Users\SADRA\Desktop\ZenBlog\ZenBlog\Views\Category\ShowCategory.cshtml"
                     if (Model.Posts.Count() <= 0)
                    {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""alert alert-info d-flex align-items-center"" role=""alert"">
                            <svg class=""bi flex-shrink-0 me-2 mx-3"" width=""24"" height=""24"" role=""img"" aria-label=""Warning:"">
                                <use xlink:href=""#exclamation-triangle-fill"">
                                    <template shadowmode=""closed"">
                                        <svg id=""exclamation-triangle-fill"" fill=""currentColor"" viewBox=""0 0 16 16"">
                                            <path d=""M8.982 1.566a1.13 1.13 0 0 0-1.96 0L.165 13.233c-.457.778.091 1.767.98 1.767h13.713c.889 0 1.438-.99.98-1.767L8.982 1.566zM8 5c.535 0 .954.462.9.995l-.35 3.507a.552.552 0 0 1-1.1 0L7.1 5.995A.905.905 0 0 1 8 5zm.002 6a1 1 0 1 1 0 2 1 1 0 0 1 0-2z""></path>
                                        </svg>
                                    </template>
                                </use>
                            </svg>
                            <div>
                    ");
            WriteLiteral("            برای این گروه هنوز هیچ پستی اضافه نشده است\r\n                            </div>\r\n");
            WriteLiteral("                        </div>\r\n");
#nullable restore
#line 32 "C:\Users\SADRA\Desktop\ZenBlog\ZenBlog\Views\Category\ShowCategory.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 34 "C:\Users\SADRA\Desktop\ZenBlog\ZenBlog\Views\Category\ShowCategory.cshtml"
                     foreach (var post in Model.Posts)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"d-md-flex post-entry-2 half\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c0bb37e5f7bbdaae9894cfdeba31e0ae974d97c7854", async() => {
                WriteLiteral("\r\n                                <img");
                BeginWriteAttribute("src", " src=\"", 2278, "\"", 2295, 1);
#nullable restore
#line 43 "C:\Users\SADRA\Desktop\ZenBlog\ZenBlog\Views\Category\ShowCategory.cshtml"
WriteAttributeValue("", 2284, post.Image, 2284, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 2296, "\"", 2313, 1);
#nullable restore
#line 43 "C:\Users\SADRA\Desktop\ZenBlog\ZenBlog\Views\Category\ShowCategory.cshtml"
WriteAttributeValue("", 2302, post.Title, 2302, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"img-fluid\">\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-postId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 39 "C:\Users\SADRA\Desktop\ZenBlog\ZenBlog\Views\Category\ShowCategory.cshtml"
                                     WriteLiteral(post.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["postId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-postId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["postId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 40 "C:\Users\SADRA\Desktop\ZenBlog\ZenBlog\Views\Category\ShowCategory.cshtml"
                                        WriteLiteral(post.Title);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["postTitle"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-postTitle", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["postTitle"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 41 "C:\Users\SADRA\Desktop\ZenBlog\ZenBlog\Views\Category\ShowCategory.cshtml"
                                            WriteLiteral(ViewData["categoryTitle"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["categoryTitle"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-categoryTitle", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["categoryTitle"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            <div>\r\n                                <div class=\"post-meta\"><span class=\"date\">");
#nullable restore
#line 46 "C:\Users\SADRA\Desktop\ZenBlog\ZenBlog\Views\Category\ShowCategory.cshtml"
                                                                     Write(ViewData["categoryTitle"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> <span class=\"mx-1\">•</span> <span>Jul 5th \'22</span></div>\r\n                                <h3>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c0bb37e5f7bbdaae9894cfdeba31e0ae974d97c13101", async() => {
#nullable restore
#line 52 "C:\Users\SADRA\Desktop\ZenBlog\ZenBlog\Views\Category\ShowCategory.cshtml"
                                                                                       Write(post.Title);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-postId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 50 "C:\Users\SADRA\Desktop\ZenBlog\ZenBlog\Views\Category\ShowCategory.cshtml"
                                             WriteLiteral(post.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["postId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-postId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["postId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 51 "C:\Users\SADRA\Desktop\ZenBlog\ZenBlog\Views\Category\ShowCategory.cshtml"
                                                WriteLiteral(post.Title);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["postTitle"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-postTitle", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["postTitle"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 52 "C:\Users\SADRA\Desktop\ZenBlog\ZenBlog\Views\Category\ShowCategory.cshtml"
                                                    WriteLiteral(ViewData["categoryTitle"]);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["categoryTitle"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-categoryTitle", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["categoryTitle"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </h3>\r\n                                <p>\r\n                                    ");
#nullable restore
#line 55 "C:\Users\SADRA\Desktop\ZenBlog\ZenBlog\Views\Category\ShowCategory.cshtml"
                               Write(post.ShortDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </p>\r\n                                <div class=\"d-flex align-items-center author\">\r\n                                    <div class=\"photo\"><img");
            BeginWriteAttribute("src", " src=\"", 3294, "\"", 3316, 1);
#nullable restore
#line 58 "C:\Users\SADRA\Desktop\ZenBlog\ZenBlog\Views\Category\ShowCategory.cshtml"
WriteAttributeValue("", 3300, post.User.Image, 3300, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 3317, "\"", 3342, 1);
#nullable restore
#line 58 "C:\Users\SADRA\Desktop\ZenBlog\ZenBlog\Views\Category\ShowCategory.cshtml"
WriteAttributeValue("", 3323, post.User.FullName, 3323, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"></div>\r\n                                    <div class=\"name\">\r\n                                        <h3 class=\"me-2 p-0\">");
#nullable restore
#line 60 "C:\Users\SADRA\Desktop\ZenBlog\ZenBlog\Views\Category\ShowCategory.cshtml"
                                                        Write(post.User.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 65 "C:\Users\SADRA\Desktop\ZenBlog\ZenBlog\Views\Category\ShowCategory.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n                    <div class=\"text-start py-4\">\r\n                        <div class=\"custom-pagination\">\r\n");
#nullable restore
#line 73 "C:\Users\SADRA\Desktop\ZenBlog\ZenBlog\Views\Category\ShowCategory.cshtml"
                             for (int i = 0; i <= Model.PostCount; i++)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c0bb37e5f7bbdaae9894cfdeba31e0ae974d97c19670", async() => {
#nullable restore
#line 77 "C:\Users\SADRA\Desktop\ZenBlog\ZenBlog\Views\Category\ShowCategory.cshtml"
                                              Write(i+1);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pageNumber", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 76 "C:\Users\SADRA\Desktop\ZenBlog\ZenBlog\Views\Category\ShowCategory.cshtml"
                                             WriteLiteral(i);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageNumber", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 78 "C:\Users\SADRA\Desktop\ZenBlog\ZenBlog\Views\Category\ShowCategory.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </div>
                    </div>
                </div>

                <div class=""col-md-3"">
                    <!-- ======= Sidebar ======= -->
                    <div class=""aside-block"">

                        <ul class=""nav nav-pills custom-tab-nav mb-4"" id=""pills-tab"" role=""tablist"">
                            <li class=""nav-item"" role=""presentation"">
                                <button class=""nav-link active"" id=""pills-popular-tab"" data-bs-toggle=""pill"" data-bs-target=""#pills-popular"" type=""button"" role=""tab"" aria-controls=""pills-popular"" aria-selected=""true"">جدیدترین ها</button>
                            </li>
                        </ul>

                        <div class=""tab-content"" id=""pills-tabContent"">

                            <!-- Popular -->
                            <div class=""tab-pane fade active show"" id=""pills-popular"" role=""tabpanel"" aria-labelledby=""pills-popular-tab"">

                                <div class=""post-ent");
            WriteLiteral(@"ry-1 border-bottom"">
                                    <div class=""post-meta""><span class=""date"">Sport</span> <span class=""mx-1"">•</span> <span>Jul 5th '22</span></div>
                                    <h2 class=""mb-2""><a href=""#"">How to Avoid Distraction and Stay Focused During Video Calls?</a></h2>
                                    <span class=""author mb-3 d-block"">Jenny Wilson</span>
                                </div>


                            </div> <!-- End Popular -->

                        </div>
                    </div>

                    ");
#nullable restore
#line 111 "C:\Users\SADRA\Desktop\ZenBlog\ZenBlog\Views\Category\ShowCategory.cshtml"
               Write(await Component.InvokeAsync("ShowCategory"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    <!--<div class=""aside-block"">
                        <h3 class=""aside-title"">Tags</h3>
                        <ul class=""aside-tags list-unstyled"">
                            <li><a href=""category.html"">Business</a></li>
                            <li><a href=""category.html"">Culture</a></li>
                            <li><a href=""category.html"">Sport</a></li>
                            <li><a href=""category.html"">Food</a></li>
                            <li><a href=""category.html"">Politics</a></li>
                            <li><a href=""category.html"">Celebrity</a></li>
                            <li><a href=""category.html"">Startups</a></li>
                            <li><a href=""category.html"">Travel</a></li>
                        </ul>
                    </div>-->
                    <!-- End Tags -->

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GetCategoryViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
