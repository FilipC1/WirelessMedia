#pragma checksum "C:\Users\Filip\source\repos\WirelessMedia2018\WirelessMedia\WirelessMedia\WirelessMedia\Views\Proizvodi\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da659453f69646c674110b3d9e042d536ce751e3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Proizvodi_Index), @"mvc.1.0.view", @"/Views/Proizvodi/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Proizvodi/Index.cshtml", typeof(AspNetCore.Views_Proizvodi_Index))]
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
#line 1 "C:\Users\Filip\source\repos\WirelessMedia2018\WirelessMedia\WirelessMedia\WirelessMedia\Views\_ViewImports.cshtml"
using WirelessMedia;

#line default
#line hidden
#line 2 "C:\Users\Filip\source\repos\WirelessMedia2018\WirelessMedia\WirelessMedia\WirelessMedia\Views\_ViewImports.cshtml"
using WirelessMedia.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da659453f69646c674110b3d9e042d536ce751e3", @"/Views/Proizvodi/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f82580f9b5ca18ad9dad66e3fa4a273848eba1de", @"/Views/_ViewImports.cshtml")]
    public class Views_Proizvodi_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Proizvod>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Filip\source\repos\WirelessMedia2018\WirelessMedia\WirelessMedia\WirelessMedia\Views\Proizvodi\Index.cshtml"
  
    ViewData["Title"] = "Proizvodi";

#line default
#line hidden
            BeginContext(77, 33, true);
            WriteLiteral("\r\n<h2>Proizvodi</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(110, 47, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d75cc296f8542309fc81e02844c8735", async() => {
                BeginContext(133, 20, true);
                WriteLiteral("Kreiraj nov proizvod");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(157, 556, true);
            WriteLiteral(@"
</p>
<table class=""table table-bordered table-striped"" style=""border:2px solid black"">
    <thead>
        <tr>
            <th>
                Naziv
            </th>
            <th>
                Opis
            </th>
            <th>
                Kategorija
            </th>
            <th>
                Proizvodjac
            </th>
            <th>
                Dobavljac
            </th>
            <th>
                Cena
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 37 "C:\Users\Filip\source\repos\WirelessMedia2018\WirelessMedia\WirelessMedia\WirelessMedia\Views\Proizvodi\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(762, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(823, 10, false);
#line 41 "C:\Users\Filip\source\repos\WirelessMedia2018\WirelessMedia\WirelessMedia\WirelessMedia\Views\Proizvodi\Index.cshtml"
               Write(item.Naziv);

#line default
#line hidden
            EndContext();
            BeginContext(833, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(901, 9, false);
#line 44 "C:\Users\Filip\source\repos\WirelessMedia2018\WirelessMedia\WirelessMedia\WirelessMedia\Views\Proizvodi\Index.cshtml"
               Write(item.Opis);

#line default
#line hidden
            EndContext();
            BeginContext(910, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(978, 15, false);
#line 47 "C:\Users\Filip\source\repos\WirelessMedia2018\WirelessMedia\WirelessMedia\WirelessMedia\Views\Proizvodi\Index.cshtml"
               Write(item.Kategorija);

#line default
#line hidden
            EndContext();
            BeginContext(993, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1061, 16, false);
#line 50 "C:\Users\Filip\source\repos\WirelessMedia2018\WirelessMedia\WirelessMedia\WirelessMedia\Views\Proizvodi\Index.cshtml"
               Write(item.Proizvodjac);

#line default
#line hidden
            EndContext();
            BeginContext(1077, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1145, 14, false);
#line 53 "C:\Users\Filip\source\repos\WirelessMedia2018\WirelessMedia\WirelessMedia\WirelessMedia\Views\Proizvodi\Index.cshtml"
               Write(item.Dobavljac);

#line default
#line hidden
            EndContext();
            BeginContext(1159, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1227, 9, false);
#line 56 "C:\Users\Filip\source\repos\WirelessMedia2018\WirelessMedia\WirelessMedia\WirelessMedia\Views\Proizvodi\Index.cshtml"
               Write(item.Cena);

#line default
#line hidden
            EndContext();
            BeginContext(1236, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1303, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b00e46c62644123aba76c60481f1d81", async() => {
                BeginContext(1356, 7, true);
                WriteLiteral("Promeni");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 59 "C:\Users\Filip\source\repos\WirelessMedia2018\WirelessMedia\WirelessMedia\WirelessMedia\Views\Proizvodi\Index.cshtml"
                                           WriteLiteral(item.ProizvodId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1367, 4, true);
            WriteLiteral(" |\r\n");
            EndContext();
            BeginContext(1557, 42, true);
            WriteLiteral("                </td>\r\n            </tr>\r\n");
            EndContext();
#line 64 "C:\Users\Filip\source\repos\WirelessMedia2018\WirelessMedia\WirelessMedia\WirelessMedia\Views\Proizvodi\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1610, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Proizvod>> Html { get; private set; }
    }
}
#pragma warning restore 1591
