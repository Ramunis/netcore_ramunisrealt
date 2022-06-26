#pragma checksum "C:\Users\sevam\source\repos\RamnisrealtNET\RamnisrealtNET\Views\Account\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed851a8d9ab4e8ced3e3b684df0c259bf0442ea7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Index), @"mvc.1.0.view", @"/Views/Account/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed851a8d9ab4e8ced3e3b684df0c259bf0442ea7", @"/Views/Account/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fdb82ebfc2b1dc7780d9870a6a02075b2697001d", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RamnisrealtNET.Models.User>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\sevam\source\repos\RamnisrealtNET\RamnisrealtNET\Views\Account\Index.cshtml"
  
    ViewBag.Title = "Личный кабинет";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<link rel=""stylesheet"" href=""https://bootstraptema.ru/plugins/2015/bootstrap3/bootstrap.min.css"" />
<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"" />
<script src=""https://bootstraptema.ru/plugins/jquery/jquery-1.11.3.min.js""></script>
<script src=""https://bootstraptema.ru/plugins/2015/b-v3-3-6/bootstrap.min.js""></script>
<style>
    #main {
        background-color: #f2f2f2;
        padding: 20px;
        -webkit-border-radius: 4px;
        -moz-border-radius: 4px;
        -ms-border-radius: 4px;
        -o-border-radius: 4px;
        border-radius: 4px;
        border-bottom: 4px solid #ddd;
    }

    #real-estates-detail #author img {
        -webkit-border-radius: 100%;
        -moz-border-radius: 100%;
        -ms-border-radius: 100%;
        -o-border-radius: 100%;
        border-radius: 100%;
        border: 5px solid #ecf0f1;
        margin-bottom: 10px;
    }

    #real-estates-detail .sosmed-author i.fa {
");
            WriteLiteral(@"        width: 30px;
        height: 30px;
        border: 2px solid #bdc3c7;
        color: #bdc3c7;
        padding-top: 6px;
        margin-top: 10px;
    }

    .panel-default .panel-heading {
        background-color: #fff;
    }

    #real-estates-detail .slides li img {
        height: 450px;
    }
</style>

<div class=""container"">
    <div id=""main"">


        <div class=""row"" id=""real-estates-detail"">
            <div class=""col-lg-4 col-md-4 col-xs-12"">
                <div class=""panel panel-default"">
                    <div class=""panel-heading"">
                        <header class=""panel-title"">
                            <div class=""text-center"">
                                <strong>Личный кабинет</strong>
                            </div>
                        </header>
                    </div>
");
#nullable restore
#line 64 "C:\Users\sevam\source\repos\RamnisrealtNET\RamnisrealtNET\Views\Account\Index.cshtml"
                     foreach (var user in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"panel-body\">\r\n                            <div class=\"text-center\" id=\"author\">\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 2208, "\"", 2223, 1);
#nullable restore
#line 68 "C:\Users\sevam\source\repos\RamnisrealtNET\RamnisrealtNET\Views\Account\Index.cshtml"
WriteAttributeValue("", 2214, user.Pic, 2214, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <h3>");
#nullable restore
#line 69 "C:\Users\sevam\source\repos\RamnisrealtNET\RamnisrealtNET\Views\Account\Index.cshtml"
                               Write(user.F);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 69 "C:\Users\sevam\source\repos\RamnisrealtNET\RamnisrealtNET\Views\Account\Index.cshtml"
                                       Write(user.I);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 69 "C:\Users\sevam\source\repos\RamnisrealtNET\RamnisrealtNET\Views\Account\Index.cshtml"
                                               Write(user.O);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h3>\r\n                                <small class=\"label label-warning\">");
#nullable restore
#line 70 "C:\Users\sevam\source\repos\RamnisrealtNET\RamnisrealtNET\Views\Account\Index.cshtml"
                                                              Write(user.City);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</small>
                                <p>Клиент фирмы риэлтора</p>
                                <p class=""sosmed-author"">
                                    <a href=""#""><i class=""fa fa-facebook"" title=""Facebook""></i></a>
                                    <a href=""#""><i class=""fa fa-twitter"" title=""Twitter""></i></a>
                                    <a href=""#""><i class=""fa fa-google-plus"" title=""Google Plus""></i></a>
                                    <a href=""#""><i class=""fa fa-linkedin"" title=""Linkedin""></i></a>
                                </p>
                            </div>
                        </div>
");
#nullable restore
#line 80 "C:\Users\sevam\source\repos\RamnisrealtNET\RamnisrealtNET\Views\Account\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
            </div>
            <div class=""col-lg-8 col-md-8 col-xs-12"">
                <div class=""panel"">
                    <div class=""panel-body"">
                        <ul id=""myTab"" class=""nav nav-pills"">
                            <li class=""active""><a href=""#detail"" data-toggle=""tab"">Информация</a></li>                         
                            <a href=""/Home/Property"" class=""btn btn-light"">Объявления</a>                         
");
            WriteLiteral("                        </ul>\r\n                        <div id=\"myTabContent\" class=\"tab-content\">\r\n                            <hr>\r\n");
#nullable restore
#line 93 "C:\Users\sevam\source\repos\RamnisrealtNET\RamnisrealtNET\Views\Account\Index.cshtml"
                             foreach (var user in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <div class=""tab-pane fade active in"" id=""detail"">
                                    <h4>Данные</h4>
                                    <table class=""table table-th-block"">
                                        <tbody>
");
            WriteLiteral("                                            <tr><td class=\"active\">Email:</td><td>");
#nullable restore
#line 101 "C:\Users\sevam\source\repos\RamnisrealtNET\RamnisrealtNET\Views\Account\Index.cshtml"
                                                                             Write(user.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n                                            <tr><td class=\"active\">Телефон:</td><td>");
#nullable restore
#line 102 "C:\Users\sevam\source\repos\RamnisrealtNET\RamnisrealtNET\Views\Account\Index.cshtml"
                                                                               Write(user.Phon);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n                                            <tr><td class=\"active\">Город:</td><td>");
#nullable restore
#line 103 "C:\Users\sevam\source\repos\RamnisrealtNET\RamnisrealtNET\Views\Account\Index.cshtml"
                                                                             Write(user.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n                                            <tr><td class=\"active\">Адрес:</td><td>");
#nullable restore
#line 104 "C:\Users\sevam\source\repos\RamnisrealtNET\RamnisrealtNET\Views\Account\Index.cshtml"
                                                                             Write(user.Adres);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n");
            WriteLiteral("                                            <tr><td class=\"active\">ДР:</td><td>");
#nullable restore
#line 106 "C:\Users\sevam\source\repos\RamnisrealtNET\RamnisrealtNET\Views\Account\Index.cshtml"
                                                                          Write(user.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n");
            WriteLiteral("                                        </tbody>\r\n                                    </table>\r\n                                </div>\r\n");
#nullable restore
#line 113 "C:\Users\sevam\source\repos\RamnisrealtNET\RamnisrealtNET\Views\Account\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                           \r\n");
            WriteLiteral("                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RamnisrealtNET.Models.User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
