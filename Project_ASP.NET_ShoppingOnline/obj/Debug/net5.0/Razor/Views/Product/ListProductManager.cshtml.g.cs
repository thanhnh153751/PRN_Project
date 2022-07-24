#pragma checksum "E:\Project_PRN\Project_ASP.NET_ShoppingOnline\Views\Product\ListProductManager.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0acbb0ec8bf829d9a5c52c2165e7f197d897d1bf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_ListProductManager), @"mvc.1.0.view", @"/Views/Product/ListProductManager.cshtml")]
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
#line 6 "E:\Project_PRN\Project_ASP.NET_ShoppingOnline\Views\Product\ListProductManager.cshtml"
using Project_ASP.NET_ShoppingOnline.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0acbb0ec8bf829d9a5c52c2165e7f197d897d1bf", @"/Views/Product/ListProductManager.cshtml")]
    #nullable restore
    public class Views_Product_ListProductManager : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 80px;height: 60px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("output0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("200"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\Project_PRN\Project_ASP.NET_ShoppingOnline\Views\Product\ListProductManager.cshtml"
  
    ViewData["Title"] = "ListProductManager";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            DefineSection("styles", async() => {
                WriteLiteral(@"
    <style>
        .pagination {
            display: inline-block;
        }

            .pagination a {
                color: black;
                font-size: 22px;
                float: left;
                padding: 8px 16px;
                text-decoration: none;
            }

                .pagination a.active {
                    background-color: #ee3e0f;
                    color: black;
                }

                .pagination a:hover:not(.active) {
                    background-color: #ee3e0f;
                }

        table {
            text-align: center;
            margin: 0 auto;
        }

        tbody, td, tfoot, th, thead, tr {
            border-width: 1px;
        }

        button a {
            text-decoration: none;
        }
    </style>
");
            }
            );
            WriteLiteral(@"
<h1 style=""text-align: center"">Manager Products</h1>
<a style=""display: flex;  justify-content: center; margin-bottom: 20px"" href=""/Product/addNewProduct""><button style="" border: #fd7e14 solid 1px"" type=""button"">ADD NEW</button></a>

<table border=""1px"">
    <tr>
        <th>ProductID</th>
        <th>CategoryName</th>
        <th>ProductName</th>
        <th>image</th>
        <th>Price</th>
        <th>Units In Stock</th>
        <th>Units On Order</th>
        <th>description</th>
        <th>Action</th>
    </tr>
");
#nullable restore
#line 61 "E:\Project_PRN\Project_ASP.NET_ShoppingOnline\Views\Product\ListProductManager.cshtml"
     foreach (Product product in Model)
    {


        

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 67 "E:\Project_PRN\Project_ASP.NET_ShoppingOnline\Views\Product\ListProductManager.cshtml"
               Write(product.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 68 "E:\Project_PRN\Project_ASP.NET_ShoppingOnline\Views\Product\ListProductManager.cshtml"
               Write(product.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 69 "E:\Project_PRN\Project_ASP.NET_ShoppingOnline\Views\Product\ListProductManager.cshtml"
               Write(product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0acbb0ec8bf829d9a5c52c2165e7f197d897d1bf6862", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1854, "~/", 1854, 2, true);
#nullable restore
#line 70 "E:\Project_PRN\Project_ASP.NET_ShoppingOnline\Views\Product\ListProductManager.cshtml"
AddHtmlAttributeValue("", 1856, product.Image, 1856, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                <td class=\"monney\">");
#nullable restore
#line 71 "E:\Project_PRN\Project_ASP.NET_ShoppingOnline\Views\Product\ListProductManager.cshtml"
                              Write(product.UnitPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 72 "E:\Project_PRN\Project_ASP.NET_ShoppingOnline\Views\Product\ListProductManager.cshtml"
               Write(product.UnitsInStock);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 73 "E:\Project_PRN\Project_ASP.NET_ShoppingOnline\Views\Product\ListProductManager.cshtml"
               Write(product.UnitsOnOrder);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 74 "E:\Project_PRN\Project_ASP.NET_ShoppingOnline\Views\Product\ListProductManager.cshtml"
               Write(product.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                <td>\r\n                    <button type=\"button\"><a");
            BeginWriteAttribute("href", " href=\"", 2152, "\"", 2198, 2);
            WriteAttributeValue("", 2159, "/Product/editProduct/", 2159, 21, true);
#nullable restore
#line 77 "E:\Project_PRN\Project_ASP.NET_ShoppingOnline\Views\Product\ListProductManager.cshtml"
WriteAttributeValue("", 2180, product.ProductId, 2180, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">edit</a></button>&nbsp;&nbsp;&nbsp;\r\n                    <button type=\"button\" data-toggle=\"modal\" data-target=\"#exampleModal");
#nullable restore
#line 78 "E:\Project_PRN\Project_ASP.NET_ShoppingOnline\Views\Product\ListProductManager.cshtml"
                                                                                    Write(product.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><a onclick=\"doDelete(\'${li.productID}\')\">remove</a> </button>\r\n\r\n                </td>\r\n\r\n            </tr>\r\n            <!-- Modal -->\r\n            <div class=\"modal fade\"");
            BeginWriteAttribute("id", " id=\"", 2519, "\"", 2556, 2);
            WriteAttributeValue("", 2524, "exampleModal", 2524, 12, true);
#nullable restore
#line 84 "E:\Project_PRN\Project_ASP.NET_ShoppingOnline\Views\Product\ListProductManager.cshtml"
WriteAttributeValue("", 2536, product.ProductId, 2536, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
                <div class=""modal-dialog"" role=""document"">
                    <div class=""modal-content"">
                        <div class=""modal-header"">
                            <h5 class=""modal-title"" id=""exampleModalLabel"" style=""color:red;"">Do you really want to delete this product?</h5>
                            <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                <span aria-hidden=""true"">&times;</span>
                            </button>
                        </div>
                        <div class=""modal-body"">
                            <p>");
#nullable restore
#line 94 "E:\Project_PRN\Project_ASP.NET_ShoppingOnline\Views\Product\ListProductManager.cshtml"
                          Write(product.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p>");
#nullable restore
#line 95 "E:\Project_PRN\Project_ASP.NET_ShoppingOnline\Views\Product\ListProductManager.cshtml"
                          Write(product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p>");
#nullable restore
#line 96 "E:\Project_PRN\Project_ASP.NET_ShoppingOnline\Views\Product\ListProductManager.cshtml"
                          Write(product.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p>");
#nullable restore
#line 97 "E:\Project_PRN\Project_ASP.NET_ShoppingOnline\Views\Product\ListProductManager.cshtml"
                          Write(product.UnitPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0acbb0ec8bf829d9a5c52c2165e7f197d897d1bf13090", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3519, "~/", 3519, 2, true);
#nullable restore
#line 98 "E:\Project_PRN\Project_ASP.NET_ShoppingOnline\Views\Product\ListProductManager.cshtml"
AddHtmlAttributeValue("", 3521, product.Image, 3521, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"modal-footer\">\r\n                            <button type=\"button\" class=\"btn btn-secondary\" data-dismiss=\"modal\">Close</button>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 3791, "\"", 3839, 2);
            WriteAttributeValue("", 3798, "/Product/deleteProduct/", 3798, 23, true);
#nullable restore
#line 102 "E:\Project_PRN\Project_ASP.NET_ShoppingOnline\Views\Product\ListProductManager.cshtml"
WriteAttributeValue("", 3821, product.ProductId, 3821, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><button type=\"button\" class=\"btn btn-primary\">Delete</button></a>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 107 "E:\Project_PRN\Project_ASP.NET_ShoppingOnline\Views\Product\ListProductManager.cshtml"
        



    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n<div class=\"pagination\" id=\"paginationP\">\r\n\r\n");
#nullable restore
#line 116 "E:\Project_PRN\Project_ASP.NET_ShoppingOnline\Views\Product\ListProductManager.cshtml"
     if (ViewBag.Page > 1)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a");
            BeginWriteAttribute("href", " href=\"", 4137, "\"", 4220, 1);
#nullable restore
#line 118 "E:\Project_PRN\Project_ASP.NET_ShoppingOnline\Views\Product\ListProductManager.cshtml"
WriteAttributeValue("", 4144, Url.Action("ListProductManager","Product", new { page = ViewBag.Page - 1 }), 4144, 76, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-default\"> &laquo; Prev </a>\r\n");
#nullable restore
#line 119 "E:\Project_PRN\Project_ASP.NET_ShoppingOnline\Views\Product\ListProductManager.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 121 "E:\Project_PRN\Project_ASP.NET_ShoppingOnline\Views\Product\ListProductManager.cshtml"
     for (var i = 1; i <= ViewBag.MaxPage + 1; i++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a");
            BeginWriteAttribute("class", " class=\"", 4345, "\"", 4385, 1);
#nullable restore
#line 123 "E:\Project_PRN\Project_ASP.NET_ShoppingOnline\Views\Product\ListProductManager.cshtml"
WriteAttributeValue("", 4353, ViewBag.Page == i?"active":"", 4353, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 4386, "\"", 4453, 1);
#nullable restore
#line 123 "E:\Project_PRN\Project_ASP.NET_ShoppingOnline\Views\Product\ListProductManager.cshtml"
WriteAttributeValue("", 4393, Url.Action("ListProductManager","Product", new { page = i}), 4393, 60, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 123 "E:\Project_PRN\Project_ASP.NET_ShoppingOnline\Views\Product\ListProductManager.cshtml"
                                                                                                                   Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 124 "E:\Project_PRN\Project_ASP.NET_ShoppingOnline\Views\Product\ListProductManager.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 126 "E:\Project_PRN\Project_ASP.NET_ShoppingOnline\Views\Product\ListProductManager.cshtml"
     if (ViewBag.Page < ViewBag.MaxPage + 1)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a");
            BeginWriteAttribute("href", " href=\"", 4535, "\"", 4617, 1);
#nullable restore
#line 128 "E:\Project_PRN\Project_ASP.NET_ShoppingOnline\Views\Product\ListProductManager.cshtml"
WriteAttributeValue("", 4542, Url.Action("ListProductManager","Product", new {page = ViewBag.Page + 1 }), 4542, 75, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-default\">Next &raquo;</a>\r\n");
#nullable restore
#line 129 "E:\Project_PRN\Project_ASP.NET_ShoppingOnline\Views\Product\ListProductManager.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
