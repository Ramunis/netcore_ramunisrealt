#pragma checksum "C:\Users\sevam\source\repos\RamnisrealtNET\RamnisrealtNET\Views\Home\Archive.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7fcca05c75de37e4632e466c9dcbeb978fd22dd9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Archive), @"mvc.1.0.view", @"/Views/Home/Archive.cshtml")]
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
#nullable restore
#line 1 "C:\Users\sevam\source\repos\RamnisrealtNET\RamnisrealtNET\Views\Home\Archive.cshtml"
using RamunisrealtNET.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fcca05c75de37e4632e466c9dcbeb978fd22dd9", @"/Views/Home/Archive.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fdb82ebfc2b1dc7780d9870a6a02075b2697001d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Archive : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Achives>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\sevam\source\repos\RamnisrealtNET\RamnisrealtNET\Views\Home\Archive.cshtml"
  
    ViewData["Title"] = "Архив";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<table class=""table table-striped"">
    <thead>
        <tr>
            <th scope=""col"">ID</th>
            <th scope=""col"">ДЗ</th>
            <th scope=""col"">Клиент</th>
            <th scope=""col"">Собственник</th>
            <th scope=""col"">Город</th>
            <th scope=""col"">Адрес</th>
            <th scope=""col"">Описание</th>
            <th scope=""col"">Площадь</th>
            <th scope=""col"">Этаж</th>
            <th scope=""col"">Дата постройки</th>
            <th scope=""col"">Срок</th>
            <th scope=""col"">Цена</th>
            <th scope=""col"">Оплата</th>
            <th scope=""col"">Изображение</th>
            <th scope=""col"">Платёжный чек</th>

        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 28 "C:\Users\sevam\source\repos\RamnisrealtNET\RamnisrealtNET\Views\Home\Archive.cshtml"
         foreach (Achives item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 31 "C:\Users\sevam\source\repos\RamnisrealtNET\RamnisrealtNET\Views\Home\Archive.cshtml"
           Write(item.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 32 "C:\Users\sevam\source\repos\RamnisrealtNET\RamnisrealtNET\Views\Home\Archive.cshtml"
           Write(item.DZ);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 983, "\"", 1022, 2);
            WriteAttributeValue("", 990, "/Account/Client?uid=", 990, 20, true);
#nullable restore
#line 33 "C:\Users\sevam\source\repos\RamnisrealtNET\RamnisrealtNET\Views\Home\Archive.cshtml"
WriteAttributeValue("", 1010, item.Client, 1010, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 33 "C:\Users\sevam\source\repos\RamnisrealtNET\RamnisrealtNET\Views\Home\Archive.cshtml"
                                                      Write(item.Client);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 1065, "\"", 1105, 2);
            WriteAttributeValue("", 1072, "/Account/Client?uid=", 1072, 20, true);
#nullable restore
#line 34 "C:\Users\sevam\source\repos\RamnisrealtNET\RamnisrealtNET\Views\Home\Archive.cshtml"
WriteAttributeValue("", 1092, item.Realtor, 1092, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 34 "C:\Users\sevam\source\repos\RamnisrealtNET\RamnisrealtNET\Views\Home\Archive.cshtml"
                                                       Write(item.Realtor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n            <td>");
#nullable restore
#line 35 "C:\Users\sevam\source\repos\RamnisrealtNET\RamnisrealtNET\Views\Home\Archive.cshtml"
           Write(item.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 36 "C:\Users\sevam\source\repos\RamnisrealtNET\RamnisrealtNET\Views\Home\Archive.cshtml"
           Write(item.Adres);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 37 "C:\Users\sevam\source\repos\RamnisrealtNET\RamnisrealtNET\Views\Home\Archive.cshtml"
           Write(item.About);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 38 "C:\Users\sevam\source\repos\RamnisrealtNET\RamnisrealtNET\Views\Home\Archive.cshtml"
           Write(item.Sq);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 39 "C:\Users\sevam\source\repos\RamnisrealtNET\RamnisrealtNET\Views\Home\Archive.cshtml"
           Write(item.Level);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 40 "C:\Users\sevam\source\repos\RamnisrealtNET\RamnisrealtNET\Views\Home\Archive.cshtml"
           Write(item.DS);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 41 "C:\Users\sevam\source\repos\RamnisrealtNET\RamnisrealtNET\Views\Home\Archive.cshtml"
           Write(item.Term);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 42 "C:\Users\sevam\source\repos\RamnisrealtNET\RamnisrealtNET\Views\Home\Archive.cshtml"
           Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 43 "C:\Users\sevam\source\repos\RamnisrealtNET\RamnisrealtNET\Views\Home\Archive.cshtml"
           Write(item.Pay);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 1465, "\"", 1480, 1);
#nullable restore
#line 45 "C:\Users\sevam\source\repos\RamnisrealtNET\RamnisrealtNET\Views\Home\Archive.cshtml"
WriteAttributeValue("", 1471, item.Pic, 1471, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"189\" height=\"255\"");
            BeginWriteAttribute("alt", " alt=\"", 1506, "\"", 1512, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            </td>\r\n            <td>\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 1573, "\"", 1592, 1);
#nullable restore
#line 48 "C:\Users\sevam\source\repos\RamnisrealtNET\RamnisrealtNET\Views\Home\Archive.cshtml"
WriteAttributeValue("", 1579, item.Payfile, 1579, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"189\" height=\"255\"");
            BeginWriteAttribute("alt", " alt=\"", 1618, "\"", 1624, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            </td>\r\n\r\n        </tr>\r\n");
#nullable restore
#line 52 "C:\Users\sevam\source\repos\RamnisrealtNET\RamnisrealtNET\Views\Home\Archive.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Achives>> Html { get; private set; }
    }
}
#pragma warning restore 1591
