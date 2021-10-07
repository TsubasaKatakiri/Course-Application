#pragma checksum "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Order\GetAllUserOrders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "223615ce83a65414ad95859591a526656cb32920"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_GetAllUserOrders), @"mvc.1.0.view", @"/Views/Order/GetAllUserOrders.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"223615ce83a65414ad95859591a526656cb32920", @"/Views/Order/GetAllUserOrders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8eb520d9599da741e1307e1d107de4395c6a69b8", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_GetAllUserOrders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CourseApplication.BLL.VMs.Order.OrderData>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Order\GetAllUserOrders.cshtml"
  
    ViewData["Title"] = "My orders";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\r\n    <div class=\"row d-flex justify-content-between my-3\">\r\n        <h3>My orders</h3>\r\n    </div>\r\n    <div class=\"row d-flex flex-column align-items-center\">\r\n");
#nullable restore
#line 12 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Order\GetAllUserOrders.cshtml"
             if (Model.Count() == 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span class=\"text-muted\">Currently your order list is empty because you didn\'t ordered anything yet.</span>\r\n");
#nullable restore
#line 15 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Order\GetAllUserOrders.cshtml"
            }
            else
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Order\GetAllUserOrders.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"card mb-3 w-100\">\r\n                        <div class=\"card-header\">\r\n                            <h4>\r\n                                Order ");
#nullable restore
#line 23 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Order\GetAllUserOrders.cshtml"
                                 Write(Html.DisplayFor(modelItem => item.OrderId));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </h4>
                            </div>
                            <div class=""card-body"">
                                <div class=""container"">
                                    <div class=""row"">
                                        <p class=""font-weight-light font-italic"">Order created: <span>");
#nullable restore
#line 29 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Order\GetAllUserOrders.cshtml"
                                                                                                 Write(Html.DisplayFor(modelItem => item.DateCreated));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n                                        <p class=\"font-weight-light font-italic\">Full name: <span>");
#nullable restore
#line 30 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Order\GetAllUserOrders.cshtml"
                                                                                             Write(Html.DisplayFor(modelItem => item.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n                                        <p class=\"font-weight-light font-italic\">\r\n                                            Address:\r\n");
#nullable restore
#line 33 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Order\GetAllUserOrders.cshtml"
                                               if (item.Apartments != null)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <span>Apt. ");
#nullable restore
#line 35 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Order\GetAllUserOrders.cshtml"
                                                          Write(Html.DisplayFor(modelItem => item.Apartments));

#line default
#line hidden
#nullable disable
            WriteLiteral(", </span>\r\n");
#nullable restore
#line 36 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Order\GetAllUserOrders.cshtml"
                                                }
                                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span>");
#nullable restore
#line 38 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Order\GetAllUserOrders.cshtml"
                                             Write(Html.DisplayFor(modelItem => item.House));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>&nbsp;<span>");
#nullable restore
#line 38 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Order\GetAllUserOrders.cshtml"
                                                                                                         Write(Html.DisplayFor(modelItem => item.Street));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><br />\r\n                                            <span>");
#nullable restore
#line 39 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Order\GetAllUserOrders.cshtml"
                                             Write(Html.DisplayFor(modelItem => item.PostalIndex));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>&nbsp;\r\n                                            <span>");
#nullable restore
#line 40 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Order\GetAllUserOrders.cshtml"
                                             Write(Html.DisplayFor(modelItem => item.Region));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>&nbsp;\r\n                                            <span>");
#nullable restore
#line 41 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Order\GetAllUserOrders.cshtml"
                                             Write(Html.DisplayFor(modelItem => item.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                            <br />\r\n                                            <span>");
#nullable restore
#line 43 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Order\GetAllUserOrders.cshtml"
                                             Write(Html.DisplayFor(modelItem => item.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                        </p>\r\n                                        <p class=\"font-weight-light font-italic\">Telephone: <span>");
#nullable restore
#line 45 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Order\GetAllUserOrders.cshtml"
                                                                                             Write(Html.DisplayFor(modelItem => item.Telephone));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                            <ul class=\"list-group list-group-flush\">\r\n");
#nullable restore
#line 50 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Order\GetAllUserOrders.cshtml"
                                 foreach (var position in item.PositionList)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li class=\"list-group-item\">\r\n                                        <div>\r\n                                            <h4>");
#nullable restore
#line 54 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Order\GetAllUserOrders.cshtml"
                                           Write(Html.DisplayFor(modelItem => position.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                            <p class=\"font-weight-light font-italic\">Brand: <span>");
#nullable restore
#line 55 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Order\GetAllUserOrders.cshtml"
                                                                                             Write(Html.DisplayFor(modelItem => position.BrandName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n                                            <p class=\"font-weight-light font-italic\">Category: <span>");
#nullable restore
#line 56 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Order\GetAllUserOrders.cshtml"
                                                                                                Write(Html.DisplayFor(modelItem => position.CategoryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n                                            <p class=\"font-weight-light font-italic\">Description: <span>");
#nullable restore
#line 57 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Order\GetAllUserOrders.cshtml"
                                                                                                   Write(Html.DisplayFor(modelItem => position.ShortDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n                                            <h5 class=\"text-danger font-weight-bold\">USD $");
#nullable restore
#line 58 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Order\GetAllUserOrders.cshtml"
                                                                                     Write(Html.DisplayFor(modelItem => position.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                            <p class=\"font-weight-light font-italic\">Quantity: <span>");
#nullable restore
#line 59 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Order\GetAllUserOrders.cshtml"
                                                                                                Write(Html.DisplayFor(modelItem => position.Number));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></p>\r\n                                            <h5 class=\"font-weight-light font-italic\">Total cost: <span>");
#nullable restore
#line 60 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Order\GetAllUserOrders.cshtml"
                                                                                                   Write(Html.DisplayFor(modelItem => position.TotalPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h5>\r\n                                        </div>\r\n                                    </li>\r\n");
#nullable restore
#line 63 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Order\GetAllUserOrders.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </ul>\r\n                            <div class=\"card-body\">\r\n                                <h5>Total order cost:<span class=\"text-danger\">");
#nullable restore
#line 66 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Order\GetAllUserOrders.cshtml"
                                                                          Write(Html.DisplayFor(modelItem => item.TotalCost));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h5>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 69 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Order\GetAllUserOrders.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "C:\Users\Tsubasa Katakiri\source\repos\CourseApplication\CourseApplication\Views\Order\GetAllUserOrders.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n</div>");
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
