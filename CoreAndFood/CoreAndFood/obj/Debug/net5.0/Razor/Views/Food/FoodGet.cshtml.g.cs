#pragma checksum "C:\Users\Kemal\Desktop\mvcprojeler\CoreAndFood\CoreAndFood\Views\Food\FoodGet.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f6064cb41fe29229d8c840b8bc373dfb81002a59"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Food_FoodGet), @"mvc.1.0.view", @"/Views/Food/FoodGet.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6064cb41fe29229d8c840b8bc373dfb81002a59", @"/Views/Food/FoodGet.cshtml")]
    #nullable restore
    public class Views_Food_FoodGet : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CoreAndFood.Data.Models.Food>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Kemal\Desktop\mvcprojeler\CoreAndFood\CoreAndFood\Views\Food\FoodGet.cshtml"
  
    ViewData["Title"] = "FoodGet";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Food Add Page</h1>\r\n<br />\r\n");
#nullable restore
#line 9 "C:\Users\Kemal\Desktop\mvcprojeler\CoreAndFood\CoreAndFood\Views\Food\FoodGet.cshtml"
 using(Html.BeginForm("FoodUpdate","Food",FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Kemal\Desktop\mvcprojeler\CoreAndFood\CoreAndFood\Views\Food\FoodGet.cshtml"
Write(Html.Label("Food Id"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Kemal\Desktop\mvcprojeler\CoreAndFood\CoreAndFood\Views\Food\FoodGet.cshtml"
Write(Html.TextBoxFor(x=>x.FoodID,new {@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n");
#nullable restore
#line 13 "C:\Users\Kemal\Desktop\mvcprojeler\CoreAndFood\CoreAndFood\Views\Food\FoodGet.cshtml"
Write(Html.Label("Food Name"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Kemal\Desktop\mvcprojeler\CoreAndFood\CoreAndFood\Views\Food\FoodGet.cshtml"
Write(Html.TextBoxFor(x=>x.Name,new {@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n");
#nullable restore
#line 15 "C:\Users\Kemal\Desktop\mvcprojeler\CoreAndFood\CoreAndFood\Views\Food\FoodGet.cshtml"
Write(Html.Label("Stock"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Kemal\Desktop\mvcprojeler\CoreAndFood\CoreAndFood\Views\Food\FoodGet.cshtml"
Write(Html.TextBoxFor(x=>x.Stock,new {@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n");
#nullable restore
#line 17 "C:\Users\Kemal\Desktop\mvcprojeler\CoreAndFood\CoreAndFood\Views\Food\FoodGet.cshtml"
Write(Html.Label("Price"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Kemal\Desktop\mvcprojeler\CoreAndFood\CoreAndFood\Views\Food\FoodGet.cshtml"
Write(Html.TextBoxFor(x=>x.Price,new {@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n");
#nullable restore
#line 19 "C:\Users\Kemal\Desktop\mvcprojeler\CoreAndFood\CoreAndFood\Views\Food\FoodGet.cshtml"
Write(Html.Label("Image URL"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Kemal\Desktop\mvcprojeler\CoreAndFood\CoreAndFood\Views\Food\FoodGet.cshtml"
Write(Html.TextBoxFor(x=>x.ImageURL,new {@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n");
#nullable restore
#line 21 "C:\Users\Kemal\Desktop\mvcprojeler\CoreAndFood\CoreAndFood\Views\Food\FoodGet.cshtml"
Write(Html.Label("Category"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Kemal\Desktop\mvcprojeler\CoreAndFood\CoreAndFood\Views\Food\FoodGet.cshtml"
Write(Html.DropDownListFor(x=>x.CategoryID, (List<SelectListItem>)ViewBag.v1,new{@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n");
#nullable restore
#line 24 "C:\Users\Kemal\Desktop\mvcprojeler\CoreAndFood\CoreAndFood\Views\Food\FoodGet.cshtml"
Write(Html.Label("Description"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\Kemal\Desktop\mvcprojeler\CoreAndFood\CoreAndFood\Views\Food\FoodGet.cshtml"
Write(Html.TextAreaFor(x=>x.Description,new {@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n    <br />\r\n    <button class=\"btn btn-primary\">Save</button>\r\n");
#nullable restore
#line 28 "C:\Users\Kemal\Desktop\mvcprojeler\CoreAndFood\CoreAndFood\Views\Food\FoodGet.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoreAndFood.Data.Models.Food> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591