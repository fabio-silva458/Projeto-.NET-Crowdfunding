#pragma checksum "C:\Users\Hp\Desktop\steck-tests\dotnet-vaquinha-tests\src\Vaquinha.MVC\Views\Doadores\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5013497d883d7d0956fa7b9ae5ee7386c07528ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Doadores_Index), @"mvc.1.0.view", @"/Views/Doadores/Index.cshtml")]
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
#line 1 "C:\Users\Hp\Desktop\steck-tests\dotnet-vaquinha-tests\src\Vaquinha.MVC\Views\_ViewImports.cshtml"
using Vaquinha.MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Hp\Desktop\steck-tests\dotnet-vaquinha-tests\src\Vaquinha.MVC\Views\_ViewImports.cshtml"
using Vaquinha.MVC.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Hp\Desktop\steck-tests\dotnet-vaquinha-tests\src\Vaquinha.MVC\Views\Doadores\Index.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5013497d883d7d0956fa7b9ae5ee7386c07528ec", @"/Views/Doadores/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d02e3e1f708194b12af526d02b17c9487e8f1a0e", @"/Views/_ViewImports.cshtml")]
    public class Views_Doadores_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Vaquinha.Domain.ViewModels.DoadorViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(" \r\n");
#nullable restore
#line 4 "C:\Users\Hp\Desktop\steck-tests\dotnet-vaquinha-tests\src\Vaquinha.MVC\Views\Doadores\Index.cshtml"
  
    ViewData["Title"] = "Doadores";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h3>Veja quem já doou!</h3>\r\n    <hr />\r\n</div>\r\n\r\n\r\n<table class=\"table table-striped table-bordered text-center\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 18 "C:\Users\Hp\Desktop\steck-tests\dotnet-vaquinha-tests\src\Vaquinha.MVC\Views\Doadores\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 21 "C:\Users\Hp\Desktop\steck-tests\dotnet-vaquinha-tests\src\Vaquinha.MVC\Views\Doadores\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MensagemApoio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 24 "C:\Users\Hp\Desktop\steck-tests\dotnet-vaquinha-tests\src\Vaquinha.MVC\Views\Doadores\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Valor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 27 "C:\Users\Hp\Desktop\steck-tests\dotnet-vaquinha-tests\src\Vaquinha.MVC\Views\Doadores\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DescricaoTempo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 32 "C:\Users\Hp\Desktop\steck-tests\dotnet-vaquinha-tests\src\Vaquinha.MVC\Views\Doadores\Index.cshtml"
         if (Model.Any())
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\Hp\Desktop\steck-tests\dotnet-vaquinha-tests\src\Vaquinha.MVC\Views\Doadores\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 38 "C:\Users\Hp\Desktop\steck-tests\dotnet-vaquinha-tests\src\Vaquinha.MVC\Views\Doadores\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 41 "C:\Users\Hp\Desktop\steck-tests\dotnet-vaquinha-tests\src\Vaquinha.MVC\Views\Doadores\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.MensagemApoio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <span>");
#nullable restore
#line 44 "C:\Users\Hp\Desktop\steck-tests\dotnet-vaquinha-tests\src\Vaquinha.MVC\Views\Doadores\Index.cshtml"
                         Write(item.Valor.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 47 "C:\Users\Hp\Desktop\steck-tests\dotnet-vaquinha-tests\src\Vaquinha.MVC\Views\Doadores\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.DescricaoTempo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 50 "C:\Users\Hp\Desktop\steck-tests\dotnet-vaquinha-tests\src\Vaquinha.MVC\Views\Doadores\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\Hp\Desktop\steck-tests\dotnet-vaquinha-tests\src\Vaquinha.MVC\Views\Doadores\Index.cshtml"
             
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td colspan=\"4\">\r\n                    <center> <span class=\"text-center\">Ainda não houveram doações. Seja você o primeiro!</span></center>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 59 "C:\Users\Hp\Desktop\steck-tests\dotnet-vaquinha-tests\src\Vaquinha.MVC\Views\Doadores\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Vaquinha.Domain.ViewModels.DoadorViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
