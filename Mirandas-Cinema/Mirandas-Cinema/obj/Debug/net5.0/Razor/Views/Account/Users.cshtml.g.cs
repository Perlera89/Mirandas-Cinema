#pragma checksum "C:\Users\Perlera\Documents\GitHub\Mirandas-Cinema\Mirandas-Cinema\Mirandas-Cinema\Views\Account\Users.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92efc3981cf35709b5cfdb65a8067f244ee22bf7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Users), @"mvc.1.0.view", @"/Views/Account/Users.cshtml")]
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
#nullable restore
#line 3 "C:\Users\Perlera\Documents\GitHub\Mirandas-Cinema\Mirandas-Cinema\Mirandas-Cinema\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92efc3981cf35709b5cfdb65a8067f244ee22bf7", @"/Views/Account/Users.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"663dac38ee6cf95f22ed6090dbe8ba64b2d7fbe8", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Users : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ApplicationUser>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Perlera\Documents\GitHub\Mirandas-Cinema\Mirandas-Cinema\Mirandas-Cinema\Views\Account\Users.cshtml"
  
    ViewData["Title"] = "Usuarios";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row nav-links col-md-12 m-auto"">
    <div class=""col-md-10 offset-1   mt-5 mb-5"">
        <p class=""mb-2"">
            <h3 class=""text-center"" style=""color: #237bac;"">Lista de usuarios</h3>
        </p>

        <table class=""table table-hover"">
            <thead class=""thead-dark"">
                <tr class=""text-center"">
                    <th>");
#nullable restore
#line 16 "C:\Users\Perlera\Documents\GitHub\Mirandas-Cinema\Mirandas-Cinema\Mirandas-Cinema\Views\Account\Users.cshtml"
                   Write(Html.DisplayNameFor(u => u.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 17 "C:\Users\Perlera\Documents\GitHub\Mirandas-Cinema\Mirandas-Cinema\Mirandas-Cinema\Views\Account\Users.cshtml"
                   Write(Html.DisplayNameFor(u => u.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 18 "C:\Users\Perlera\Documents\GitHub\Mirandas-Cinema\Mirandas-Cinema\Mirandas-Cinema\Views\Account\Users.cshtml"
                   Write(Html.DisplayNameFor(u => u.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 19 "C:\Users\Perlera\Documents\GitHub\Mirandas-Cinema\Mirandas-Cinema\Mirandas-Cinema\Views\Account\Users.cshtml"
                   Write(Html.DisplayNameFor(u => u.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 23 "C:\Users\Perlera\Documents\GitHub\Mirandas-Cinema\Mirandas-Cinema\Mirandas-Cinema\Views\Account\Users.cshtml"
                 foreach (var user in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td class=\"align-middle\">\r\n                        ");
#nullable restore
#line 27 "C:\Users\Perlera\Documents\GitHub\Mirandas-Cinema\Mirandas-Cinema\Mirandas-Cinema\Views\Account\Users.cshtml"
                   Write(Html.DisplayFor(modelItem => user.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"align-middle\">\r\n                        ");
#nullable restore
#line 30 "C:\Users\Perlera\Documents\GitHub\Mirandas-Cinema\Mirandas-Cinema\Mirandas-Cinema\Views\Account\Users.cshtml"
                   Write(Html.DisplayFor(modelItem => user.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"align-middle\">\r\n                        ");
#nullable restore
#line 33 "C:\Users\Perlera\Documents\GitHub\Mirandas-Cinema\Mirandas-Cinema\Mirandas-Cinema\Views\Account\Users.cshtml"
                   Write(Html.DisplayFor(modelItem => user.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"align-middle\">\r\n                        ");
#nullable restore
#line 36 "C:\Users\Perlera\Documents\GitHub\Mirandas-Cinema\Mirandas-Cinema\Mirandas-Cinema\Views\Account\Users.cshtml"
                   Write(Html.DisplayFor(modelItem => user.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 39 "C:\Users\Perlera\Documents\GitHub\Mirandas-Cinema\Mirandas-Cinema\Mirandas-Cinema\Views\Account\Users.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n\r\n        </table>\r\n\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ApplicationUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
