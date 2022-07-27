#pragma checksum "C:\ADO.NET\作業區\Medical-final-3.0\Medical\Views\Product\ReviewList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f2a7544b0c7bc02047aefb1e9fdd29c7445695b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_ReviewList), @"mvc.1.0.view", @"/Views/Product/ReviewList.cshtml")]
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
#line 1 "C:\ADO.NET\作業區\Medical-final-3.0\Medical\Views\_ViewImports.cshtml"
using Medical;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\ADO.NET\作業區\Medical-final-3.0\Medical\Views\_ViewImports.cshtml"
using Medical.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f2a7544b0c7bc02047aefb1e9fdd29c7445695b", @"/Views/Product/ReviewList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24de361111f0b04cb59052ed4f6ecd3219f4a4fd", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_ReviewList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Medical.ViewModel.CReviewViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\ADO.NET\作業區\Medical-final-3.0\Medical\Views\Product\ReviewList.cshtml"
  
    ViewData["Title"] = "ReviewList";
    Layout = "~/Areas/Admin/Admin_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>產品評論清單</h1>\r\n\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                編號\r\n            </th>\r\n            <th>\r\n                產品名稱\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 21 "C:\ADO.NET\作業區\Medical-final-3.0\Medical\Views\Product\ReviewList.cshtml"
           Write(Html.DisplayNameFor(model => model.Member));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 24 "C:\ADO.NET\作業區\Medical-final-3.0\Medical\Views\Product\ReviewList.cshtml"
           Write(Html.DisplayNameFor(model => model.RatingType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 27 "C:\ADO.NET\作業區\Medical-final-3.0\Medical\Views\Product\ReviewList.cshtml"
           Write(Html.DisplayNameFor(model => model.CommentContent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n");
            WriteLiteral("            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 36 "C:\ADO.NET\作業區\Medical-final-3.0\Medical\Views\Product\ReviewList.cshtml"
           int count = 0;
            foreach (var item in Model)
            {
                count++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 42 "C:\ADO.NET\作業區\Medical-final-3.0\Medical\Views\Product\ReviewList.cshtml"
                   Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 45 "C:\ADO.NET\作業區\Medical-final-3.0\Medical\Views\Product\ReviewList.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Product.ProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n");
            WriteLiteral("                    <td>\r\n                        ");
#nullable restore
#line 51 "C:\ADO.NET\作業區\Medical-final-3.0\Medical\Views\Product\ReviewList.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Member.MemberName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 54 "C:\ADO.NET\作業區\Medical-final-3.0\Medical\Views\Product\ReviewList.cshtml"
                   Write(Html.DisplayFor(modelItem => item.RatingType.RatingTypeName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 57 "C:\ADO.NET\作業區\Medical-final-3.0\Medical\Views\Product\ReviewList.cshtml"
                   Write(Html.DisplayFor(modelItem => item.CommentContent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n");
            WriteLiteral("                    <td>\r\n                        ");
#nullable restore
#line 63 "C:\ADO.NET\作業區\Medical-final-3.0\Medical\Views\Product\ReviewList.cshtml"
                   Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                        ");
#nullable restore
#line 64 "C:\ADO.NET\作業區\Medical-final-3.0\Medical\Views\Product\ReviewList.cshtml"
                   Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                        ");
#nullable restore
#line 65 "C:\ADO.NET\作業區\Medical-final-3.0\Medical\Views\Product\ReviewList.cshtml"
                   Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 68 "C:\ADO.NET\作業區\Medical-final-3.0\Medical\Views\Product\ReviewList.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Medical.ViewModel.CReviewViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
