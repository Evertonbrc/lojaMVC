#pragma checksum "C:\Users\econceicao\Documents\Fatec\LojaVirtual\Views\Produto\Visualizar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9964524d12c8bd19274d94c50f2dde662013a8c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_Visualizar), @"mvc.1.0.view", @"/Views/Produto/Visualizar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Produto/Visualizar.cshtml", typeof(AspNetCore.Views_Produto_Visualizar))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9964524d12c8bd19274d94c50f2dde662013a8c1", @"/Views/Produto/Visualizar.cshtml")]
    public class Views_Produto_Visualizar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<lojaVirtual.Models.Produto>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(34, 82, true);
            WriteLiteral("\n<h3>Produto -> Visualizar</h3>\n:)\n<br />\n\nRazor:\n<h2>Produto</h2>\n<b>Código: </b>");
            EndContext();
            BeginContext(117, 8, false);
#line 9 "C:\Users\econceicao\Documents\Fatec\LojaVirtual\Views\Produto\Visualizar.cshtml"
          Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(125, 20, true);
            WriteLiteral("<br />\n<b>Nome: </b>");
            EndContext();
            BeginContext(146, 10, false);
#line 10 "C:\Users\econceicao\Documents\Fatec\LojaVirtual\Views\Produto\Visualizar.cshtml"
        Write(Model.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(156, 25, true);
            WriteLiteral("<br />\n<b>Descrição: </b>");
            EndContext();
            BeginContext(182, 15, false);
#line 11 "C:\Users\econceicao\Documents\Fatec\LojaVirtual\Views\Produto\Visualizar.cshtml"
             Write(Model.Descricao);

#line default
#line hidden
            EndContext();
            BeginContext(197, 21, true);
            WriteLiteral("<br />\n<b>Valor: </b>");
            EndContext();
            BeginContext(219, 25, false);
#line 12 "C:\Users\econceicao\Documents\Fatec\LojaVirtual\Views\Produto\Visualizar.cshtml"
         Write(Model.Valor.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(244, 83, true);
            WriteLiteral("\n\n<br />\n<br />\n<br />\n<br />\n<br />\n<br />\n\nTodos os Direitos Reservados &copy; - ");
            EndContext();
            BeginContext(328, 17, false);
#line 21 "C:\Users\econceicao\Documents\Fatec\LojaVirtual\Views\Produto\Visualizar.cshtml"
                                 Write(DateTime.Now.Year);

#line default
#line hidden
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<lojaVirtual.Models.Produto> Html { get; private set; }
    }
}
#pragma warning restore 1591
