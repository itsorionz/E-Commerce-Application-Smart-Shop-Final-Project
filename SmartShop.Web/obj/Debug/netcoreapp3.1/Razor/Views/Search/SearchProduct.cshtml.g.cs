#pragma checksum "D:\Document Data\IDB\Projects\E-Commerce\Complete Project Final Update\SmartShop.Web\Views\Search\SearchProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "593bf804280fb98827a0623c2ba85236c9edc1f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Search_SearchProduct), @"mvc.1.0.view", @"/Views/Search/SearchProduct.cshtml")]
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
#line 2 "D:\Document Data\IDB\Projects\E-Commerce\Complete Project Final Update\SmartShop.Web\Views\_ViewImports.cshtml"
using SmartShop.DataLib.Models.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Document Data\IDB\Projects\E-Commerce\Complete Project Final Update\SmartShop.Web\Views\_ViewImports.cshtml"
using SmartShop.Web.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"593bf804280fb98827a0623c2ba85236c9edc1f2", @"/Views/Search/SearchProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb31386159708d264647a5b7b7d6dbdcc6786dc6", @"/Views/_ViewImports.cshtml")]
    public class Views_Search_SearchProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ProductDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger rounded-0 border-0 btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\Document Data\IDB\Projects\E-Commerce\Complete Project Final Update\SmartShop.Web\Views\Search\SearchProduct.cshtml"
  
    ViewData["Title"] = "SearchProduct";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<section class=\"products mt-4\">\r\n    <div class=\"container ck-cart-info\">\r\n        <h5>Products</h5>\r\n");
#nullable restore
#line 11 "D:\Document Data\IDB\Projects\E-Commerce\Complete Project Final Update\SmartShop.Web\Views\Search\SearchProduct.cshtml"
         if (Model!=null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row\">\r\n\r\n");
#nullable restore
#line 15 "D:\Document Data\IDB\Projects\E-Commerce\Complete Project Final Update\SmartShop.Web\Views\Search\SearchProduct.cshtml"
                 foreach (var p in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-lg-2 col-6 col-xs-6 mt-3\">\r\n                        <div class=\"border w-100 bx\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "593bf804280fb98827a0623c2ba85236c9edc1f25413", async() => {
                WriteLiteral("<img");
                BeginWriteAttribute("src", " src=\"", 599, "\"", 668, 2);
                WriteAttributeValue("", 605, "http://localhost:5000/Images/", 605, 29, true);
#nullable restore
#line 19 "D:\Document Data\IDB\Projects\E-Commerce\Complete Project Final Update\SmartShop.Web\Views\Search\SearchProduct.cshtml"
WriteAttributeValue("", 634, p.ProductImages.First().ImageName, 634, 34, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 669, "\"", 675, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"w-100\">");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 19 "D:\Document Data\IDB\Projects\E-Commerce\Complete Project Final Update\SmartShop.Web\Views\Search\SearchProduct.cshtml"
                                                                                      WriteLiteral(p.ProductId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            <div class=\"text-center p-2\">\r\n                                <h6>");
#nullable restore
#line 21 "D:\Document Data\IDB\Projects\E-Commerce\Complete Project Final Update\SmartShop.Web\Views\Search\SearchProduct.cshtml"
                               Write(p.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n\r\n                                <p><strong>$ ");
#nullable restore
#line 23 "D:\Document Data\IDB\Projects\E-Commerce\Complete Project Final Update\SmartShop.Web\Views\Search\SearchProduct.cshtml"
                                        Write(p.ProductPrices.First().Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\r\n                            </div>\r\n\r\n\r\n\r\n\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "593bf804280fb98827a0623c2ba85236c9edc1f29362", async() => {
                WriteLiteral("<i class=\"fa fa-shopping-cart\"> Add to cart</i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 29 "D:\Document Data\IDB\Projects\E-Commerce\Complete Project Final Update\SmartShop.Web\Views\Search\SearchProduct.cshtml"
                                 WriteLiteral(p.ProductId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "onclick", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1017, "addToCart(", 1017, 10, true);
#nullable restore
#line 29 "D:\Document Data\IDB\Projects\E-Commerce\Complete Project Final Update\SmartShop.Web\Views\Search\SearchProduct.cshtml"
AddHtmlAttributeValue("", 1027, p.ProductId, 1027, 12, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 1039, ")", 1039, 1, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 33 "D:\Document Data\IDB\Projects\E-Commerce\Complete Project Final Update\SmartShop.Web\Views\Search\SearchProduct.cshtml"



                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n            </div>\r\n");
#nullable restore
#line 44 "D:\Document Data\IDB\Projects\E-Commerce\Complete Project Final Update\SmartShop.Web\Views\Search\SearchProduct.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p class=\"text-danger text-center\">No product found!</p>\r\n");
#nullable restore
#line 48 "D:\Document Data\IDB\Projects\E-Commerce\Complete Project Final Update\SmartShop.Web\Views\Search\SearchProduct.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
