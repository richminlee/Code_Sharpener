#pragma checksum "C:\Users\leeri\Desktop\Hired\Algorithms\Code_Sharpener\CodeSharpener\Views\Home\CodeEditor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c8260a970a8cc0ffeebd023fe7196bc41b28411"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CodeEditor), @"mvc.1.0.view", @"/Views/Home/CodeEditor.cshtml")]
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
#line 1 "C:\Users\leeri\Desktop\Hired\Algorithms\Code_Sharpener\CodeSharpener\Views\_ViewImports.cshtml"
using CodeSharpener;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\leeri\Desktop\Hired\Algorithms\Code_Sharpener\CodeSharpener\Views\_ViewImports.cshtml"
using CodeSharpener.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c8260a970a8cc0ffeebd023fe7196bc41b28411", @"/Views/Home/CodeEditor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f86e42992d5dcf0e67c01cbb25085bb44d992bdc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CodeEditor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\leeri\Desktop\Hired\Algorithms\Code_Sharpener\CodeSharpener\Views\Home\CodeEditor.cshtml"
  
    ViewData["Title"] = "Code Editor";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container"">
    <div class=""row"">
        <div class=""col"">
            <textarea class=""codemirror-textarea"">
</textarea>
        </div>
    </div>
    <div class=""row my-5""></div>
    <div class=""row mt-5"">
        <div class=""col"">
            <a href=""codeeditor""><img class=""img-responsive"" width=""100%"" src=""images/EmbeddedEditorExample.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 416, "\"", 422, 0);
            EndWriteAttribute();
            WriteLiteral("></a>\r\n        </div>\r\n    </div>\r\n</div>");
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
