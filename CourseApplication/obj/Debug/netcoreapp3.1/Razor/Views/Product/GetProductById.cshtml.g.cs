#pragma checksum "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Product\GetProductById.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f976032d6ba1498c2190a3ad8f92c1f9eb84c12e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_GetProductById), @"mvc.1.0.view", @"/Views/Product/GetProductById.cshtml")]
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
#line 1 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\_ViewImports.cshtml"
using CourseApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\_ViewImports.cshtml"
using CourseApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f976032d6ba1498c2190a3ad8f92c1f9eb84c12e", @"/Views/Product/GetProductById.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8eb520d9599da741e1307e1d107de4395c6a69b8", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_GetProductById : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CourseApplication.BLL.VMs.Product.ProductData>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary mb-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetAllProducts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "CartPosition", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateCartPosition", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteCartPosition", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "WishlistPosition", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateWishlistPosition", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteWishlistPosition", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Review", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateReview", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Product\GetProductById.cshtml"
  
    ViewData["Title"] = @Html.DisplayFor(model => model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f976032d6ba1498c2190a3ad8f92c1f9eb84c12e7967", async() => {
                WriteLiteral("Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    <h2> ");
#nullable restore
#line 9 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Product\GetProductById.cshtml"
    Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n    <div class=\"card\">\r\n        <div class=\"card-body\">\r\n            <div class=\"container\">\r\n                <div class=\"row\">\r\n                    <div class=\"col-sm-5\">\r\n");
#nullable restore
#line 16 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Product\GetProductById.cshtml"
                         foreach (var f in Model.Files)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <img");
            BeginWriteAttribute("src", " src=\"", 597, "\"", 664, 2);
            WriteAttributeValue("", 603, "data:image;base64,", 603, 18, true);
#nullable restore
#line 18 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Product\GetProductById.cshtml"
WriteAttributeValue("", 621, System.Convert.ToBase64String(f.DataFiles), 621, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"w-100\" />\r\n");
#nullable restore
#line 19 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Product\GetProductById.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                    <div class=\"col-sm-7\">\r\n                        <h4>");
#nullable restore
#line 22 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Product\GetProductById.cshtml"
                       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                        <p>Product score: <span>");
#nullable restore
#line 23 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Product\GetProductById.cshtml"
                                           Write(Html.DisplayFor(model => model.Score));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>/5.0</p>\r\n                        <p class=\"font-weight-light font-italic\">Brand: <span>");
#nullable restore
#line 24 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Product\GetProductById.cshtml"
                                                                         Write(Html.DisplayFor(model => model.BrandName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n                        <p class=\"font-weight-light font-italic\">Category: <span>");
#nullable restore
#line 25 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Product\GetProductById.cshtml"
                                                                            Write(Html.DisplayFor(model => model.CategoryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n                        <h3 class=\"text-danger font-weight-bold\">USD $");
#nullable restore
#line 26 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Product\GetProductById.cshtml"
                                                                 Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                        <p class=\"font-weight-light font-italic\">Available: <span>");
#nullable restore
#line 27 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Product\GetProductById.cshtml"
                                                                             Write(Html.DisplayFor(model => model.Quantity));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n");
#nullable restore
#line 28 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Product\GetProductById.cshtml"
                          if (User.Identity.IsAuthenticated)
                            {
                                if (Model.Quantity > 0)
                                {
                                    if (Model.InCart == false)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f976032d6ba1498c2190a3ad8f92c1f9eb84c12e14107", async() => {
                WriteLiteral("\r\n                                            <button type=\"submit\" class=\"btn btn-primary\">Add to cart</button>\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-productId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 34 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Product\GetProductById.cshtml"
                                                                                                                                   WriteLiteral(Model.ProductId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["productId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-productId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["productId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 37 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Product\GetProductById.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f976032d6ba1498c2190a3ad8f92c1f9eb84c12e17629", async() => {
                WriteLiteral("\r\n                                            <button type=\"submit\" class=\"btn btn-primary\">Remove from cart</button>\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-positionId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 40 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Product\GetProductById.cshtml"
                                                                                                                                    WriteLiteral(Model.CartPositionId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["positionId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-positionId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["positionId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 43 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Product\GetProductById.cshtml"
                                    }
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <h4 class=\"text-danger font-weight-bold\">Sorry, but this product is no longer available!</h4>\r\n");
#nullable restore
#line 48 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Product\GetProductById.cshtml"
                                }
                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <p class=\"font-weight-light font-italic\">Orders: <span>");
#nullable restore
#line 52 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Product\GetProductById.cshtml"
                                                                          Write(Html.DisplayFor(model => model.OrderNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n");
#nullable restore
#line 53 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Product\GetProductById.cshtml"
                           if (User.Identity.IsAuthenticated)
                            {
                                if (Model.InWishlist == false)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f976032d6ba1498c2190a3ad8f92c1f9eb84c12e22505", async() => {
                WriteLiteral("\r\n                                        <button type=\"submit\" class=\"btn btn-primary\">Add to wishlist</button>\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-productId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 57 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Product\GetProductById.cshtml"
                                                                                                                                       WriteLiteral(Model.ProductId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["productId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-productId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["productId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 60 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Product\GetProductById.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f976032d6ba1498c2190a3ad8f92c1f9eb84c12e26011", async() => {
                WriteLiteral("\r\n                                        <button type=\"submit\" class=\"btn btn-primary\">Remove  from wishlist</button>\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-positionId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 63 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Product\GetProductById.cshtml"
                                                                                                                                        WriteLiteral(Model.WishlistPositionId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["positionId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-positionId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["positionId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 66 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Product\GetProductById.cshtml"
                                }
                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p class=\"font-weight-light font-italic\">In users wishlists: <span>");
#nullable restore
#line 69 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Product\GetProductById.cshtml"
                                                                                      Write(Html.DisplayFor(model => model.WishlistNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n                    </div>\r\n                </div>\r\n                <div>\r\n                    <h5>About product</h5>\r\n                    <p class=\"font-weight-light font-italic\"><span>");
#nullable restore
#line 74 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Product\GetProductById.cshtml"
                                                              Write(Html.DisplayFor(model => model.LongDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"row mt-3 mb-5\">\r\n        <div class=\"col-10\">\r\n            <h4>Product reviews</h4>\r\n        </div>\r\n");
#nullable restore
#line 84 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Product\GetProductById.cshtml"
         if (User.Identity.IsAuthenticated)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-2 d-flex justify-content-end\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f976032d6ba1498c2190a3ad8f92c1f9eb84c12e31083", async() => {
                WriteLiteral("Write review");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_12.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 87 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Product\GetProductById.cshtml"
                                                                                               WriteLiteral(Model.ProductId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 89 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Product\GetProductById.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <div class=\"row mt-3 mb-5\">\r\n");
#nullable restore
#line 92 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Product\GetProductById.cshtml"
         foreach (var i in Model.Reviews)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card mb-3 w-100\">\r\n                <div class=\"card-header\">\r\n                    <h5>\r\n                        ");
#nullable restore
#line 97 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Product\GetProductById.cshtml"
                   Write(Html.DisplayFor(modelItem => i.Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </h5>\r\n                    <p>\r\n                        Score:<span>");
#nullable restore
#line 100 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Product\GetProductById.cshtml"
                               Write(Html.DisplayFor(modelItem => i.Score));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>/5 On <span>");
#nullable restore
#line 100 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Product\GetProductById.cshtml"
                                                                                        Write(Html.DisplayFor(modelItem => i.ProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        Date: <span>");
#nullable restore
#line 101 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Product\GetProductById.cshtml"
                               Write(Html.DisplayFor(modelItem => i.DateCreated));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </p>\r\n                </div>\r\n                <div class=\"card-body\">\r\n                    <p>");
#nullable restore
#line 105 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Product\GetProductById.cshtml"
                  Write(Html.DisplayFor(modelItem => i.Text));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 106 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Product\GetProductById.cshtml"
                     foreach (var file in i.Files)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <img");
            BeginWriteAttribute("src", " src=\"", 5819, "\"", 5889, 2);
            WriteAttributeValue("", 5825, "data:image;base64,", 5825, 18, true);
#nullable restore
#line 108 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Product\GetProductById.cshtml"
WriteAttributeValue("", 5843, System.Convert.ToBase64String(file.DataFiles), 5843, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"100\" height=\"100\" />\r\n");
#nullable restore
#line 109 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Product\GetProductById.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n");
#nullable restore
#line 112 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Product\GetProductById.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CourseApplication.BLL.VMs.Product.ProductData> Html { get; private set; }
    }
}
#pragma warning restore 1591
