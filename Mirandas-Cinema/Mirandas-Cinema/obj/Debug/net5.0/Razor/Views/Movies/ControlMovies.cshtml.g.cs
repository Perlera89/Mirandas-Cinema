#pragma checksum "C:\Users\Ari Soriano\Documents\GitHub\Mirandas-Cinema\Mirandas-Cinema\Mirandas-Cinema\Views\Movies\ControlMovies.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2dbbd0abbdf5e17fe964c6b2084c299954e48af8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_ControlMovies), @"mvc.1.0.view", @"/Views/Movies/ControlMovies.cshtml")]
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
#line 1 "C:\Users\Ari Soriano\Documents\GitHub\Mirandas-Cinema\Mirandas-Cinema\Mirandas-Cinema\Views\_ViewImports.cshtml"
using Mirandas_Cinema;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ari Soriano\Documents\GitHub\Mirandas-Cinema\Mirandas-Cinema\Mirandas-Cinema\Views\_ViewImports.cshtml"
using Mirandas_Cinema.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ari Soriano\Documents\GitHub\Mirandas-Cinema\Mirandas-Cinema\Mirandas-Cinema\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ari Soriano\Documents\GitHub\Mirandas-Cinema\Mirandas-Cinema\Mirandas-Cinema\Views\_ViewImports.cshtml"
using Mirandas_Cinema.Data.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Ari Soriano\Documents\GitHub\Mirandas-Cinema\Mirandas-Cinema\Mirandas-Cinema\Views\_ViewImports.cshtml"
using Mirandas_Cinema.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2dbbd0abbdf5e17fe964c6b2084c299954e48af8", @"/Views/Movies/ControlMovies.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52e7edb9783f1c8adefe858751918dad49c87e84", @"/Views/_ViewImports.cshtml")]
    public class Views_Movies_ControlMovies : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Mirandas_Cinema.Models.Movie>>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Ari Soriano\Documents\GitHub\Mirandas-Cinema\Mirandas-Cinema\Mirandas-Cinema\Views\Movies\ControlMovies.cshtml"
   ViewData["Title"] = "Details"; 

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2dbbd0abbdf5e17fe964c6b2084c299954e48af85038", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2dbbd0abbdf5e17fe964c6b2084c299954e48af85300", async() => {
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
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.2/css/all.min.css\" />\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<style type=""text/css"">
    body div.contenedor_general {
        margin-top: 3em;
        margin-bottom: 3em;
        border: 1px solid gainsboro;
        border-radius: 14px;
        padding: 1em;
        font-size: 12pt;
        background-color: white;
    }

    .btn_success {
        float: right;
    }

    h3 {
        margin-top: 1em;
    }
</style>

<div class=""wow0 contenedor_general animate__animated animate__fadeInDown"" data-wow-offset=""0"" data-wow-iteration=""1"" data-wow-duration=""2s"">
    <h3 style=""text-align:center;"">CONTROL DE PELICULAS</h3>
    <!--mostrar el formulario de la derecha-->
    <button class=""btn btn_success"" type=""button"" role=""button"">
        ");
#nullable restore
#line 32 "C:\Users\Ari Soriano\Documents\GitHub\Mirandas-Cinema\Mirandas-Cinema\Mirandas-Cinema\Views\Movies\ControlMovies.cshtml"
   Write(Html.ActionLink("Agregar", "ControlMovie"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </button>

    <table id=""movies"" class=""table table-hover"">
        <!--estilo basio de B... para tablas-->
        <thead class=""thead-dark"">
            <!--clase de bootstrap para dar fondo a los head-->
            <tr class=""fila"">
                <th hidden>Id</th>
                <th>Nombre</th>
                <th hidden>Descripcion</th>
                <th>Cinema</th>
                <th>Productor</th>
                <th>Precio</th>
                <th>Categoria</th>
                <th>Inicio</th>
                <th>Finalización</th>
                <th hidden>Foto</th>
                <th colspan=""2"" style=""text-align:center;"">Acciones</th>
                <th></th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 55 "C:\Users\Ari Soriano\Documents\GitHub\Mirandas-Cinema\Mirandas-Cinema\Mirandas-Cinema\Views\Movies\ControlMovies.cshtml"
             foreach (var i in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td hidden>");
#nullable restore
#line 58 "C:\Users\Ari Soriano\Documents\GitHub\Mirandas-Cinema\Mirandas-Cinema\Mirandas-Cinema\Views\Movies\ControlMovies.cshtml"
                          Write(i.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <th>");
#nullable restore
#line 59 "C:\Users\Ari Soriano\Documents\GitHub\Mirandas-Cinema\Mirandas-Cinema\Mirandas-Cinema\Views\Movies\ControlMovies.cshtml"
                   Write(i.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <td hidden>");
#nullable restore
#line 60 "C:\Users\Ari Soriano\Documents\GitHub\Mirandas-Cinema\Mirandas-Cinema\Mirandas-Cinema\Views\Movies\ControlMovies.cshtml"
                          Write(i.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 61 "C:\Users\Ari Soriano\Documents\GitHub\Mirandas-Cinema\Mirandas-Cinema\Mirandas-Cinema\Views\Movies\ControlMovies.cshtml"
                   Write(i.Cinema.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 62 "C:\Users\Ari Soriano\Documents\GitHub\Mirandas-Cinema\Mirandas-Cinema\Mirandas-Cinema\Views\Movies\ControlMovies.cshtml"
                   Write(i.Producer.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 63 "C:\Users\Ari Soriano\Documents\GitHub\Mirandas-Cinema\Mirandas-Cinema\Mirandas-Cinema\Views\Movies\ControlMovies.cshtml"
                   Write(i.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 64 "C:\Users\Ari Soriano\Documents\GitHub\Mirandas-Cinema\Mirandas-Cinema\Mirandas-Cinema\Views\Movies\ControlMovies.cshtml"
                   Write(i.MovieCategory);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 65 "C:\Users\Ari Soriano\Documents\GitHub\Mirandas-Cinema\Mirandas-Cinema\Mirandas-Cinema\Views\Movies\ControlMovies.cshtml"
                   Write(i.StartDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 66 "C:\Users\Ari Soriano\Documents\GitHub\Mirandas-Cinema\Mirandas-Cinema\Mirandas-Cinema\Views\Movies\ControlMovies.cshtml"
                   Write(i.EndDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td hidden>");
#nullable restore
#line 67 "C:\Users\Ari Soriano\Documents\GitHub\Mirandas-Cinema\Mirandas-Cinema\Mirandas-Cinema\Views\Movies\ControlMovies.cshtml"
                          Write(i.ImagenURL);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <th>\r\n                        <button type=\"button\" class=\" btn btn_details\">");
#nullable restore
#line 69 "C:\Users\Ari Soriano\Documents\GitHub\Mirandas-Cinema\Mirandas-Cinema\Mirandas-Cinema\Views\Movies\ControlMovies.cshtml"
                                                                  Write(Html.ActionLink("Actualizar", "Update", "Movies", new { id = i.Id}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                    </th>\r\n                    <th>\r\n                        <button type=\"button\" class=\" btn btn_delete\">");
#nullable restore
#line 72 "C:\Users\Ari Soriano\Documents\GitHub\Mirandas-Cinema\Mirandas-Cinema\Mirandas-Cinema\Views\Movies\ControlMovies.cshtml"
                                                                 Write(Html.ActionLink("Eliminar", "DeleteMovies", "Movies", new { Id_2 = i.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                    </th>\r\n\r\n                </tr>\r\n");
#nullable restore
#line 76 "C:\Users\Ari Soriano\Documents\GitHub\Mirandas-Cinema\Mirandas-Cinema\Mirandas-Cinema\Views\Movies\ControlMovies.cshtml"
              }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </tbody>\r\n    </table>\r\n\r\n\r\n</div>\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n\r\n    <script src=\"https://cdn.datatables.net/1.11.3/js/jquery.dataTables.min.js\"></script>\r\n    <script>\r\n        $(document).ready(function () {\r\n            var tabla = $(\"#movies\").DataTable();\r\n        });\r\n    </script>\r\n\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Mirandas_Cinema.Models.Movie>> Html { get; private set; }
    }
}
#pragma warning restore 1591
