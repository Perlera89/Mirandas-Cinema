#pragma checksum "C:\Users\Jose\Desktop\Mirandas-Cinema\Mirandas-Cinema\Mirandas-Cinema\Views\Orders\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82dd70acaacb5440071621014f3788dfdd47f360"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_Index), @"mvc.1.0.view", @"/Views/Orders/Index.cshtml")]
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
#line 1 "C:\Users\Jose\Desktop\Mirandas-Cinema\Mirandas-Cinema\Mirandas-Cinema\Views\_ViewImports.cshtml"
using Mirandas_Cinema;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jose\Desktop\Mirandas-Cinema\Mirandas-Cinema\Mirandas-Cinema\Views\_ViewImports.cshtml"
using Mirandas_Cinema.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Jose\Desktop\Mirandas-Cinema\Mirandas-Cinema\Mirandas-Cinema\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82dd70acaacb5440071621014f3788dfdd47f360", @"/Views/Orders/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"663dac38ee6cf95f22ed6090dbe8ba64b2d7fbe8", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Order>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/root/nav-bar.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "82dd70acaacb5440071621014f3788dfdd47f3604047", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Jose\Desktop\Mirandas-Cinema\Mirandas-Cinema\Mirandas-Cinema\Views\Orders\Index.cshtml"
   
    ViewData["Title"] = "Ordenes";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row nav-links col-md-11 m-auto"">
    <div class=""col-md-8 offset-2"">
        <p class=""mt-2 mb-2"">
            <h4>Lista de todos sus pedidos</h4>
        </p>

        <table class=""table table-hover"">
            <thead class=""thead-dark"">
                <tr>
                    <th>Order Id</th>
                    <th>Peliculas</th>
                    <th>Total</th>
");
#nullable restore
#line 20 "C:\Users\Jose\Desktop\Mirandas-Cinema\Mirandas-Cinema\Mirandas-Cinema\Views\Orders\Index.cshtml"
                     if (User.Identity.IsAuthenticated && User.IsInRole("Admin"))
	                {		 

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <th>Usuario</th>\r\n");
#nullable restore
#line 23 "C:\Users\Jose\Desktop\Mirandas-Cinema\Mirandas-Cinema\Mirandas-Cinema\Views\Orders\Index.cshtml"
	                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 27 "C:\Users\Jose\Desktop\Mirandas-Cinema\Mirandas-Cinema\Mirandas-Cinema\Views\Orders\Index.cshtml"
                 foreach (var order in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td class=\"align-middle\">");
#nullable restore
#line 30 "C:\Users\Jose\Desktop\Mirandas-Cinema\Mirandas-Cinema\Mirandas-Cinema\Views\Orders\Index.cshtml"
                                        Write(order.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"align-middle\">\r\n                        <ul style=\"list-style-type: none;\">\r\n");
#nullable restore
#line 33 "C:\Users\Jose\Desktop\Mirandas-Cinema\Mirandas-Cinema\Mirandas-Cinema\Views\Orders\Index.cshtml"
                             foreach (var movie in order.OrderItems)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li>\r\n                                    <div class=\"alert alert-info\" role=\"alert\">\r\n                                        <span class=\"badge bg-success\">");
#nullable restore
#line 37 "C:\Users\Jose\Desktop\Mirandas-Cinema\Mirandas-Cinema\Mirandas-Cinema\Views\Orders\Index.cshtml"
                                                                  Write(movie.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> [");
#nullable restore
#line 37 "C:\Users\Jose\Desktop\Mirandas-Cinema\Mirandas-Cinema\Mirandas-Cinema\Views\Orders\Index.cshtml"
                                                                                        Write(movie.Price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("] - ");
#nullable restore
#line 37 "C:\Users\Jose\Desktop\Mirandas-Cinema\Mirandas-Cinema\Mirandas-Cinema\Views\Orders\Index.cshtml"
                                                                                                                      Write(movie.Movie.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n                                </li>\r\n");
#nullable restore
#line 40 "C:\Users\Jose\Desktop\Mirandas-Cinema\Mirandas-Cinema\Mirandas-Cinema\Views\Orders\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\r\n                    </td>\r\n                    <td class=\"align-middle\">\r\n                        ");
#nullable restore
#line 44 "C:\Users\Jose\Desktop\Mirandas-Cinema\Mirandas-Cinema\Mirandas-Cinema\Views\Orders\Index.cshtml"
                   Write(order.OrderItems.Select(o => o.Movie.Price * o.Amount).Sum().ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n");
#nullable restore
#line 46 "C:\Users\Jose\Desktop\Mirandas-Cinema\Mirandas-Cinema\Mirandas-Cinema\Views\Orders\Index.cshtml"
                     if (User.Identity.IsAuthenticated && User.IsInRole("Admin"))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td class=\"align-middle\">");
#nullable restore
#line 48 "C:\Users\Jose\Desktop\Mirandas-Cinema\Mirandas-Cinema\Mirandas-Cinema\Views\Orders\Index.cshtml"
                                            Write(order.User.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 49 "C:\Users\Jose\Desktop\Mirandas-Cinema\Mirandas-Cinema\Mirandas-Cinema\Views\Orders\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tr>\r\n");
#nullable restore
#line 51 "C:\Users\Jose\Desktop\Mirandas-Cinema\Mirandas-Cinema\Mirandas-Cinema\Views\Orders\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591
