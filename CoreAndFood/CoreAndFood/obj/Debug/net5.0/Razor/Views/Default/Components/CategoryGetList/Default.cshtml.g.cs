#pragma checksum "C:\Users\Kemal\Desktop\mvcprojeler\CoreAndFood\CoreAndFood\Views\Default\Components\CategoryGetList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c86e009ec9cb304dc92c39726de6b3c452c1bf15"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Default_Components_CategoryGetList_Default), @"mvc.1.0.view", @"/Views/Default/Components/CategoryGetList/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c86e009ec9cb304dc92c39726de6b3c452c1bf15", @"/Views/Default/Components/CategoryGetList/Default.cshtml")]
    #nullable restore
    public class Views_Default_Components_CategoryGetList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CoreAndFood.Data.Models.Category>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"collapse navbar-collapse\" id=\"bs-megadropdown-tabs\">\r\n    <ul class=\"nav navbar-nav nav_1\">\r\n");
#nullable restore
#line 6 "C:\Users\Kemal\Desktop\mvcprojeler\CoreAndFood\CoreAndFood\Views\Default\Components\CategoryGetList\Default.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li><a");
            BeginWriteAttribute("href", " href=\"", 230, "\"", 278, 2);
            WriteAttributeValue("", 237, "/Default/CategoryDetails/", 237, 25, true);
#nullable restore
#line 8 "C:\Users\Kemal\Desktop\mvcprojeler\CoreAndFood\CoreAndFood\Views\Default\Components\CategoryGetList\Default.cshtml"
WriteAttributeValue("", 262, item.CategoryID, 262, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 8 "C:\Users\Kemal\Desktop\mvcprojeler\CoreAndFood\CoreAndFood\Views\Default\Components\CategoryGetList\Default.cshtml"
                                                               Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 9 "C:\Users\Kemal\Desktop\mvcprojeler\CoreAndFood\CoreAndFood\Views\Default\Components\CategoryGetList\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CoreAndFood.Data.Models.Category>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
