#pragma checksum "C:\Users\Turab\Documents\GitHub\odev-5-kemiksizt\Week3\Week3.Web\Views\Home\ProductList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb5194ba3c77f282404d829c9d2d8f99311071fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ProductList), @"mvc.1.0.view", @"/Views/Home/ProductList.cshtml")]
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
#line 1 "C:\Users\Turab\Documents\GitHub\odev-5-kemiksizt\Week3\Week3.Web\Views\_ViewImports.cshtml"
using Week3.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Turab\Documents\GitHub\odev-5-kemiksizt\Week3\Week3.Web\Views\_ViewImports.cshtml"
using Week3.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb5194ba3c77f282404d829c9d2d8f99311071fb", @"/Views/Home/ProductList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86d2ff8af8ee577a39e08b0634715648989995e0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ProductList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Week3.Model.Product.ProductViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\Turab\Documents\GitHub\odev-5-kemiksizt\Week3\Week3.Web\Views\Home\ProductList.cshtml"
  
    ViewBag.Title = "Market";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <h2>Product Table</h2>\r\n     <table class=\"table table-striped table-bordered table-border\">\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 15 "C:\Users\Turab\Documents\GitHub\odev-5-kemiksizt\Week3\Week3.Web\Views\Home\ProductList.cshtml"
           Write(Html.DisplayNameFor(model => model.CategoryId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 18 "C:\Users\Turab\Documents\GitHub\odev-5-kemiksizt\Week3\Week3.Web\Views\Home\ProductList.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 21 "C:\Users\Turab\Documents\GitHub\odev-5-kemiksizt\Week3\Week3.Web\Views\Home\ProductList.cshtml"
           Write(Html.DisplayNameFor(model => model.DisplayName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 24 "C:\Users\Turab\Documents\GitHub\odev-5-kemiksizt\Week3\Week3.Web\Views\Home\ProductList.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 27 "C:\Users\Turab\Documents\GitHub\odev-5-kemiksizt\Week3\Week3.Web\Views\Home\ProductList.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 30 "C:\Users\Turab\Documents\GitHub\odev-5-kemiksizt\Week3\Week3.Web\Views\Home\ProductList.cshtml"
           Write(Html.DisplayNameFor(model => model.Stock));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 33 "C:\Users\Turab\Documents\GitHub\odev-5-kemiksizt\Week3\Week3.Web\Views\Home\ProductList.cshtml"
           Write(Html.DisplayNameFor(model => model.IUser));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n\r\n        \r\n");
#nullable restore
#line 38 "C:\Users\Turab\Documents\GitHub\odev-5-kemiksizt\Week3\Week3.Web\Views\Home\ProductList.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                ");
#nullable restore
#line 41 "C:\Users\Turab\Documents\GitHub\odev-5-kemiksizt\Week3\Week3.Web\Views\Home\ProductList.cshtml"
           Write(Html.HiddenFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\Users\Turab\Documents\GitHub\odev-5-kemiksizt\Week3\Week3.Web\Views\Home\ProductList.cshtml"
           Write(Html.DisplayFor(modelItem => item.CategoryId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "C:\Users\Turab\Documents\GitHub\odev-5-kemiksizt\Week3\Week3.Web\Views\Home\ProductList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "C:\Users\Turab\Documents\GitHub\odev-5-kemiksizt\Week3\Week3.Web\Views\Home\ProductList.cshtml"
           Write(Html.DisplayFor(modelItem => item.DisplayName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 52 "C:\Users\Turab\Documents\GitHub\odev-5-kemiksizt\Week3\Week3.Web\Views\Home\ProductList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 55 "C:\Users\Turab\Documents\GitHub\odev-5-kemiksizt\Week3\Week3.Web\Views\Home\ProductList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 58 "C:\Users\Turab\Documents\GitHub\odev-5-kemiksizt\Week3\Week3.Web\Views\Home\ProductList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Stock));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 61 "C:\Users\Turab\Documents\GitHub\odev-5-kemiksizt\Week3\Week3.Web\Views\Home\ProductList.cshtml"
           Write(Html.DisplayFor(modelItem => item.IUser));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>           \r\n        </tr>\r\n");
#nullable restore
#line 64 "C:\Users\Turab\Documents\GitHub\odev-5-kemiksizt\Week3\Week3.Web\Views\Home\ProductList.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n</div>\r\n\r\n    <style>\r\n\r\n    table td{\r\n        text-align: center;\r\n    }\r\n    table th{\r\n        text-align: center;\r\n    }\r\n</style>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Week3.Model.Product.ProductViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591