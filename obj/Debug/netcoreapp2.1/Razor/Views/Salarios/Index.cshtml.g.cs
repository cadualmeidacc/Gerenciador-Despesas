#pragma checksum "C:\Users\Eduardo\3D Objects\GerenciadorDespesas\GerenciadorDespesas\Views\Salarios\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f694614f7e15ce733feae303873f270eec8c8ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Salarios_Index), @"mvc.1.0.view", @"/Views/Salarios/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Salarios/Index.cshtml", typeof(AspNetCore.Views_Salarios_Index))]
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
#line 1 "C:\Users\Eduardo\3D Objects\GerenciadorDespesas\GerenciadorDespesas\Views\_ViewImports.cshtml"
using GerenciadorDespesas;

#line default
#line hidden
#line 2 "C:\Users\Eduardo\3D Objects\GerenciadorDespesas\GerenciadorDespesas\Views\_ViewImports.cshtml"
using GerenciadorDespesas.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f694614f7e15ce733feae303873f270eec8c8ec", @"/Views/Salarios/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e664b9738aca7e4a1bde60a9118593ebe932cfa2", @"/Views/_ViewImports.cshtml")]
    public class Views_Salarios_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<GerenciadorDespesas.Models.Salarios>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(57, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Eduardo\3D Objects\GerenciadorDespesas\GerenciadorDespesas\Views\Salarios\Index.cshtml"
  
    ViewData["Title"] = "Salarios Cadastrados";

#line default
#line hidden
            BeginContext(115, 135, true);
            WriteLiteral("\r\n<div class=\"tabela\">\r\n    <div class=\"container\">\r\n        <h6>Salários Cadastrados</h6>\r\n\r\n        <p class=\"btnNovo\">\r\n            ");
            EndContext();
            BeginContext(250, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f694614f7e15ce733feae303873f270eec8c8ec5154", async() => {
                BeginContext(312, 12, true);
                WriteLiteral("Novo Salário");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(328, 18, true);
            WriteLiteral("\r\n        </p>\r\n\r\n");
            EndContext();
#line 15 "C:\Users\Eduardo\3D Objects\GerenciadorDespesas\GerenciadorDespesas\Views\Salarios\Index.cshtml"
         if(TempData["Confirmacao"] != null)
        {

#line default
#line hidden
            BeginContext(403, 61, true);
            WriteLiteral("            <h6 class=\"alert alert-sucess\">\r\n                ");
            EndContext();
            BeginContext(465, 23, false);
#line 18 "C:\Users\Eduardo\3D Objects\GerenciadorDespesas\GerenciadorDespesas\Views\Salarios\Index.cshtml"
           Write(TempData["Confirmacao"]);

#line default
#line hidden
            EndContext();
            BeginContext(488, 21, true);
            WriteLiteral("\r\n            </h6>\r\n");
            EndContext();
#line 20 "C:\Users\Eduardo\3D Objects\GerenciadorDespesas\GerenciadorDespesas\Views\Salarios\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(520, 138, true);
            WriteLiteral("\r\n        <table class=\"table table-hover\">\r\n            <thead>\r\n                <tr>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(659, 41, false);
#line 26 "C:\Users\Eduardo\3D Objects\GerenciadorDespesas\GerenciadorDespesas\Views\Salarios\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Meses));

#line default
#line hidden
            EndContext();
            BeginContext(700, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(780, 41, false);
#line 29 "C:\Users\Eduardo\3D Objects\GerenciadorDespesas\GerenciadorDespesas\Views\Salarios\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Valor));

#line default
#line hidden
            EndContext();
            BeginContext(821, 126, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
            EndContext();
#line 35 "C:\Users\Eduardo\3D Objects\GerenciadorDespesas\GerenciadorDespesas\Views\Salarios\Index.cshtml"
         foreach (var item in Model) {

#line default
#line hidden
            BeginContext(987, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1060, 45, false);
#line 38 "C:\Users\Eduardo\3D Objects\GerenciadorDespesas\GerenciadorDespesas\Views\Salarios\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Meses.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(1105, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1185, 40, false);
#line 41 "C:\Users\Eduardo\3D Objects\GerenciadorDespesas\GerenciadorDespesas\Views\Salarios\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Valor));

#line default
#line hidden
            EndContext();
            BeginContext(1225, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1304, 101, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f694614f7e15ce733feae303873f270eec8c8ec10048", async() => {
                BeginContext(1392, 9, true);
                WriteLiteral("Atualizar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 44 "C:\Users\Eduardo\3D Objects\GerenciadorDespesas\GerenciadorDespesas\Views\Salarios\Index.cshtml"
                                               WriteLiteral(item.SalarioId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1405, 30, true);
            WriteLiteral(" |\r\n                        <a");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1435, "\"", 1473, 3);
            WriteAttributeValue("", 1445, "ExibirModal(", 1445, 12, true);
#line 45 "C:\Users\Eduardo\3D Objects\GerenciadorDespesas\GerenciadorDespesas\Views\Salarios\Index.cshtml"
WriteAttributeValue("", 1457, item.SalarioId, 1457, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 1472, ")", 1472, 1, true);
            EndWriteAttribute();
            BeginContext(1474, 102, true);
            WriteLiteral(" class=\"btn btn-outline-danger btn-sm\">Excluir</a>\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 48 "C:\Users\Eduardo\3D Objects\GerenciadorDespesas\GerenciadorDespesas\Views\Salarios\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1587, 885, true);
            WriteLiteral(@"            </tbody>
        </table>
    </div>
</div>

<div class=""modal"" tabindex=""-1"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Excluir</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <p>Deseja prosseguir com a exclusão do salário</p>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-outline-primary btnExcluir"">Sim</button>
                <button type=""button"" class=""btn btn-outline-danger"" data-dismiss=""modal"">Não</button>
            </div>
        </div>
    </div>
</div>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2490, 528, true);
                WriteLiteral(@"
    <script>
        function ExibirModal(id) {

            $("".modal"").modal();

            $("".btnExcluir"").on('click', function () {
                $.ajax({
                    url: ""Salarios/Delete"",
                    method: ""POST"",
                    data: { id: id },
                    success: function (data) {
                        $("".modal"").modal('hide');
                        location.reload(true);
                    }
                });
            });
        }
    </script>
");
                EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<GerenciadorDespesas.Models.Salarios>> Html { get; private set; }
    }
}
#pragma warning restore 1591
