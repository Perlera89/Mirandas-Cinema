#pragma checksum "C:\Users\Perlera\Documents\GitHub\Mirandas-Cinema\Mirandas-Cinema\Mirandas-Cinema\Views\Movies\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4fad4be32324308bff492320573601cf6931e880"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_Index), @"mvc.1.0.view", @"/Views/Movies/Index.cshtml")]
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
#line 1 "C:\Users\Perlera\Documents\GitHub\Mirandas-Cinema\Mirandas-Cinema\Mirandas-Cinema\Views\_ViewImports.cshtml"
using Mirandas_Cinema;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Perlera\Documents\GitHub\Mirandas-Cinema\Mirandas-Cinema\Mirandas-Cinema\Views\_ViewImports.cshtml"
using Mirandas_Cinema.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fad4be32324308bff492320573601cf6931e880", @"/Views/Movies/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33d2615a146caefa1b37fc997671e93d2c5bd807", @"/Views/_ViewImports.cshtml")]
    public class Views_Movies_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Movie>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/nav-bar.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4fad4be32324308bff492320573601cf6931e8803871", async() => {
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
#line 4 "C:\Users\Perlera\Documents\GitHub\Mirandas-Cinema\Mirandas-Cinema\Mirandas-Cinema\Views\Movies\Index.cshtml"
  
    ViewData["Title"] = "Movies";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row nav-links\" style=\"margin: 0 auto 50px; max-width: 1300px;\">\r\n");
#nullable restore
#line 9 "C:\Users\Perlera\Documents\GitHub\Mirandas-Cinema\Mirandas-Cinema\Mirandas-Cinema\Views\Movies\Index.cshtml"
     foreach (var movie in Model) 
     {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""col-md-4 col-xs-6 border-primary mb-3 nav-links"">
            <div class=""card mb-3"" style=""max-width: 540px"">
                <div class=""row g-0"">
                    <div class=""col-md-12"">
                        <div class=""card-header text-white bg-primary"">
                            <p class=""card-text"">
                                <h5 class=""card-title"">
                                    ");
#nullable restore
#line 18 "C:\Users\Perlera\Documents\GitHub\Mirandas-Cinema\Mirandas-Cinema\Mirandas-Cinema\Views\Movies\Index.cshtml"
                               Write(movie.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    <a class=""text-white float-right""><i class=""bi bi-pencil-square""></i></a>
                                </h5>
                            </p>
                        </div>
                    </div>
                </div>
                <div class=""col-md-12 justify-content-center"">
                    <img");
            BeginWriteAttribute("src", " src=\"", 1049, "\"", 1071, 1);
#nullable restore
#line 26 "C:\Users\Perlera\Documents\GitHub\Mirandas-Cinema\Mirandas-Cinema\Mirandas-Cinema\Views\Movies\Index.cshtml"
WriteAttributeValue("", 1055, movie.ImagenURL, 1055, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1072, "\"", 1089, 1);
#nullable restore
#line 26 "C:\Users\Perlera\Documents\GitHub\Mirandas-Cinema\Mirandas-Cinema\Mirandas-Cinema\Views\Movies\Index.cshtml"
WriteAttributeValue("", 1078, movie.Name, 1078, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"100%\" style=\"max-width: 200px;\"/>\r\n                </div>\r\n                <div class=\"col-md-12 float-left\">\r\n                    <div class=\"card-body\">\r\n");
            WriteLiteral("                        <p class=\"card-text\"><b>Fecha de inicio:</b> ");
#nullable restore
#line 33 "C:\Users\Perlera\Documents\GitHub\Mirandas-Cinema\Mirandas-Cinema\Mirandas-Cinema\Views\Movies\Index.cshtml"
                                                                Write(movie.StartDate.ToString("dd MMMM yy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p class=\"card-text\"><b>Fecha de finalizacion:</b> ");
#nullable restore
#line 34 "C:\Users\Perlera\Documents\GitHub\Mirandas-Cinema\Mirandas-Cinema\Mirandas-Cinema\Views\Movies\Index.cshtml"
                                                                      Write(movie.EndDate.ToString("dd MMMM yy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p class=\"card-text\">\r\n                            <b>Estado: </b>\r\n");
#nullable restore
#line 37 "C:\Users\Perlera\Documents\GitHub\Mirandas-Cinema\Mirandas-Cinema\Mirandas-Cinema\Views\Movies\Index.cshtml"
                             if (DateTime.Now >= movie.StartDate && DateTime.Now <= movie.EndDate)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span class=\"badge bg-success text-white\">Disponible</span>\r\n");
#nullable restore
#line 40 "C:\Users\Perlera\Documents\GitHub\Mirandas-Cinema\Mirandas-Cinema\Mirandas-Cinema\Views\Movies\Index.cshtml"
                            }
                            else if (DateTime.Now > movie.EndDate)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span class=\"badge bg-danger text-white\">Expirada</span>\r\n");
#nullable restore
#line 44 "C:\Users\Perlera\Documents\GitHub\Mirandas-Cinema\Mirandas-Cinema\Mirandas-Cinema\Views\Movies\Index.cshtml"
                            } else 
                            { 

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span class=\"badge bg-primary text-white\">Muy pronto</span>\r\n");
#nullable restore
#line 47 "C:\Users\Perlera\Documents\GitHub\Mirandas-Cinema\Mirandas-Cinema\Mirandas-Cinema\Views\Movies\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </p>
                    </div>
                </div>
                <div class=""col-md-12"">
                    <div class=""card-footer"">
                        <p class=""card-text"">
                            <a class=""btn btn-primary text-white float-right""><i class=""bi bi-eye-fill""></i> Detalles</a>
                            <a class=""btn btn-success text-white""><i class=""bi bi-cart-plus""></i> Agregar (");
#nullable restore
#line 55 "C:\Users\Perlera\Documents\GitHub\Mirandas-Cinema\Mirandas-Cinema\Mirandas-Cinema\Views\Movies\Index.cshtml"
                                                                                                      Write(movie.Price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral(")</a>\r\n                        </p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 61 "C:\Users\Perlera\Documents\GitHub\Mirandas-Cinema\Mirandas-Cinema\Mirandas-Cinema\Views\Movies\Index.cshtml"
     }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Movie>> Html { get; private set; }
    }
}
#pragma warning restore 1591
