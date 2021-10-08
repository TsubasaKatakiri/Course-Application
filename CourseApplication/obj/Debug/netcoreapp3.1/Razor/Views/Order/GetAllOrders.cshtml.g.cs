#pragma checksum "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Order\GetAllOrders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78dc9feddd0294776082a3a47a5c14a055bcaa0c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_GetAllOrders), @"mvc.1.0.view", @"/Views/Order/GetAllOrders.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78dc9feddd0294776082a3a47a5c14a055bcaa0c", @"/Views/Order/GetAllOrders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8eb520d9599da741e1307e1d107de4395c6a69b8", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_GetAllOrders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CourseApplication.BLL.VMs.Order.OrderData>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Order\GetAllOrders.cshtml"
  
    ViewData["Title"] = "Orders list";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\r\n    <div class=\"row d-flex justify-content-between my-3\">\r\n        <h3>Orders list</h3>\r\n    </div>\r\n    <div class=\"row d-flex flex-column align-items-center\">\r\n");
#nullable restore
#line 12 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Order\GetAllOrders.cshtml"
             if (Model.Count() == 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span class=\"text-muted\">Currently no user orders is present in database.</span>\r\n");
#nullable restore
#line 15 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Order\GetAllOrders.cshtml"
            }
            else
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Order\GetAllOrders.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"card mb-3 w-100\">\r\n                        <div class=\"card-header\">\r\n                            <h4>\r\n                                Order ");
#nullable restore
#line 23 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Order\GetAllOrders.cshtml"
                                 Write(Html.DisplayFor(modelItem => item.OrderId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </h4>\r\n                        </div>\r\n                        <div class=\"card-body\">\r\n                            <p>Order created: <span class=\"font-weight-light font-italic\">");
#nullable restore
#line 27 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Order\GetAllOrders.cshtml"
                                                                                     Write(Html.DisplayFor(modelItem => item.DateCreated));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n                            <p>Address: <span class=\"font-weight-light font-italic\">");
#nullable restore
#line 28 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Order\GetAllOrders.cshtml"
                                                                               Write(Html.DisplayFor(modelItem => item.FullAddressString));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n                            <h5>Ordered goods:</h5>\r\n                        </div>\r\n                        <ul class=\"list-group list-group-flush\">\r\n");
#nullable restore
#line 32 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Order\GetAllOrders.cshtml"
                             foreach (var position in item.PositionList)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"list-group-item\">\r\n                                    <div class=\"container\">\r\n                                        <div class=\"row\">\r\n                                            <h4>");
#nullable restore
#line 37 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Order\GetAllOrders.cshtml"
                                           Write(Html.DisplayFor(modelItem => position.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
                                        </div>
                                        <div class=""row py-1"">
                                            <div class=""col-4 my-0"">
                                                <p class=""font-weight-light font-italic my-1"">Brand: <span>");
#nullable restore
#line 41 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Order\GetAllOrders.cshtml"
                                                                                                      Write(Html.DisplayFor(modelItem => position.BrandName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n                                            </div>\r\n                                            <div class=\"col-4 my-0\">\r\n                                                <p class=\"font-weight-light font-italic my-1\">Category: <span>");
#nullable restore
#line 44 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Order\GetAllOrders.cshtml"
                                                                                                         Write(Html.DisplayFor(modelItem => position.CategoryName));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></p>
                                            </div>
                                        </div>
                                        <div class=""row py-1"">
                                            <div class=""col-4 my-0"">
                                                <p class=""font-weight-light font-italic my-1"">USD $");
#nullable restore
#line 49 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Order\GetAllOrders.cshtml"
                                                                                              Write(Html.DisplayFor(modelItem => position.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                            </div>\r\n                                            <div class=\"col-4 my-0\">\r\n                                                <p class=\"font-weight-light font-italic my-1\">Quantity: <span>");
#nullable restore
#line 52 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Order\GetAllOrders.cshtml"
                                                                                                         Write(Html.DisplayFor(modelItem => position.Number));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></p>
                                            </div>
                                        </div>
                                        <div class=""row py-1"">
                                            <h5 class=""text-danger font-weight-bold my-1"">Total cost: USD $<span>");
#nullable restore
#line 56 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Order\GetAllOrders.cshtml"
                                                                                                            Write(Html.DisplayFor(modelItem => position.TotalPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h5>\r\n                                        </div>\r\n                                    </div>\r\n                                </li>\r\n");
#nullable restore
#line 60 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Order\GetAllOrders.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\r\n                        <div class=\"card-body\">\r\n                            <h5 class=\"my-1\">Total order cost:<span class=\"text-danger\"> USD $");
#nullable restore
#line 63 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Order\GetAllOrders.cshtml"
                                                                                         Write(Html.DisplayFor(modelItem => item.TotalCost));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h5>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 66 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Order\GetAllOrders.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Order\GetAllOrders.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        }\r\n    </div>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CourseApplication.BLL.VMs.Order.OrderData>> Html { get; private set; }
    }
}
#pragma warning restore 1591
