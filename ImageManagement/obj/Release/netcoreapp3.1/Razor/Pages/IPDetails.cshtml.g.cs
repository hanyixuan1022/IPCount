#pragma checksum "E:\学习资料\IPCount\ImageManagement\Pages\IPDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "afc099856bbf51df397af7f5b8d7eff96d6732ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ImageManagement.Pages.Pages_IPDetails), @"mvc.1.0.razor-page", @"/Pages/IPDetails.cshtml")]
namespace ImageManagement.Pages
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
#line 1 "E:\学习资料\IPCount\ImageManagement\Pages\_ViewImports.cshtml"
using ImageManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\学习资料\IPCount\ImageManagement\Pages\_ViewImports.cshtml"
using Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\学习资料\IPCount\ImageManagement\Pages\IPDetails.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\学习资料\IPCount\ImageManagement\Pages\IPDetails.cshtml"
using X.PagedList.Mvc.Core.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"afc099856bbf51df397af7f5b8d7eff96d6732ab", @"/Pages/IPDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e3d9c9a1a54df96fcbe82fbeaf581ae3cf8c8f5", @"/Pages/_ViewImports.cshtml")]
    public class Pages_IPDetails : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "E:\学习资料\IPCount\ImageManagement\Pages\IPDetails.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                IP\r\n            </th>\r\n            <th>\r\n                UserAgent\r\n            </th>\r\n            <th>创建时间</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 21 "E:\学习资料\IPCount\ImageManagement\Pages\IPDetails.cshtml"
         foreach (var item in Model.UserInfos)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 25 "E:\学习资料\IPCount\ImageManagement\Pages\IPDetails.cshtml"
           Write(Html.DisplayFor(modelItem => item.Ip));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 28 "E:\学习资料\IPCount\ImageManagement\Pages\IPDetails.cshtml"
           Write(Html.DisplayFor(modelItem => item.UserAgent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <td>\r\n                ");
#nullable restore
#line 30 "E:\学习资料\IPCount\ImageManagement\Pages\IPDetails.cshtml"
           Write(Html.DisplayFor(modelItem => item.CreateDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 33 "E:\学习资料\IPCount\ImageManagement\Pages\IPDetails.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n    <tfoot>\r\n        <tr>\r\n            <td class=\"text-muted\" colspan=\"4\">\r\n                每页 ");
#nullable restore
#line 38 "E:\学习资料\IPCount\ImageManagement\Pages\IPDetails.cshtml"
              Write(Model.PageSize);

#line default
#line hidden
#nullable disable
            WriteLiteral(" 条记录，本页有 ");
#nullable restore
#line 38 "E:\学习资料\IPCount\ImageManagement\Pages\IPDetails.cshtml"
                                      Write(Model.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" 条记录,共有 ");
#nullable restore
#line 38 "E:\学习资料\IPCount\ImageManagement\Pages\IPDetails.cshtml"
                                                          Write(Model.TotalItemCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" 条记录。第 ");
#nullable restore
#line 38 "E:\学习资料\IPCount\ImageManagement\Pages\IPDetails.cshtml"
                                                                                       Write(Model.PageCount < Model.PageNumber ? 0 : Model.PageNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(" 页，共 ");
#nullable restore
#line 38 "E:\学习资料\IPCount\ImageManagement\Pages\IPDetails.cshtml"
                                                                                                                                                       Write(Model.PageCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" 页。\r\n");
            WriteLiteral("            </td>\r\n        </tr>\r\n    </tfoot>\r\n</table>\r\n");
#nullable restore
#line 44 "E:\学习资料\IPCount\ImageManagement\Pages\IPDetails.cshtml"
Write(Html.PagedListPager(Model.UserInfos, pageIndex => Url.Action("IPDetails", new { pageIndex, pageSize = Model.PageSize,id=Model.UserInfos[0]?.Image.Id }),
new PagedListRenderOptions
{
LinkToFirstPageFormat = "首页",
LinkToNextPageFormat = "下一页",
LinkToPreviousPageFormat = "上一页",
LinkToLastPageFormat = "末页",
MaximumPageNumbersToDisplay = 5,
DisplayItemSliceAndTotal = false//从头到尾显示页码
}
));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<table class=""table"" style=""width:50%"">
    <thead>
        <tr>
            <th style=""border:none"">
                IP
            </th>
            <th style=""border:none"">
               访问次数
            </th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 67 "E:\学习资料\IPCount\ImageManagement\Pages\IPDetails.cshtml"
         foreach (var item in Model.IPList)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td style=\"border:none\">\r\n                    ");
#nullable restore
#line 71 "E:\学习资料\IPCount\ImageManagement\Pages\IPDetails.cshtml"
               Write(Html.DisplayFor(modelItem => item.IP));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td style=\"border:none\">\r\n                    ");
#nullable restore
#line 74 "E:\学习资料\IPCount\ImageManagement\Pages\IPDetails.cshtml"
               Write(Html.DisplayFor(modelItem => item.Count));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </tr>\r\n");
#nullable restore
#line 76 "E:\学习资料\IPCount\ImageManagement\Pages\IPDetails.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPDetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IPDetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IPDetailsModel>)PageContext?.ViewData;
        public IPDetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591