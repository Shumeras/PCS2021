#pragma checksum "D:\Dev\PCS2021\WebDemo\RazorPages\Pages\Products.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "95877245bf5f1ca4ff1ed327a67b4b0c62895221"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RazorPages.Pages.Pages_Products), @"mvc.1.0.razor-page", @"/Pages/Products.cshtml")]
namespace RazorPages.Pages
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
#line 1 "D:\Dev\PCS2021\WebDemo\RazorPages\Pages\_ViewImports.cshtml"
using RazorPages;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95877245bf5f1ca4ff1ed327a67b4b0c62895221", @"/Pages/Products.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7bb4d15e82bf516f895a84b5c4d83ae504087504", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Products : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "D:\Dev\PCS2021\WebDemo\RazorPages\Pages\Products.cshtml"
 if(Model.Products == null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>No products?</h1>\r\n");
#nullable restore
#line 9 "D:\Dev\PCS2021\WebDemo\RazorPages\Pages\Products.cshtml"
}
else
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Dev\PCS2021\WebDemo\RazorPages\Pages\Products.cshtml"
     foreach(var product in Model.Products)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card col-md-4\">\r\n            <h2");
            BeginWriteAttribute("class", " class=\"", 213, "\"", 221, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 15 "D:\Dev\PCS2021\WebDemo\RazorPages\Pages\Products.cshtml"
                    Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 259, "\"", 282, 1);
#nullable restore
#line 16 "D:\Dev\PCS2021\WebDemo\RazorPages\Pages\Products.cshtml"
WriteAttributeValue("", 265, product.ImageURL, 265, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            <h3>Price: ");
#nullable restore
#line 17 "D:\Dev\PCS2021\WebDemo\RazorPages\Pages\Products.cshtml"
                  Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        </div>\r\n");
#nullable restore
#line 19 "D:\Dev\PCS2021\WebDemo\RazorPages\Pages\Products.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\Dev\PCS2021\WebDemo\RazorPages\Pages\Products.cshtml"
     

}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProductsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProductsModel>)PageContext?.ViewData;
        public ProductsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591