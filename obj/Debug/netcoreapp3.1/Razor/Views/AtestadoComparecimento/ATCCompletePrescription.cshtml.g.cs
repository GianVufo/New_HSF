#pragma checksum "C:\Users\gianluca.vialli\Desktop\Hsf_Receituario\Views\AtestadoComparecimento\ATCCompletePrescription.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6993bffe22735b209737eaf84bba529e03970e49"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AtestadoComparecimento_ATCCompletePrescription), @"mvc.1.0.view", @"/Views/AtestadoComparecimento/ATCCompletePrescription.cshtml")]
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
#line 1 "C:\Users\gianluca.vialli\Desktop\Hsf_Receituario\Views\_ViewImports.cshtml"
using Hsf_Receitas;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gianluca.vialli\Desktop\Hsf_Receituario\Views\AtestadoComparecimento\ATCCompletePrescription.cshtml"
using Hsf_Receitas.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\gianluca.vialli\Desktop\Hsf_Receituario\Views\AtestadoComparecimento\ATCCompletePrescription.cshtml"
using Hsf_Receitas.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6993bffe22735b209737eaf84bba529e03970e49", @"/Views/AtestadoComparecimento/ATCCompletePrescription.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"489f18548069da5d6cb12941c30987820b77cd47", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_AtestadoComparecimento_ATCCompletePrescription : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Receituario>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("atc-up-prescriptionId"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control mb-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("atc-up-pacientName"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control border-primary mb-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("atc-up-doctorName"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "date", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("atc-up-dataAppoiment"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("atc-up-receita-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("prescription-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\gianluca.vialli\Desktop\Hsf_Receituario\Views\AtestadoComparecimento\ATCCompletePrescription.cshtml"
  
    ViewData["title"] = "Completar Receituário";

    Medicacao medic = new Medicacao();
    AtestadoComparecimento atc = new AtestadoComparecimento();
    HSFContext database = new HSFContext();

    List<Medicacao> medicList = database.Medicamentos.Where(m => m.ReceituarioId ==
    Model.Id).ToList();

    int medicIdPrint = @Model.Id;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""prescription"">

    <div class=""card"">

        <div class=""card-header text-light"">

            <h1 class=""text-center"">Receituário</h1>

        </div>

        <div class=""card-body"">

            <div class=""receita"">

                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6993bffe22735b209737eaf84bba529e03970e498412", async() => {
                WriteLiteral(@"

                    <span class=""mt-3 mb-3 alerta""></span>

                    <div class=""card medicine-card"">

                        <h5 class=""card-header"">Informações básicas :</h5>

                        <div class=""row"">

                            <p class="" ml-5 mt-4 text-danger text-center"">Ao realizar alterações nas informções básicas, salve-as antes de imprimir.</p>

                            <div class=""card-body card-body-edit-prescription col-md-8"">

                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6993bffe22735b209737eaf84bba529e03970e499204", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 46 "C:\Users\gianluca.vialli\Desktop\Hsf_Receituario\Views\AtestadoComparecimento\ATCCompletePrescription.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n                                <label class=\"text-primary\"");
                BeginWriteAttribute("for", " for=\"", 1445, "\"", 1451, 0);
                EndWriteAttribute();
                WriteLiteral(">Nome do Paciente: </label>\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6993bffe22735b209737eaf84bba529e03970e4911706", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
#nullable restore
#line 49 "C:\Users\gianluca.vialli\Desktop\Hsf_Receituario\Views\AtestadoComparecimento\ATCCompletePrescription.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.PacientName);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("required", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n                                <label class=\"text-primary\"");
                BeginWriteAttribute("for", " for=\"", 1691, "\"", 1697, 0);
                EndWriteAttribute();
                WriteLiteral(">Nome do Médico: </label>\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6993bffe22735b209737eaf84bba529e03970e4914216", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
#nullable restore
#line 52 "C:\Users\gianluca.vialli\Desktop\Hsf_Receituario\Views\AtestadoComparecimento\ATCCompletePrescription.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.DoctorName);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("required", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n                                <label class=\"text-primary\"");
                BeginWriteAttribute("for", " for=\"", 1933, "\"", 1939, 0);
                EndWriteAttribute();
                WriteLiteral(">Data da consulta: </label>\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6993bffe22735b209737eaf84bba529e03970e4916727", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
#nullable restore
#line 55 "C:\Users\gianluca.vialli\Desktop\Hsf_Receituario\Views\AtestadoComparecimento\ATCCompletePrescription.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.DateOfMedicalAppoiment);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("required", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

                            </div>

                            <div class=""col-md-3 edit-button"">
                                <button type=""submit"" class="" btn btn-md btn-primary"">Salvar</button>
                            </div>

                        </div>

                    </div>

                    <div class=""card medicine-card"">

                        <h5 class=""card-header"">Atestado Médico :</h5>

                        <div class=""card-body"">

                            <p class=""text-info ml-3"">Agora você pode adicionar um atestado de comparecimento!</p>

                            <!--<div class=""col-md-12 mt-3"">
                                await Html.PartialAsync(""/Views/Medicacao/_ListaDeMedicacao.cshtml"", medicList)
                            </div>-->
                            
                            <button type=""button"" data-toggle=""modal"" data-target=""#atc-modal-");
#nullable restore
#line 79 "C:\Users\gianluca.vialli\Desktop\Hsf_Receituario\Views\AtestadoComparecimento\ATCCompletePrescription.cshtml"
                                                                                         Write(Model.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral(@""" title=""Adicionar Atestado Médico"" onclick="" ATC()"" class=""btn btn-md btn-info btn-printer ml-3""> <span class=""material-symbols-outlined""> clinical_notes </span> Atestado de Comparecimento</button>

                        </div>

                    </div>

                    <div class=""card medicine-card"">

                        <h5 class=""card-header"">Medicações :</h5>

                        <div class=""card-body"">

                            <p class=""text-info ml-3"">Agora você pode adicionar medicamentos!</p>

                            <div class=""col-md-12 mt-3"">
                                ");
#nullable restore
#line 94 "C:\Users\gianluca.vialli\Desktop\Hsf_Receituario\Views\AtestadoComparecimento\ATCCompletePrescription.cshtml"
                           Write(await Html.PartialAsync("/Views/Medicacao/_ListaDeMedicacao.cshtml", @medicList));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </div>\r\n\r\n                            <button type=\"button\" data-toggle=\"modal\" data-target=\"#atc-medication-modal-");
#nullable restore
#line 97 "C:\Users\gianluca.vialli\Desktop\Hsf_Receituario\Views\AtestadoComparecimento\ATCCompletePrescription.cshtml"
                                                                                                    Write(Model.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral(@""" title=""Inserir medicamentos à receita"" onclick="" inserirRemediosATC()"" class=""btn btn-md btn-info btn-printer ml-3""> <span class=""material-symbols-outlined""> syringe </span> Adicionar Medicamentos</button>

                        </div>

                    </div>

                    <a");
                BeginWriteAttribute("href", " href=\"", 4251, "\"", 4320, 2);
                WriteAttributeValue("", 4258, "/AtestadoComparecimento/ATCPrescriptionPrintToPDF?id=", 4258, 53, true);
#nullable restore
#line 103 "C:\Users\gianluca.vialli\Desktop\Hsf_Receituario\Views\AtestadoComparecimento\ATCCompletePrescription.cshtml"
WriteAttributeValue("", 4311, Model.Id, 4311, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" target=\"_blank\" title=\"Imprimir receituário\" class=\"btn btn-md btn-secondary btn-printer-p\"");
                BeginWriteAttribute("href", " href=\"", 4413, "\"", 4420, 0);
                EndWriteAttribute();
                WriteLiteral("><span class=\"material-symbols-outlined\"> print </span> Imprimir </a>\r\n\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n\r\n</div>\r\n\r\n<!--Start Medication Modal-->\r\n\r\n<div class=\"modal fade\"");
            BeginWriteAttribute("id", " id=\"", 4639, "\"", 4674, 2);
            WriteAttributeValue("", 4644, "atc-medication-modal-", 4644, 21, true);
#nullable restore
#line 116 "C:\Users\gianluca.vialli\Desktop\Hsf_Receituario\Views\AtestadoComparecimento\ATCCompletePrescription.cshtml"
WriteAttributeValue("", 4665, Model.Id, 4665, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" tabindex=""-1"" role=""dialog"" aria-labelledby=""registerUserTitle"" aria-hidden=""true"">

    <div class=""modal-dialog modal-dialog-centered modal-md"" role=""document"">

        <div class=""modal-content"">

            <div class=""modal-header text-center"">

                <h2 class=""text-center mb-0""> Inserir Medicamento</h2>

                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">

                    <span aria-hidden=""true"">&times;</span>

                </button>

            </div>

            <div class=""modal-body p-0"">
                ");
#nullable restore
#line 135 "C:\Users\gianluca.vialli\Desktop\Hsf_Receituario\Views\AtestadoComparecimento\ATCCompletePrescription.cshtml"
           Write(await Html.PartialAsync("/Views/Medicacao/_MedicationRegisterATC.cshtml", @medic));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n        </div>\r\n\r\n    </div>\r\n\r\n</div>\r\n\r\n<!--Finish Medication Modal-->\r\n\r\n<!--Start ATC Modal-->\r\n\r\n<div class=\"modal fade\"");
            BeginWriteAttribute("id", " id=\"", 5510, "\"", 5534, 2);
            WriteAttributeValue("", 5515, "atc-modal-", 5515, 10, true);
#nullable restore
#line 148 "C:\Users\gianluca.vialli\Desktop\Hsf_Receituario\Views\AtestadoComparecimento\ATCCompletePrescription.cshtml"
WriteAttributeValue("", 5525, Model.Id, 5525, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" tabindex=""-1"" role=""dialog"" aria-labelledby=""registerUserTitle"" aria-hidden=""true"">

    <div class=""modal-dialog modal-dialog-centered modal-md"" role=""document"">

        <div class=""modal-content"">

            <div class=""modal-header text-center"">

                 <h3 class=""text-center mb-0"">Atestado de Comparecimento</h3>

                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">

                    <span aria-hidden=""true"">&times;</span>

                </button>

            </div>

            <div class=""modal-body p-0"">
                ");
#nullable restore
#line 167 "C:\Users\gianluca.vialli\Desktop\Hsf_Receituario\Views\AtestadoComparecimento\ATCCompletePrescription.cshtml"
           Write(await Html.PartialAsync("/Views/AtestadoComparecimento/_ATCRegister.cshtml", @atc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n        </div>\r\n\r\n    </div>\r\n\r\n</div>\r\n\r\n<!--Finish ATC Modal-->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Receituario> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
