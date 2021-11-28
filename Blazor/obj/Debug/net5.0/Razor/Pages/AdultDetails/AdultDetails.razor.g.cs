#pragma checksum "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\AdultDetails\AdultDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "705d00fdf95e871f0e47094aeea5126e0dfb6c5f"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazor.Pages.AdultDetails
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
#line 2 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\AdultDetails\AdultDetails.razor"
using Blazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\AdultDetails\AdultDetails.razor"
using Entitiy;

#line default
#line hidden
#nullable disable
    public partial class AdultDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Blazor.Pages.RubberComponent>(0);
            __builder.AddAttribute(1, "ComponentTitle", "Adult");
            __builder.AddAttribute(2, "Family", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Entitiy.Family>(
#nullable restore
#line 6 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\AdultDetails\AdultDetails.razor"
                                                 Family

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "container");
                __builder2.OpenElement(6, "table");
                __builder2.AddAttribute(7, "class", "table ");
                __builder2.OpenElement(8, "thead");
                __builder2.AddAttribute(9, "class", "thead-light");
                __builder2.OpenElement(10, "tr");
                __builder2.AddMarkupContent(11, "<th scope=\"col\">Name</th>\r\n                ");
                __builder2.AddMarkupContent(12, "<th scope=\"col\">Age</th>\r\n                ");
                __builder2.AddMarkupContent(13, "<th scope=\"col\">Sex</th>\r\n                ");
                __builder2.AddMarkupContent(14, "<th scope=\"col\">HaierColor</th>\r\n                ");
                __builder2.AddMarkupContent(15, "<th scope=\"col\">EyeColor</th>\r\n                ");
                __builder2.AddMarkupContent(16, "<th scope=\"col\">Weight</th>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(17);
                __builder2.AddAttribute(18, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(19, "<th scope=\"col\">Edit</th>\r\n                        ");
                    __builder3.AddMarkupContent(20, "<th scope=\"col\">Remove</th>");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 28 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\AdultDetails\AdultDetails.razor"
             foreach (Adult adult in Family.Adults)
            {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(21, "tbody");
                __builder2.OpenElement(22, "tr");
                __builder2.OpenElement(23, "td");
                __builder2.AddContent(24, 
#nullable restore
#line 32 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\AdultDetails\AdultDetails.razor"
                         adult.FirstName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(25, " ");
                __builder2.AddContent(26, 
#nullable restore
#line 32 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\AdultDetails\AdultDetails.razor"
                                          adult.LastName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n                    ");
                __builder2.OpenElement(28, "td");
                __builder2.AddContent(29, 
#nullable restore
#line 33 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\AdultDetails\AdultDetails.razor"
                         adult.Age

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n                    ");
                __builder2.OpenElement(31, "td");
                __builder2.AddContent(32, 
#nullable restore
#line 34 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\AdultDetails\AdultDetails.razor"
                         adult.Sex

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n                    ");
                __builder2.OpenElement(34, "td");
                __builder2.AddContent(35, 
#nullable restore
#line 35 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\AdultDetails\AdultDetails.razor"
                         adult.HairColor

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n                    ");
                __builder2.OpenElement(37, "td");
                __builder2.AddContent(38, 
#nullable restore
#line 36 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\AdultDetails\AdultDetails.razor"
                         adult.EyeColor

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n                    ");
                __builder2.OpenElement(40, "td");
                __builder2.AddContent(41, 
#nullable restore
#line 37 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\AdultDetails\AdultDetails.razor"
                         adult.Weight

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(43);
                __builder2.AddAttribute(44, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder3) => {
                    __builder3.OpenElement(45, "td");
                    __builder3.OpenElement(46, "div");
                    __builder3.OpenComponent<Blazor.Pages.EditComponent>(47);
                    __builder3.AddAttribute(48, "AdultID", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 41 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\AdultDetails\AdultDetails.razor"
                                                              adult.Id

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(49, "ComponentTile", "Edit Adult");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(50, "\r\n                            ");
                    __builder3.OpenElement(51, "td");
                    __builder3.OpenElement(52, "button");
                    __builder3.AddAttribute(53, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\AdultDetails\AdultDetails.razor"
                                                    () => RemoveAdult(adult.Id)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddMarkupContent(54, "<span class=\"oi oi-trash\"></span>");
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 55 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\AdultDetails\AdultDetails.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 63 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\AdultDetails\AdultDetails.razor"
       
    
    [Parameter]
    public Family Family { get; set; }
    
    private void RemoveAdult(int aId)
    {
        Adult adultToRemove = Family.Adults.First(a => a.Id == aId);
        familyApi.RemoveAdult(aId);
        Family.Adults.Remove(adultToRemove);
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFamilyApi familyApi { get; set; }
    }
}
#pragma warning restore 1591