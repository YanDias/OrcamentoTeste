#pragma checksum "C:\Users\yanrd\source\repos\OrcamentoTeste\OrcamentoTeste\Views\ProdutoOrcamento\Cadastrar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "04a4fd763c761c827f332b4873006f7fea1934f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProdutoOrcamento_Cadastrar), @"mvc.1.0.view", @"/Views/ProdutoOrcamento/Cadastrar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ProdutoOrcamento/Cadastrar.cshtml", typeof(AspNetCore.Views_ProdutoOrcamento_Cadastrar))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04a4fd763c761c827f332b4873006f7fea1934f4", @"/Views/ProdutoOrcamento/Cadastrar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cdfd2e753003d581ee1605d71cebdb7fed379f61", @"/Views/_ViewImports.cshtml")]
    public class Views_ProdutoOrcamento_Cadastrar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Listar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Cadastrar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\yanrd\source\repos\OrcamentoTeste\OrcamentoTeste\Views\ProdutoOrcamento\Cadastrar.cshtml"
  
    List<dynamic> list = new List<dynamic>();
    ProdutoOrcamento pd = new ProdutoOrcamento();
    var cont = 0;



#line default
#line hidden
            BeginContext(127, 49, true);
            WriteLiteral("    <h2>Cadastro Or??amento</h2>\r\n    <br />\r\n    ");
            EndContext();
            BeginContext(176, 128, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4624a7e45d284962a5003580a357b29d", async() => {
                BeginContext(266, 34, true);
                WriteLiteral("\r\n        Concluir Or??amento\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 11 "C:\Users\yanrd\source\repos\OrcamentoTeste\OrcamentoTeste\Views\ProdutoOrcamento\Cadastrar.cshtml"
         WriteLiteral(ViewBag.Key);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(304, 14, true);
            WriteLiteral("\r\n    <br />\r\n");
            EndContext();
            BeginContext(320, 333, true);
            WriteLiteral(@"    <table class=""table table-hover table-striped""
           style=""margin-top:15px;margin-bottom:15px"">
        <thead>
            <tr>
                <th>Nome</th>
                <th>Valor</th>
                <th>Categoria</th>
                <th>Quantidade</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 28 "C:\Users\yanrd\source\repos\OrcamentoTeste\OrcamentoTeste\Views\ProdutoOrcamento\Cadastrar.cshtml"
             for (int i = 0; i < ViewBag.produtos.Count; i++)
            {

#line default
#line hidden
            BeginContext(731, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(778, 24, false);
#line 31 "C:\Users\yanrd\source\repos\OrcamentoTeste\OrcamentoTeste\Views\ProdutoOrcamento\Cadastrar.cshtml"
                   Write(ViewBag.produtos[i].nome);

#line default
#line hidden
            EndContext();
            BeginContext(802, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(834, 25, false);
#line 32 "C:\Users\yanrd\source\repos\OrcamentoTeste\OrcamentoTeste\Views\ProdutoOrcamento\Cadastrar.cshtml"
                   Write(ViewBag.produtos[i].Valor);

#line default
#line hidden
            EndContext();
            BeginContext(859, 35, true);
            WriteLiteral("</td>\r\n\r\n\r\n                    <td>");
            EndContext();
            BeginContext(895, 37, false);
#line 35 "C:\Users\yanrd\source\repos\OrcamentoTeste\OrcamentoTeste\Views\ProdutoOrcamento\Cadastrar.cshtml"
                   Write(ViewBag.produtos[i].SubCategoria.nome);

#line default
#line hidden
            EndContext();
            BeginContext(932, 61, true);
            WriteLiteral("</td>\r\n\r\n\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(993, 391, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "72cc6ba67d884a1baac31d0c9afad0ef", async() => {
                BeginContext(1036, 46, true);
                WriteLiteral("\r\n                            <input name=\"id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1082, "\"", 1120, 1);
#line 40 "C:\Users\yanrd\source\repos\OrcamentoTeste\OrcamentoTeste\Views\ProdutoOrcamento\Cadastrar.cshtml"
WriteAttributeValue("", 1090, ViewBag.produtos[i].idProduto, 1090, 30, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1121, 57, true);
                WriteLiteral(" hidden />\r\n                            <input name=\"key\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1178, "\"", 1198, 1);
#line 41 "C:\Users\yanrd\source\repos\OrcamentoTeste\OrcamentoTeste\Views\ProdutoOrcamento\Cadastrar.cshtml"
WriteAttributeValue("", 1186, ViewBag.Key, 1186, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1199, 178, true);
                WriteLiteral(" hidden />\r\n                            <input name=\"quantidade\" type=\"number\" />\r\n                            <input type=\"submit\" value=\"Adicionar\" />\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1384, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 47 "C:\Users\yanrd\source\repos\OrcamentoTeste\OrcamentoTeste\Views\ProdutoOrcamento\Cadastrar.cshtml"
                cont++;
            }

#line default
#line hidden
            BeginContext(1476, 44, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n        </tbody>\r\n\r\n    </table>\r\n");
            EndContext();
#line 58 "C:\Users\yanrd\source\repos\OrcamentoTeste\OrcamentoTeste\Views\ProdutoOrcamento\Cadastrar.cshtml"
      if(ViewBag.selecionados != null)
    {

#line default
#line hidden
            BeginContext(1569, 332, true);
            WriteLiteral(@"        <table class=""table"">
            <thead class=""table-info"">
                ...
                <tr>
                    <th>Nome</th>
                    <th>Valor</th>
                    <th>Categoria</th>
                    <th>Quantidade</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 71 "C:\Users\yanrd\source\repos\OrcamentoTeste\OrcamentoTeste\Views\ProdutoOrcamento\Cadastrar.cshtml"
                 for (int i = 0; i < ViewBag.selecionados.Count; i++)
                {

#line default
#line hidden
            BeginContext(1991, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(2046, 36, false);
#line 74 "C:\Users\yanrd\source\repos\OrcamentoTeste\OrcamentoTeste\Views\ProdutoOrcamento\Cadastrar.cshtml"
                       Write(ViewBag.selecionados[i].Produto.nome);

#line default
#line hidden
            EndContext();
            BeginContext(2082, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(2118, 37, false);
#line 75 "C:\Users\yanrd\source\repos\OrcamentoTeste\OrcamentoTeste\Views\ProdutoOrcamento\Cadastrar.cshtml"
                       Write(ViewBag.selecionados[i].Produto.Valor);

#line default
#line hidden
            EndContext();
            BeginContext(2155, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(2191, 49, false);
#line 76 "C:\Users\yanrd\source\repos\OrcamentoTeste\OrcamentoTeste\Views\ProdutoOrcamento\Cadastrar.cshtml"
                       Write(ViewBag.selecionados[i].Produto.SubCategoria.nome);

#line default
#line hidden
            EndContext();
            BeginContext(2240, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(2276, 34, false);
#line 77 "C:\Users\yanrd\source\repos\OrcamentoTeste\OrcamentoTeste\Views\ProdutoOrcamento\Cadastrar.cshtml"
                       Write(ViewBag.selecionados[i].Quantidade);

#line default
#line hidden
            EndContext();
            BeginContext(2310, 36, true);
            WriteLiteral("</td>\r\n\r\n                    </tr>\r\n");
            EndContext();
#line 80 "C:\Users\yanrd\source\repos\OrcamentoTeste\OrcamentoTeste\Views\ProdutoOrcamento\Cadastrar.cshtml"
                    cont++;
                }

#line default
#line hidden
            BeginContext(2394, 48, true);
            WriteLiteral("\r\n\r\n\r\n\r\n            </tbody>\r\n        </table>\r\n");
            EndContext();
#line 88 "C:\Users\yanrd\source\repos\OrcamentoTeste\OrcamentoTeste\Views\ProdutoOrcamento\Cadastrar.cshtml"
    }

#line default
#line hidden
            BeginContext(2452, 10, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
