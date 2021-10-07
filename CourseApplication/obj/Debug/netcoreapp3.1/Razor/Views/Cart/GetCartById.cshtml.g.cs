#pragma checksum "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Cart\GetCartById.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5fb5931b18047a24e0fc0acf56d52b016082def3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_GetCartById), @"mvc.1.0.view", @"/Views/Cart/GetCartById.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fb5931b18047a24e0fc0acf56d52b016082def3", @"/Views/Cart/GetCartById.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8eb520d9599da741e1307e1d107de4395c6a69b8", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_GetCartById : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CourseApplication.BLL.VMs.Cart.CartData>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "CartPosition", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteCartPosition", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateNewOrder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Cart\GetCartById.cshtml"
  
    ViewData["Title"] = "My cart";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\r\n    <div class=\"row d-flex justify-content-between my-3\">\r\n        <h3>My cart</h3>\r\n        <p>");
#nullable restore
#line 9 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Cart\GetCartById.cshtml"
      Write(Html.DisplayFor(model => model.UserId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n    <div class=\"row d-flex flex-column align-items-center\">\r\n");
#nullable restore
#line 13 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Cart\GetCartById.cshtml"
             if (Model.PositionList.Count() == 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span class=\"text-muted\">Oops! Looks like your wishlist is empty. Try to add some products!</span>\r\n");
#nullable restore
#line 16 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Cart\GetCartById.cshtml"
            }
            else
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Cart\GetCartById.cshtml"
                 foreach (var item in Model.PositionList)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"card mb-3 w-100\">\r\n                        <div class=\"card-header\">\r\n                            <h4>\r\n                                ");
#nullable restore
#line 24 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Cart\GetCartById.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </h4>
                        </div>
                        <div class=""card-body"">
                            <div class=""container"">
                                <div class=""row"">
                                    <div class=""col-sm-3"">

                                    </div>
                                    <div class=""col-sm-7"">
                                        <p class=""font-weight-light font-italic"">Category: <span>");
#nullable restore
#line 34 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Cart\GetCartById.cshtml"
                                                                                            Write(Html.DisplayFor(modelItem => item.CategoryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n                                        <h5 class=\"text-danger font-weight-bold\">USD $");
#nullable restore
#line 35 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Cart\GetCartById.cshtml"
                                                                                 Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                        <p>Quantity: <span>");
#nullable restore
#line 36 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Cart\GetCartById.cshtml"
                                                      Write(Html.DisplayFor(modelItem => item.Number));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n                                        <h4 class=\"font-weight-bold\">Total price: <span class=\"text-danger\">USD $ ");
#nullable restore
#line 37 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Cart\GetCartById.cshtml"
                                                                                                             Write(Html.DisplayFor(modelItem => item.TotalPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h4>\r\n                                    </div>\r\n                                    <div class=\"col-sm-2\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5fb5931b18047a24e0fc0acf56d52b016082def39919", async() => {
                WriteLiteral("\r\n                                            <button type=\"submit\" class=\"btn btn-primary\">Delete from cart</button>\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-positionId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 40 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Cart\GetCartById.cshtml"
                                                                                                                                    WriteLiteral(item.Id);

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
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 48 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Cart\GetCartById.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Cart\GetCartById.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <div class=\"row d-flex justify-content-between my-3\">\r\n        <h4>Total cost: <span class=\"text-danger\">USD $");
#nullable restore
#line 53 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Cart\GetCartById.cshtml"
                                                  Write(Html.DisplayFor(model => model.TotalCost));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h4>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5fb5931b18047a24e0fc0acf56d52b016082def314175", async() => {
                WriteLiteral("Proceed to order");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CourseApplication.BLL.VMs.Cart.CartData> Html { get; private set; }
    }
}
#pragma warning restore 1591
