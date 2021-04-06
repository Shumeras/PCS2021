#pragma checksum "D:\Dev\PCS2021\Blazor\BlazorApp\Pages\AddComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70e548405fed44bd8b2993dda40ec5dfe4cdd77a"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Dev\PCS2021\Blazor\BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Dev\PCS2021\Blazor\BlazorApp\_Imports.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Dev\PCS2021\Blazor\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Dev\PCS2021\Blazor\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Dev\PCS2021\Blazor\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Dev\PCS2021\Blazor\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Dev\PCS2021\Blazor\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Dev\PCS2021\Blazor\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Dev\PCS2021\Blazor\BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Dev\PCS2021\Blazor\BlazorApp\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Dev\PCS2021\Blazor\BlazorApp\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Dev\PCS2021\Blazor\BlazorApp\_Imports.razor"
using Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Dev\PCS2021\Blazor\BlazorApp\_Imports.razor"
using Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Dev\PCS2021\Blazor\BlazorApp\Pages\AddComponent.razor"
using Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/products/add")]
    public partial class AddComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 7 "D:\Dev\PCS2021\Blazor\BlazorApp\Pages\AddComponent.razor"
                  ProductModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 7 "D:\Dev\PCS2021\Blazor\BlazorApp\Pages\AddComponent.razor"
                                               AddProduct

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "OnInvalidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 7 "D:\Dev\PCS2021\Blazor\BlazorApp\Pages\AddComponent.razor"
                                                                            OnInvalidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.AddMarkupContent(7, "<label>Product name:</label>\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(8);
                __builder2.AddAttribute(9, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 10 "D:\Dev\PCS2021\Blazor\BlazorApp\Pages\AddComponent.razor"
                             ProductModel.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(10, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ProductModel.Name = __value, ProductModel.Name))));
                __builder2.AddAttribute(11, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => ProductModel.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, " <br>\r\n\r\n    ");
                __builder2.AddMarkupContent(13, "<label>Product price:</label>\r\n    ");
                __Blazor.BlazorApp.Pages.AddComponent.TypeInference.CreateInputNumber_0(__builder2, 14, 15, 
#nullable restore
#line 13 "D:\Dev\PCS2021\Blazor\BlazorApp\Pages\AddComponent.razor"
                               ProductModel.Price

#line default
#line hidden
#nullable disable
                , 16, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ProductModel.Price = __value, ProductModel.Price)), 17, () => ProductModel.Price);
                __builder2.AddMarkupContent(18, " <br>\r\n\r\n    ");
                __builder2.AddMarkupContent(19, "<label>Product image:</label>\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(20);
                __builder2.AddAttribute(21, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "D:\Dev\PCS2021\Blazor\BlazorApp\Pages\AddComponent.razor"
                             ProductModel.ImageUrl

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ProductModel.ImageUrl = __value, ProductModel.ImageUrl))));
                __builder2.AddAttribute(23, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => ProductModel.ImageUrl));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(24, " <br>\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(25);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(26, "\r\n\r\n    ");
                __builder2.AddMarkupContent(27, "<button class=\"btn btn-info\" type=\"submit\">Add Product</button>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "D:\Dev\PCS2021\Blazor\BlazorApp\Pages\AddComponent.razor"
       
    public ProductModel ProductModel { get; private set; } = new ProductModel();


    public void OnInvalidSubmit()
    {
        jsRuntime.InvokeVoidAsync("alertBrowser", "Product failed");
    }

    public void AddProduct()
    {
        dbContext.Products.Add(
            new Product{
                Name = ProductModel.Name,
                Price = ProductModel.Price,
                ImageURL = ProductModel.ImageUrl
            });
        dbContext.SaveChangesAsync();

        ProductModel = new ProductModel();


    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DataContext dbContext { get; set; }
    }
}
namespace __Blazor.BlazorApp.Pages.AddComponent
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591