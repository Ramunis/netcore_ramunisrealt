#pragma checksum "C:\Users\sevam\source\repos\RamnisrealtNET\RamnisrealtNET\Views\Home\Calc.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7bc660c3266dec16e563c5ea8fb7e7549db9a7e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Calc), @"mvc.1.0.razor-page", @"/Views/Home/Calc.cshtml")]
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
#line 1 "C:\Users\sevam\source\repos\RamnisrealtNET\RamnisrealtNET\Views\_ViewImports.cshtml"
using RamnisrealtNET;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sevam\source\repos\RamnisrealtNET\RamnisrealtNET\Views\_ViewImports.cshtml"
using RamnisrealtNET.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7bc660c3266dec16e563c5ea8fb7e7549db9a7e", @"/Views/Home/Calc.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fdb82ebfc2b1dc7780d9870a6a02075b2697001d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Calc : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("needs-validation"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<main>\r\n    <br><div class=\"container\">\r\n    <h1 class=\"h2\">Ипотечный калькулятор</h1>\r\n\r\n    <div class=\"col-md-7 col-lg-8\">\r\n        <h4 class=\"mb-3\">Рассчитайте платеж и переплату по кредиту</h4>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b7bc660c3266dec16e563c5ea8fb7e7549db9a7e3803", async() => {
                WriteLiteral(@"
            <div class=""row g-3"">

                <div class=""col-12"">
                    <label for=""cena"" class=""form-label"">Цена <span class=""text-muted""></span></label>
                    <input type=""number"" class=""form-control"" id=""cena"" name=""cena"" placeholder=""1000000"">
                    <div class=""invalid-feedback"">
                        Please enter a valid email address for shipping updates.
                    </div>
                </div>

                <div class=""col-12"">
                    <label for=""start"" class=""form-label"">Первоначальный взнос</label>
                    <input type=""number"" class=""form-control"" id=""start"" name=""start"" placeholder=""300000"" required>
                    <div class=""invalid-feedback"">
                    </div>
                </div>

                <div class=""col-sm-6"">
                    <label for=""term"" class=""form-label"">Срок(лет)</label>
                    <input type=""text"" class=""form-control"" id=""term"" name=""term""");
                WriteLiteral(" placeholder=\"10\"");
                BeginWriteAttribute("value", " value=\"", 1348, "\"", 1356, 0);
                EndWriteAttribute();
                WriteLiteral(@" required>
                    <div class=""invalid-feedback"">
                        Valid first name is required.
                    </div>
                </div>

                <div class=""col-sm-6"">
                    <label for=""bet"" class=""form-label"">Ставка(%)</label>
                    <input type=""text"" class=""form-control"" id=""bet"" name=""bet"" placeholder=""5""");
                BeginWriteAttribute("value", " value=\"", 1740, "\"", 1748, 0);
                EndWriteAttribute();
                WriteLiteral(@" required>
                    <div class=""invalid-feedback"">
                        Valid last name is required.
                    </div>
                </div>

            </div>

            <br><button class=""btn btn-warning"" type=""button"" onclick=""presscalc()"" name=""bcalc"">Расчитать</button>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("validate", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
    <script>

        function presscalc() {
            var c = document.getElementById('cena').value;
            var s = document.getElementById('start').value;
            var t = document.getElementById('term').value;
            var b = document.getElementById('bet').value;

            var monthbet = b / 12 / 100;

            var firts = 1 + monthbet;
            var end = t * 12;
            var commonbet = Math.pow(firts, end);
            var monthpay = c * monthbet * commonbet / (commonbet - 1);

            var perpart = c * monthbet;
            var mainpart = monthpay - perpart;

            var overpay = monthpay * (t * 12) - c;

            //alert(c+s+t+b);
            //document.getElementById('output').value = monthpay;
            alert(""Платёж в месяц = "" + monthpay + "";Переплата = "" + overpay);
        }

    </script>
</div>
</main>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RamunisrealtNET.Views.Home.CalcModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RamunisrealtNET.Views.Home.CalcModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RamunisrealtNET.Views.Home.CalcModel>)PageContext?.ViewData;
        public RamunisrealtNET.Views.Home.CalcModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
