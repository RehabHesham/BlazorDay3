#pragma checksum "D:\iti\9M\34 Blazor\BlazorDay3\BlazorDay3\ProductComponents\EditProduct.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c27b36ee8d57845a8e91e49f101c304d0cb48b0"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorDay3.ProductComponents
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\iti\9M\34 Blazor\BlazorDay3\BlazorDay3\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\iti\9M\34 Blazor\BlazorDay3\BlazorDay3\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\iti\9M\34 Blazor\BlazorDay3\BlazorDay3\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\iti\9M\34 Blazor\BlazorDay3\BlazorDay3\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\iti\9M\34 Blazor\BlazorDay3\BlazorDay3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\iti\9M\34 Blazor\BlazorDay3\BlazorDay3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\iti\9M\34 Blazor\BlazorDay3\BlazorDay3\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\iti\9M\34 Blazor\BlazorDay3\BlazorDay3\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\iti\9M\34 Blazor\BlazorDay3\BlazorDay3\_Imports.razor"
using BlazorDay3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\iti\9M\34 Blazor\BlazorDay3\BlazorDay3\_Imports.razor"
using BlazorDay3.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\iti\9M\34 Blazor\BlazorDay3\BlazorDay3\_Imports.razor"
using SharedModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\iti\9M\34 Blazor\BlazorDay3\BlazorDay3\_Imports.razor"
using BlazorDay3.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Product/edit/{id:int}")]
    public partial class EditProduct : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>EditProduct</h3>");
#nullable restore
#line 7 "D:\iti\9M\34 Blazor\BlazorDay3\BlazorDay3\ProductComponents\EditProduct.razor"
 if (product != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 9 "D:\iti\9M\34 Blazor\BlazorDay3\BlazorDay3\ProductComponents\EditProduct.razor"
                     product

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 9 "D:\iti\9M\34 Blazor\BlazorDay3\BlazorDay3\ProductComponents\EditProduct.razor"
                                             SaveProduct

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(7);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n        ");
                __builder2.OpenElement(9, "div");
                __builder2.AddMarkupContent(10, "<label>Name</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(11);
                __builder2.AddAttribute(12, "class", "form-control");
                __builder2.AddAttribute(13, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 14 "D:\iti\9M\34 Blazor\BlazorDay3\BlazorDay3\ProductComponents\EditProduct.razor"
                                    product.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => product.Name = __value, product.Name))));
                __builder2.AddAttribute(15, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => product.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\r\n            ");
                __Blazor.BlazorDay3.ProductComponents.EditProduct.TypeInference.CreateValidationMessage_0(__builder2, 17, 18, 
#nullable restore
#line 15 "D:\iti\9M\34 Blazor\BlazorDay3\BlazorDay3\ProductComponents\EditProduct.razor"
                                    ()=>product.Name

#line default
#line hidden
#nullable disable
                , 19, "text-danger");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\r\n        ");
                __builder2.OpenElement(21, "div");
                __builder2.AddMarkupContent(22, "<label>Description</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(23);
                __builder2.AddAttribute(24, "class", "form-control");
                __builder2.AddAttribute(25, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 19 "D:\iti\9M\34 Blazor\BlazorDay3\BlazorDay3\ProductComponents\EditProduct.razor"
                                    product.Description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => product.Description = __value, product.Description))));
                __builder2.AddAttribute(27, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => product.Description));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(28, "\r\n            ");
                __Blazor.BlazorDay3.ProductComponents.EditProduct.TypeInference.CreateValidationMessage_1(__builder2, 29, 30, 
#nullable restore
#line 20 "D:\iti\9M\34 Blazor\BlazorDay3\BlazorDay3\ProductComponents\EditProduct.razor"
                                    ()=>product.Description

#line default
#line hidden
#nullable disable
                , 31, "text-danger");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n        ");
                __builder2.OpenElement(33, "div");
                __builder2.AddMarkupContent(34, "<label>Price</label>\r\n            ");
                __Blazor.BlazorDay3.ProductComponents.EditProduct.TypeInference.CreateInputNumber_2(__builder2, 35, 36, "form-control", 37, 
#nullable restore
#line 24 "D:\iti\9M\34 Blazor\BlazorDay3\BlazorDay3\ProductComponents\EditProduct.razor"
                                      product.Price

#line default
#line hidden
#nullable disable
                , 38, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => product.Price = __value, product.Price)), 39, () => product.Price);
                __builder2.AddMarkupContent(40, "\r\n            ");
                __Blazor.BlazorDay3.ProductComponents.EditProduct.TypeInference.CreateValidationMessage_3(__builder2, 41, 42, 
#nullable restore
#line 25 "D:\iti\9M\34 Blazor\BlazorDay3\BlazorDay3\ProductComponents\EditProduct.razor"
                                    ()=>product.Price

#line default
#line hidden
#nullable disable
                , 43, "text-danger");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n        ");
                __builder2.OpenElement(45, "div");
                __builder2.AddMarkupContent(46, "<label>Image</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(47);
                __builder2.AddAttribute(48, "class", "form-control");
                __builder2.AddAttribute(49, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 30 "D:\iti\9M\34 Blazor\BlazorDay3\BlazorDay3\ProductComponents\EditProduct.razor"
                                    product.Image

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(50, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => product.Image = __value, product.Image))));
                __builder2.AddAttribute(51, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => product.Image));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(52, "\r\n            ");
                __Blazor.BlazorDay3.ProductComponents.EditProduct.TypeInference.CreateValidationMessage_4(__builder2, 53, 54, 
#nullable restore
#line 31 "D:\iti\9M\34 Blazor\BlazorDay3\BlazorDay3\ProductComponents\EditProduct.razor"
                                    ()=>product.Image

#line default
#line hidden
#nullable disable
                , 55, "text-danger");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\r\n        ");
                __builder2.OpenElement(57, "div");
                __builder2.AddMarkupContent(58, "<label>Category</label>\r\n            ");
                __Blazor.BlazorDay3.ProductComponents.EditProduct.TypeInference.CreateInputSelect_5(__builder2, 59, 60, "form-control", 61, 
#nullable restore
#line 35 "D:\iti\9M\34 Blazor\BlazorDay3\BlazorDay3\ProductComponents\EditProduct.razor"
                                      product.Cat_Id

#line default
#line hidden
#nullable disable
                , 62, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => product.Cat_Id = __value, product.Cat_Id)), 63, () => product.Cat_Id, 64, (__builder3) => {
#nullable restore
#line 36 "D:\iti\9M\34 Blazor\BlazorDay3\BlazorDay3\ProductComponents\EditProduct.razor"
                 foreach (var item in categories)
                   {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(65, "option");
                    __builder3.AddAttribute(66, "value", 
#nullable restore
#line 38 "D:\iti\9M\34 Blazor\BlazorDay3\BlazorDay3\ProductComponents\EditProduct.razor"
                                       item.Id

#line default
#line hidden
#nullable disable
                    );
#nullable restore
#line 38 "D:\iti\9M\34 Blazor\BlazorDay3\BlazorDay3\ProductComponents\EditProduct.razor"
__builder3.AddContent(67, item.Name);

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
#nullable restore
#line 39 "D:\iti\9M\34 Blazor\BlazorDay3\BlazorDay3\ProductComponents\EditProduct.razor"
                   }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.AddMarkupContent(68, "\r\n            ");
                __Blazor.BlazorDay3.ProductComponents.EditProduct.TypeInference.CreateValidationMessage_6(__builder2, 69, 70, 
#nullable restore
#line 41 "D:\iti\9M\34 Blazor\BlazorDay3\BlazorDay3\ProductComponents\EditProduct.razor"
                                    ()=>product.Cat_Id

#line default
#line hidden
#nullable disable
                , 71, "text-danger");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(72, "\r\n        ");
                __builder2.AddMarkupContent(73, "<div class=\"m-2 text-center\"><input type=\"submit\" value=\"Update\" class=\"btn btn-success\"></div>");
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 48 "D:\iti\9M\34 Blazor\BlazorDay3\BlazorDay3\ProductComponents\EditProduct.razor"
}else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(74, "<h3>Product Not Found</h3>");
#nullable restore
#line 51 "D:\iti\9M\34 Blazor\BlazorDay3\BlazorDay3\ProductComponents\EditProduct.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(75, "<div class=\"text-right m-2\"><a class=\"btn btn-primary\" href=\"/Products\">Back to list</a></div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IService<Category> catService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IService<ProductDTO> prodService { get; set; }
    }
}
namespace __Blazor.BlazorDay3.ProductComponents.EditProduct
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0, int __seq1, System.Object __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0, int __seq1, System.Object __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0, int __seq1, System.Object __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0, int __seq1, System.Object __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0, int __seq1, System.Object __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
