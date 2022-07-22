#pragma checksum "C:\Users\Student\source\repos\MedicalFinal-new-\Medical\Views\Product\OrderList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c5029c3408c26782c951fbf955f0c2756f254f9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_OrderList), @"mvc.1.0.view", @"/Views/Product/OrderList.cshtml")]
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
#line 1 "C:\Users\Student\source\repos\MedicalFinal-new-\Medical\Views\_ViewImports.cshtml"
using Medical;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Student\source\repos\MedicalFinal-new-\Medical\Views\_ViewImports.cshtml"
using Medical.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c5029c3408c26782c951fbf955f0c2756f254f9", @"/Views/Product/OrderList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24de361111f0b04cb59052ed4f6ecd3219f4a4fd", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_OrderList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Medical.ViewModel.OrderDetailViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Student\source\repos\MedicalFinal-new-\Medical\Views\Product\OrderList.cshtml"
  
    ViewData["Title"] = "OrderList";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Hero Start -->
<div class=""container-fluid bg-primary py-5 hero-header mb-5"">
    <div class=""row py-3"">
        <div class=""col-12 text-center"">
            <h3 class=""display-3 text-white animated zoomIn"">歷史訂單</h3>
        </div>
    </div>
</div>
<!-- Hero End -->
<hr />

<div class=""card"">
    <div class=""card-body p-0"">
        <div class=""table-responsive"">
            <table class=""table m-0"">
                <thead>
                    <tr>
                        <th><font style=""vertical-align: inherit;""><font style=""vertical-align: inherit;"">訂單編號</font></font></th>
                        <th><font style=""vertical-align: inherit;""><font style=""vertical-align: inherit;"">購買日期</font></font></th>
                        <th><font style=""vertical-align: inherit;""><font style=""vertical-align: inherit;"">付款狀態</font></font></th>
                        <th><font style=""vertical-align: inherit;""><font style=""vertical-align: inherit;"">訂單狀態</font></font></th>
                       ");
            WriteLiteral(" <th><font style=\"vertical-align: inherit;\"><font style=\"vertical-align: inherit;\">付款方式</font></font></th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
#nullable restore
#line 31 "C:\Users\Student\source\repos\MedicalFinal-new-\Medical\Views\Product\OrderList.cshtml"
                      
                        int count = 0;
                        string sign = "";
                        foreach (var item in Model)
                        {
                            if (item.Order.IsPaid == true)
                            {
                                sign = "已付款";
                            }
                            if (item.Order.IsPaid == false)
                            {
                                sign = "未付款";
                            }
                            count++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 47 "C:\Users\Student\source\repos\MedicalFinal-new-\Medical\Views\Product\OrderList.cshtml"
                               Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 50 "C:\Users\Student\source\repos\MedicalFinal-new-\Medical\Views\Product\OrderList.cshtml"
                               Write(item.Order.OrderDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 53 "C:\Users\Student\source\repos\MedicalFinal-new-\Medical\Views\Product\OrderList.cshtml"
                               Write(sign);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n");
            WriteLiteral("                                    ");
#nullable restore
#line 57 "C:\Users\Student\source\repos\MedicalFinal-new-\Medical\Views\Product\OrderList.cshtml"
                               Write(item.Orderstate.OrderState1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 61 "C:\Users\Student\source\repos\MedicalFinal-new-\Medical\Views\Product\OrderList.cshtml"
                               Write(item.Paytype.PayType1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 64 "C:\Users\Student\source\repos\MedicalFinal-new-\Medical\Views\Product\OrderList.cshtml"
                               Write(Html.ActionLink("顯示訂單內容", "OrderDetailList", new { id = item.Order.OrderId }, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 67 "C:\Users\Student\source\repos\MedicalFinal-new-\Medical\Views\Product\OrderList.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Medical.ViewModel.OrderDetailViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
