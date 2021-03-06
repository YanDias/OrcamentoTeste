#pragma checksum "C:\Users\yanrd\source\repos\OrcamentoTeste\OrcamentoTeste\Views\ProdutoOrcamento\Listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "400ebb8950d719b0433db9323f458dc0d4e88544"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProdutoOrcamento_Listar), @"mvc.1.0.view", @"/Views/ProdutoOrcamento/Listar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ProdutoOrcamento/Listar.cshtml", typeof(AspNetCore.Views_ProdutoOrcamento_Listar))]
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
#line 1 "C:\Users\yanrd\source\repos\OrcamentoTeste\OrcamentoTeste\Views\_ViewImports.cshtml"
using OrcamentoTeste;

#line default
#line hidden
#line 2 "C:\Users\yanrd\source\repos\OrcamentoTeste\OrcamentoTeste\Views\_ViewImports.cshtml"
using Domain;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"400ebb8950d719b0433db9323f458dc0d4e88544", @"/Views/ProdutoOrcamento/Listar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cdfd2e753003d581ee1605d71cebdb7fed379f61", @"/Views/_ViewImports.cshtml")]
    public class Views_ProdutoOrcamento_Listar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ProdutoOrcamento>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Remover", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\yanrd\source\repos\OrcamentoTeste\OrcamentoTeste\Views\ProdutoOrcamento\Listar.cshtml"
  
    double vltP;
    double vltS ;
    double vlTotal = 0;
    

#line default
#line hidden
            BeginContext(106, 26, true);
            WriteLiteral("<div>\r\n    <h2>Or??amento: ");
            EndContext();
            BeginContext(133, 12, false);
#line 9 "C:\Users\yanrd\source\repos\OrcamentoTeste\OrcamentoTeste\Views\ProdutoOrcamento\Listar.cshtml"
              Write(ViewBag.nome);

#line default
#line hidden
            EndContext();
            BeginContext(145, 393, true);
            WriteLiteral(@" </h2>
    <table class=""table table-hover table-striped""
           style=""margin-top:15px;margin-bottom:15px"">
        <thead>
            <tr>
                <th>Produto</th>
                <th>Categoria</th>
                <th>Valor Unitario</th>
                <th>Quantidade</th>
                <th>Valor Total</th>

            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 23 "C:\Users\yanrd\source\repos\OrcamentoTeste\OrcamentoTeste\Views\ProdutoOrcamento\Listar.cshtml"
             foreach (ProdutoOrcamento item in Model)
            {
               
                vltP = @item.Quantidade * @item.Produto.Valor;
                vlTotal = vlTotal + vltP;
            

#line default
#line hidden
            BeginContext(744, 26, true);
            WriteLiteral("<tr>\r\n                <td>");
            EndContext();
            BeginContext(771, 17, false);
#line 29 "C:\Users\yanrd\source\repos\OrcamentoTeste\OrcamentoTeste\Views\ProdutoOrcamento\Listar.cshtml"
               Write(item.Produto.nome);

#line default
#line hidden
            EndContext();
            BeginContext(788, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(816, 30, false);
#line 30 "C:\Users\yanrd\source\repos\OrcamentoTeste\OrcamentoTeste\Views\ProdutoOrcamento\Listar.cshtml"
               Write(item.Produto.SubCategoria.nome);

#line default
#line hidden
            EndContext();
            BeginContext(846, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(874, 18, false);
#line 31 "C:\Users\yanrd\source\repos\OrcamentoTeste\OrcamentoTeste\Views\ProdutoOrcamento\Listar.cshtml"
               Write(item.Produto.Valor);

#line default
#line hidden
            EndContext();
            BeginContext(892, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(920, 15, false);
#line 32 "C:\Users\yanrd\source\repos\OrcamentoTeste\OrcamentoTeste\Views\ProdutoOrcamento\Listar.cshtml"
               Write(item.Quantidade);

#line default
#line hidden
            EndContext();
            BeginContext(935, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(963, 4, false);
#line 33 "C:\Users\yanrd\source\repos\OrcamentoTeste\OrcamentoTeste\Views\ProdutoOrcamento\Listar.cshtml"
               Write(vltP);

#line default
#line hidden
            EndContext();
            BeginContext(967, 82, true);
            WriteLiteral("</td>\r\n\r\n                <td>\r\n                    <div>\r\n                        ");
            EndContext();
            BeginContext(1049, 349, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a97a9844f3644973b479a37eedd87448", async() => {
                BeginContext(1090, 46, true);
                WriteLiteral("\r\n                            <input name=\"id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1136, "\"", 1168, 1);
#line 38 "C:\Users\yanrd\source\repos\OrcamentoTeste\OrcamentoTeste\Views\ProdutoOrcamento\Listar.cshtml"
WriteAttributeValue("", 1144, item.IdProdutoOrcamento, 1144, 24, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1169, 57, true);
                WriteLiteral(" hidden />\r\n                            <input name=\"key\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1226, "\"", 1261, 1);
#line 39 "C:\Users\yanrd\source\repos\OrcamentoTeste\OrcamentoTeste\Views\ProdutoOrcamento\Listar.cshtml"
WriteAttributeValue("", 1234, item.Orcamento.IdOrcamento, 1234, 27, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1262, 129, true);
                WriteLiteral(" hidden />\r\n                            <input type=\"submit\" class=\"btn btn-warning\" value=\"Remover\" />\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1398, 74, true);
            WriteLiteral("\r\n                    </div>\r\n                </td>\r\n\r\n            </tr>\r\n");
            EndContext();
#line 46 "C:\Users\yanrd\source\repos\OrcamentoTeste\OrcamentoTeste\Views\ProdutoOrcamento\Listar.cshtml"
                
                
            }

#line default
#line hidden
            BeginContext(1523, 81, true);
            WriteLiteral("\r\n\r\n\r\n        </tbody>\r\n    </table>\r\n<h4 align=\"right\">Valor Total do Or??amento ");
            EndContext();
            BeginContext(1605, 7, false);
#line 54 "C:\Users\yanrd\source\repos\OrcamentoTeste\OrcamentoTeste\Views\ProdutoOrcamento\Listar.cshtml"
                                      Write(vlTotal);

#line default
#line hidden
            EndContext();
            BeginContext(1612, 21, true);
            WriteLiteral("</h4>\r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ProdutoOrcamento>> Html { get; private set; }
    }
}
#pragma warning restore 1591
