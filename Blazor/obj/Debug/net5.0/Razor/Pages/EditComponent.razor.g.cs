#pragma checksum "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\EditComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48e21c50f381460b8336a308aa90a5a15517efe0"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\_Imports.razor"
using Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\_Imports.razor"
using Blazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\EditComponent.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\EditComponent.razor"
using Blazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\EditComponent.razor"
using Entitiy;

#line default
#line hidden
#nullable disable
    public partial class EditComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "button");
            __builder.AddAttribute(1, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\EditComponent.razor"
                    ()=> ShowPop()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "b-grdsxhvof1");
            __builder.AddMarkupContent(3, "<span class=\"oi oi-pencil\" b-grdsxhvof1></span>");
            __builder.CloseElement();
#nullable restore
#line 12 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\EditComponent.razor"
 if (popup)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "modal");
            __builder.AddAttribute(6, "tabindex", "-1");
            __builder.AddAttribute(7, "style", "display: block");
            __builder.AddAttribute(8, "b-grdsxhvof1");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "main");
            __builder.AddAttribute(11, "b-grdsxhvof1");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "form-Contanier");
            __builder.AddAttribute(14, "b-grdsxhvof1");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(15);
            __builder.AddAttribute(16, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 17 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\EditComponent.razor"
                              adultToEdit

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 17 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\EditComponent.razor"
                                                           AddAdult

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(19);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(20, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(21);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(22, "\r\n                \r\n                    ");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "header");
                __builder2.AddAttribute(25, "b-grdsxhvof1");
                __builder2.OpenElement(26, "span");
                __builder2.AddAttribute(27, "b-grdsxhvof1");
                __builder2.AddContent(28, 
#nullable restore
#line 22 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\EditComponent.razor"
                                 ComponentTile

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n                        <br b-grdsxhvof1> ");
                __builder2.OpenElement(30, "span");
                __builder2.AddAttribute(31, "class", "error");
                __builder2.AddAttribute(32, "b-grdsxhvof1");
                __builder2.AddContent(33, 
#nullable restore
#line 23 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\EditComponent.razor"
                                                   errorMessage

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n                    ");
                __builder2.OpenElement(35, "span");
                __builder2.AddAttribute(36, "b-grdsxhvof1");
                __builder2.AddContent(37, 
#nullable restore
#line 25 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\EditComponent.razor"
                            errorMessage

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n                    ");
                __builder2.OpenElement(39, "div");
                __builder2.AddAttribute(40, "class", "form-field");
                __builder2.AddAttribute(41, "b-grdsxhvof1");
                __builder2.AddMarkupContent(42, "<div b-grdsxhvof1><label b-grdsxhvof1> First Name </label></div>\r\n                        ");
                __builder2.OpenElement(43, "div");
                __builder2.AddAttribute(44, "b-grdsxhvof1");
                __builder2.OpenElement(45, "input");
                __builder2.AddAttribute(46, "placeholder", "First Name");
                __builder2.AddAttribute(47, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 31 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\EditComponent.razor"
                                                                    adultToEdit.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(48, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => adultToEdit.FirstName = __value, adultToEdit.FirstName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddAttribute(49, "b-grdsxhvof1");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n                    ");
                __builder2.OpenElement(51, "div");
                __builder2.AddAttribute(52, "class", "form-field");
                __builder2.AddAttribute(53, "b-grdsxhvof1");
                __builder2.AddMarkupContent(54, "<div b-grdsxhvof1><label b-grdsxhvof1> Last Name </label></div>\r\n                        ");
                __builder2.OpenElement(55, "div");
                __builder2.AddAttribute(56, "b-grdsxhvof1");
                __builder2.OpenElement(57, "input");
                __builder2.AddAttribute(58, "placeholder", "Last name");
                __builder2.AddAttribute(59, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 37 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\EditComponent.razor"
                                                                    adultToEdit.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(60, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => adultToEdit.LastName = __value, adultToEdit.LastName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddAttribute(61, "b-grdsxhvof1");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(62, "\r\n                    ");
                __builder2.OpenElement(63, "div");
                __builder2.AddAttribute(64, "class", "form-field");
                __builder2.AddAttribute(65, "b-grdsxhvof1");
                __builder2.AddMarkupContent(66, "<div b-grdsxhvof1><label class=\"username\" b-grdsxhvof1>Age</label></div>\r\n                        ");
                __builder2.OpenElement(67, "div");
                __builder2.AddAttribute(68, "b-grdsxhvof1");
                __builder2.OpenElement(69, "input");
                __builder2.AddAttribute(70, "placeholder", "Age");
                __builder2.AddAttribute(71, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 41 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\EditComponent.razor"
                                                              adultToEdit.Age

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(72, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => adultToEdit.Age = __value, adultToEdit.Age));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddAttribute(73, "b-grdsxhvof1");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(74, "\r\n                    ");
                __builder2.OpenElement(75, "div");
                __builder2.AddAttribute(76, "class", "form-field");
                __builder2.AddAttribute(77, "b-grdsxhvof1");
                __builder2.AddMarkupContent(78, "<div b-grdsxhvof1><label class=\"password\" b-grdsxhvof1>HaierColor</label></div>\r\n                        ");
                __builder2.OpenElement(79, "div");
                __builder2.AddAttribute(80, "b-grdsxhvof1");
                __builder2.OpenElement(81, "input");
                __builder2.AddAttribute(82, "placeholder", "HaierColor");
                __builder2.AddAttribute(83, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 46 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\EditComponent.razor"
                                                                     adultToEdit.HairColor

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(84, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => adultToEdit.HairColor = __value, adultToEdit.HairColor));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddAttribute(85, "b-grdsxhvof1");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(86, "\r\n                    ");
                __builder2.OpenElement(87, "div");
                __builder2.AddAttribute(88, "class", "form-field");
                __builder2.AddAttribute(89, "b-grdsxhvof1");
                __builder2.AddMarkupContent(90, "<div b-grdsxhvof1><label class=\"password\" b-grdsxhvof1>EyeColor</label></div>\r\n                        ");
                __builder2.OpenElement(91, "div");
                __builder2.AddAttribute(92, "b-grdsxhvof1");
                __builder2.OpenElement(93, "input");
                __builder2.AddAttribute(94, "placeholder", "EyeColor");
                __builder2.AddAttribute(95, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 51 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\EditComponent.razor"
                                                                   adultToEdit.EyeColor

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(96, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => adultToEdit.EyeColor = __value, adultToEdit.EyeColor));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddAttribute(97, "b-grdsxhvof1");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(98, "\r\n                    ");
                __builder2.OpenElement(99, "div");
                __builder2.AddAttribute(100, "class", "form-field");
                __builder2.AddAttribute(101, "b-grdsxhvof1");
                __builder2.AddMarkupContent(102, "<div b-grdsxhvof1><label class=\"password\" b-grdsxhvof1>Weight</label></div>\r\n                        ");
                __builder2.OpenElement(103, "div");
                __builder2.AddAttribute(104, "b-grdsxhvof1");
                __builder2.OpenElement(105, "input");
                __builder2.AddAttribute(106, "placeholder", "Weight");
                __builder2.AddAttribute(107, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 56 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\EditComponent.razor"
                                                                 adultToEdit.Weight

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(108, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => adultToEdit.Weight = __value, adultToEdit.Weight));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddAttribute(109, "b-grdsxhvof1");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(110, "\r\n                    ");
                __builder2.OpenElement(111, "div");
                __builder2.AddAttribute(112, "class", "form-field");
                __builder2.AddAttribute(113, "b-grdsxhvof1");
                __builder2.AddMarkupContent(114, "<div b-grdsxhvof1><label class=\"password\" b-grdsxhvof1><span class=\"oi oi-role\" b-grdsxhvof1></span>Sex</label></div>\r\n                        ");
                __builder2.OpenElement(115, "div");
                __builder2.AddAttribute(116, "class", "roleSelector");
                __builder2.AddAttribute(117, "b-grdsxhvof1");
                __Blazor.Blazor.Pages.EditComponent.TypeInference.CreateInputSelect_0(__builder2, 118, 119, @"width: 12rem; height: 2rem;     
                           border: none;
                           margin-left: 4.3rem;
                              border-radius: 10px 10px 10px 10px;
                              border-bottom: 1px solid #8d8a8a;
                              box-shadow: 0px 10px 22px -7px rgba(94,118,217,1);
      
                           ", 120, "role", 121, 
#nullable restore
#line 68 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\EditComponent.razor"
                                                     adultToEdit.Sex

#line default
#line hidden
#nullable disable
                , 122, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => adultToEdit.Sex = __value, adultToEdit.Sex)), 123, () => adultToEdit.Sex, 124, (__builder3) => {
                    __builder3.AddMarkupContent(125, "<option value=\"F\" b-grdsxhvof1>F</option>\r\n                                ");
                    __builder3.AddMarkupContent(126, "<option value=\"M\" b-grdsxhvof1>M</option>");
                }
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(127, "\r\n\r\n                    ");
                __builder2.OpenElement(128, "div");
                __builder2.AddAttribute(129, "class", "form-field footer");
                __builder2.AddAttribute(130, "b-grdsxhvof1");
                __builder2.AddMarkupContent(131, "<div b-grdsxhvof1><button class=\"btn btn-success\" type=\"submit\" b-grdsxhvof1>Edit</button></div>\r\n                        ");
                __builder2.OpenElement(132, "div");
                __builder2.AddAttribute(133, "b-grdsxhvof1");
                __builder2.OpenElement(134, "button");
                __builder2.AddAttribute(135, "class", "btn btn-secondary");
                __builder2.AddAttribute(136, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 78 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\EditComponent.razor"
                                                                         ClosePop

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(137, "b-grdsxhvof1");
                __builder2.AddContent(138, "Cancel");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 84 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\EditComponent.razor"
  
    
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 88 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\EditComponent.razor"
       
    [Parameter]
    public string ComponentTile { get; set; }
    
    [Parameter]
    public int AdultID { get; set; }
    
  
    
    private Adult adultToEdit = new Adult();

    private string errorMessage { get; set; }

    
    private bool popup = false;

    private void ShowPop()
    {
        popup = true;
    }

    private void ClosePop()
    {
        popup = false;
    }

    protected override async Task OnInitializedAsync()
    {
        adultToEdit = await familyApi.GetAdult(AdultID);
    }
    private void AddAdult()
    {
        try
        {
            familyApi.UpdateAdult(adultToEdit);
            popup = false;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            errorMessage = e.Message;
        }
   
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavgMan { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFamilyApi familyApi { get; set; }
    }
}
namespace __Blazor.Blazor.Pages.EditComponent
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "style", __arg0);
        __builder.AddAttribute(__seq1, "id", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
