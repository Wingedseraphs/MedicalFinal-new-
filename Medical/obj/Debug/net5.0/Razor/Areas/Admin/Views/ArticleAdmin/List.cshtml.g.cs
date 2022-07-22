#pragma checksum "C:\Users\Student\source\repos\MedicalFinal-new-\Medical\Areas\Admin\Views\ArticleAdmin\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55879038ec9d05be3742ecf244fa75c799b8eb75"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ArticleAdmin_List), @"mvc.1.0.view", @"/Areas/Admin/Views/ArticleAdmin/List.cshtml")]
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
#line 1 "C:\Users\Student\source\repos\MedicalFinal-new-\Medical\Areas\_ViewImports.cshtml"
using Medical;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Student\source\repos\MedicalFinal-new-\Medical\Areas\_ViewImports.cshtml"
using Medical.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55879038ec9d05be3742ecf244fa75c799b8eb75", @"/Areas/Admin/Views/ArticleAdmin/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24de361111f0b04cb59052ed4f6ecd3219f4a4fd", @"/Areas/_ViewImports.cshtml")]
    public class Areas_Admin_Views_ArticleAdmin_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Medical.ViewModel.AArticleViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Student\source\repos\MedicalFinal-new-\Medical\Areas\Admin\Views\ArticleAdmin\List.cshtml"
  
    ViewData["Title"] = "List";
    Layout = "~/Areas/Admin/Admin_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"container-fluid\">\r\n    <div class=\"row mb-2\">\r\n        <div class=\"col-sm-6\">\r\n");
            WriteLiteral("            <h1 style=\"font-family: 微軟正黑體; font-weight: bold; color: darkorange;\">衛教文章(後臺系統)</h1>\r\n        </div>\r\n");
            WriteLiteral("    </div>\r\n</div>\r\n\r\n<div class=\"card\">\r\n\r\n");
#nullable restore
#line 21 "C:\Users\Student\source\repos\MedicalFinal-new-\Medical\Areas\Admin\Views\ArticleAdmin\List.cshtml"
     using (Html.BeginForm())
    {
        //修改

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div style=\"text-align: center;padding-top:20px\">\r\n            <label");
            BeginWriteAttribute("class", " class=\"", 569, "\"", 577, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"font-size: 25px; font-family: 微軟正黑體; font-weight: bold; color: darkorange;\">關鍵字 : </label>\r\n            ");
#nullable restore
#line 26 "C:\Users\Student\source\repos\MedicalFinal-new-\Medical\Areas\Admin\Views\ArticleAdmin\List.cshtml"
       Write(Html.TextBox("txtKeyword", "", new { @class = "font-weight-bold", style = "font-size:26px;border-radius:15px;", @placeholder = "search..." }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <button type=\"submit\" class=\"btn bg-gradient-warning btn-lg\">\r\n                <i class=\"fa fa-search\">\r\n                    查詢\r\n                </i>\r\n            </button>\r\n        </div>\r\n");
#nullable restore
#line 33 "C:\Users\Student\source\repos\MedicalFinal-new-\Medical\Areas\Admin\Views\ArticleAdmin\List.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("    <p style=\"padding: 20px 30px 0 0; text-align: right;\">\r\n        ");
#nullable restore
#line 38 "C:\Users\Student\source\repos\MedicalFinal-new-\Medical\Areas\Admin\Views\ArticleAdmin\List.cshtml"
   Write(Html.ActionLink("新增衛教內容", "Create", "ArticleAdmin", "",
                               new { @class = "btn btn-outline-success", @style = "font-size:18px;border-radius:5px; font-weight: bold " }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n\r\n");
#nullable restore
#line 42 "C:\Users\Student\source\repos\MedicalFinal-new-\Medical\Areas\Admin\Views\ArticleAdmin\List.cshtml"
      
        int count = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card\">\r\n            <div class=\"card-header\">\r\n");
            WriteLiteral(@"                <h3 class=""card-title"" style=""font-size: 25px; font-family: 微軟正黑體; font-weight: bold; color: darkorange;"">衛教表單細節</h3>
            </div>

            <div class=""card-body"">
                <div id=""example2_wrapper"" class=""dataTables_wrapper dt-bootstrap4"">
                    <div class=""row""><div class=""col-sm-12 col-md-6""></div><div class=""col-sm-12 col-md-6""></div></div><div class=""row"">
                        <div class=""col-sm-12"">
                            <table id=""example2"" class=""table table-bordered table-hover dataTable dtr-inline"" aria-describedby=""example2_info"">
                                <thead>
                                    <tr>
                                        <th class=""sorting sorting_asc"" tabindex=""0"" aria-controls=""example2"" rowspan=""1"" colspan=""1"" aria-sort=""ascending"" aria-label=""Rendering engine: activate to sort column descending"">序</th>
                                        <th class=""sorting"" tabindex=""0"" aria-controls=""example2"" ");
            WriteLiteral(@"rowspan=""1"" colspan=""1"" aria-label=""Browser: activate to sort column ascending"">發佈日期</th>
                                        <th class=""sorting"" tabindex=""0"" aria-controls=""example2"" rowspan=""1"" colspan=""1"" aria-label=""Platform(s): activate to sort column ascending"">醫生</th>
                                        <th class=""sorting"" tabindex=""0"" aria-controls=""example2"" rowspan=""1"" colspan=""1"" aria-label=""Engine version: activate to sort column ascending"">疾病</th>
                                        <th class=""sorting"" tabindex=""0"" aria-controls=""example2"" rowspan=""1"" colspan=""1"" aria-label=""CSS grade: activate to sort column ascending"">文章內容</th>
");
            WriteLiteral(@"                                        <th class=""sorting"" tabindex=""0"" aria-controls=""example2"" rowspan=""1"" colspan=""1"" aria-label=""CSS grade: activate to sort column ascending""></th>
                                    </tr>
                                </thead>
                                <tbody>

");
#nullable restore
#line 68 "C:\Users\Student\source\repos\MedicalFinal-new-\Medical\Areas\Admin\Views\ArticleAdmin\List.cshtml"
                                     foreach (var item in Model)
                                    {
                                        count++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr class=\"odd\">\r\n                                            <td class=\"dtr-control sorting_1 font-weight-bold\" tabindex=\"0\" style=\"width:5%\">");
#nullable restore
#line 72 "C:\Users\Student\source\repos\MedicalFinal-new-\Medical\Areas\Admin\Views\ArticleAdmin\List.cshtml"
                                                                                                                        Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td style=\"width:10%\" class=\"font-weight-bold\">");
#nullable restore
#line 73 "C:\Users\Student\source\repos\MedicalFinal-new-\Medical\Areas\Admin\Views\ArticleAdmin\List.cshtml"
                                                                                      Write(Html.DisplayFor(modelItem => item.CreateDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td style=\"width:10%\" class=\"font-weight-bold\">");
#nullable restore
#line 74 "C:\Users\Student\source\repos\MedicalFinal-new-\Medical\Areas\Admin\Views\ArticleAdmin\List.cshtml"
                                                                                      Write(Html.DisplayFor(modelItem => item.Doctor.DoctorName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td style=\"width:15%\" class=\"font-weight-bold\">");
#nullable restore
#line 75 "C:\Users\Student\source\repos\MedicalFinal-new-\Medical\Areas\Admin\Views\ArticleAdmin\List.cshtml"
                                                                                      Write(Html.DisplayFor(modelItem => item.Articeltitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td style=\"width:50%\" class=\"font-weight-bold\">");
#nullable restore
#line 76 "C:\Users\Student\source\repos\MedicalFinal-new-\Medical\Areas\Admin\Views\ArticleAdmin\List.cshtml"
                                                                                      Write(Html.DisplayFor(modelItem => item.ArticleContent));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("                                            <td style=\"width: 8%;\">\r\n                                                <div class=\"fas fa-pencil-alt\" style=\"color: dodgerblue; margin-block: 3px\">\r\n                                                    ");
#nullable restore
#line 80 "C:\Users\Student\source\repos\MedicalFinal-new-\Medical\Areas\Admin\Views\ArticleAdmin\List.cshtml"
                                               Write(Html.ActionLink("修改", "Edit", "ArticleAdmin", new { id = item.ArticleId }, new { @class = "btn bg-gradient-primary btn-sm" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                </div>
                                                <br />
                                                <div class=""fas fa-trash"" style=""color: orangered; margin-top: 3px"">
                                                    ");
#nullable restore
#line 84 "C:\Users\Student\source\repos\MedicalFinal-new-\Medical\Areas\Admin\Views\ArticleAdmin\List.cshtml"
                                               Write(Html.ActionLink("刪除", "Delete", "ArticleAdmin", new { id = item.ArticleId },
new { onclick = "return confirm('確定要刪除此筆資料嗎??')", @class = "btn btn-danger btn-sm", @style = "margin-left:1px" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </div>\r\n                                            </td>\r\n                                        </tr>\r\n");
#nullable restore
#line 89 "C:\Users\Student\source\repos\MedicalFinal-new-\Medical\Areas\Admin\Views\ArticleAdmin\List.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </tbody>\r\n\r\n                            </table>\r\n                        </div>\r\n                    </div>\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Medical.ViewModel.AArticleViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
