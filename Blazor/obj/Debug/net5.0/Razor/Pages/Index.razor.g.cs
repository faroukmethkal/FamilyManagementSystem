#pragma checksum "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bcf521af98c1109e533c824e6a8f525df1a7e51f"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
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
#line 2 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\Index.razor"
using Blazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\Index.razor"
using Entitiy;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\Index.razor"
using Blazor.Pages.FamilyDetails;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "myContainer");
            __builder.AddAttribute(2, "b-ci4vf3jic1");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "myField");
            __builder.AddAttribute(5, "b-ci4vf3jic1");
            __builder.AddMarkupContent(6, "<div b-ci4vf3jic1><label b-ci4vf3jic1>Minum Adult Age</label></div>\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "b-ci4vf3jic1");
            __builder.OpenElement(9, "input");
            __builder.AddAttribute(10, "type", "text");
            __builder.AddAttribute(11, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\Index.razor"
                                       minAdultAge

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => minAdultAge = __value, minAdultAge));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(13, "b-ci4vf3jic1");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "myField");
            __builder.AddAttribute(17, "b-ci4vf3jic1");
            __builder.AddMarkupContent(18, "<div b-ci4vf3jic1><label b-ci4vf3jic1>Max Adult Age</label></div>\r\n        ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "b-ci4vf3jic1");
            __builder.OpenElement(21, "input");
            __builder.AddAttribute(22, "type", "text");
            __builder.AddAttribute(23, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\Index.razor"
                                       maxAdultAge

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => maxAdultAge = __value, maxAdultAge));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(25, "b-ci4vf3jic1");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n    ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "myField");
            __builder.AddAttribute(29, "b-ci4vf3jic1");
            __builder.AddMarkupContent(30, "<div b-ci4vf3jic1><label b-ci4vf3jic1>Children</label></div>\r\n        ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "b-ci4vf3jic1");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "b-ci4vf3jic1");
            __builder.OpenElement(35, "select");
            __builder.AddAttribute(36, "style", @"width: 12rem; height: 2rem;     
                                          border: none;
                                          margin-left: 4.3rem;
                                             border-radius: 10px 10px 10px 10px;
                                             border-bottom: 1px solid #8d8a8a;
                                             box-shadow: 0px 10px 22px -7px rgba(94,118,217,1);
                     
                                          ");
            __builder.AddAttribute(37, "id", "role");
            __builder.AddAttribute(38, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 40 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\Index.razor"
                                                                 handleHasChildSelect

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(39, "b-ci4vf3jic1");
            __builder.OpenElement(40, "option");
            __builder.AddAttribute(41, "Value", "null");
            __builder.AddAttribute(42, "b-ci4vf3jic1");
            __builder.AddContent(43, "--");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                    ");
            __builder.OpenElement(45, "option");
            __builder.AddAttribute(46, "Value", "yes");
            __builder.AddAttribute(47, "b-ci4vf3jic1");
            __builder.AddContent(48, "Has children");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                    ");
            __builder.OpenElement(50, "option");
            __builder.AddAttribute(51, "Value", "no");
            __builder.AddAttribute(52, "b-ci4vf3jic1");
            __builder.AddContent(53, "Has no children");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n    ");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", "myField");
            __builder.AddAttribute(57, "b-ci4vf3jic1");
            __builder.AddMarkupContent(58, "<div b-ci4vf3jic1><label b-ci4vf3jic1>Pets</label></div>\r\n        ");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "b-ci4vf3jic1");
            __builder.OpenElement(61, "div");
            __builder.AddAttribute(62, "b-ci4vf3jic1");
            __builder.OpenElement(63, "select");
            __builder.AddAttribute(64, "style", @"width: 12rem; height: 2rem;     
                                  border: none;
                                  margin-left: 4.3rem;
                                     border-radius: 10px 10px 10px 10px;
                                     border-bottom: 1px solid #8d8a8a;
                                     box-shadow: 0px 10px 22px -7px rgba(94,118,217,1);
             
                                  ");
            __builder.AddAttribute(65, "id", "role");
            __builder.AddAttribute(66, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 62 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\Index.razor"
                                                         handleHasPetSelect

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(67, "b-ci4vf3jic1");
            __builder.OpenElement(68, "option");
            __builder.AddAttribute(69, "Value", "null");
            __builder.AddAttribute(70, "b-ci4vf3jic1");
            __builder.AddContent(71, "--");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n                    ");
            __builder.OpenElement(73, "option");
            __builder.AddAttribute(74, "Value", "yes");
            __builder.AddAttribute(75, "b-ci4vf3jic1");
            __builder.AddContent(76, "Has pets");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n                    ");
            __builder.OpenElement(78, "option");
            __builder.AddAttribute(79, "Value", "no");
            __builder.AddAttribute(80, "b-ci4vf3jic1");
            __builder.AddContent(81, "Has no pets");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n    ");
            __builder.OpenElement(83, "div");
            __builder.AddAttribute(84, "class", "myField");
            __builder.AddAttribute(85, "b-ci4vf3jic1");
            __builder.OpenElement(86, "button");
            __builder.AddAttribute(87, "class", "btn btn-success");
            __builder.AddAttribute(88, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 72 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\Index.razor"
                                                   onButtonClick

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(89, "b-ci4vf3jic1");
            __builder.AddContent(90, "Filter");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 77 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\Index.razor"
 if (families == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(91, "<p b-ci4vf3jic1>List is not exist </p>");
#nullable restore
#line 80 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\Index.razor"
}
else if (!families.Any())
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(92, "<p b-ci4vf3jic1>Loading..................</p>");
#nullable restore
#line 84 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\Index.razor"
}
else
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 87 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\Index.razor"
     foreach (Family family in families)

    {
     

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Blazor.Pages.FamilyDetails.FamilyDetails>(93);
            __builder.AddAttribute(94, "Family", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Entitiy.Family>(
#nullable restore
#line 91 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\Index.razor"
                                family

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 92 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\Index.razor"
        
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 93 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\Index.razor"
             
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 97 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\Index.razor"
 
    private int? minAdultAge;
    private int? maxAdultAge;
    private bool? hasChild;
    private bool? hasPet;

    private IList<Family> families;
    [Parameter]
    public Family Family { get; set; }
    

    protected override async Task OnInitializedAsync()
    {
        families = await familyApi.getAllFamily(minAdultAge, maxAdultAge, hasChild, hasPet);
        Console.WriteLine(families.Count);
    }

    private void handleHasChildSelect(ChangeEventArgs e)
    {
        hasChild = e.Value.ToString().ToLower().Equals("yes") ? true : e.Value.ToString().ToLower().Equals("no") ? false : null;
    }

    private void handleHasPetSelect(ChangeEventArgs e)
    {
        hasPet = e.Value.ToString().ToLower().Equals("yes") ? true : e.Value.ToString().ToLower().Equals("no") ? false : null;
    }

    private async Task onButtonClick()
    {
        families = await familyApi.getAllFamily(minAdultAge, maxAdultAge, hasChild, hasPet);
        Console.WriteLine($@"max {maxAdultAge} min {minAdultAge}");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFamilyApi familyApi { get; set; }
    }
}
#pragma warning restore 1591
