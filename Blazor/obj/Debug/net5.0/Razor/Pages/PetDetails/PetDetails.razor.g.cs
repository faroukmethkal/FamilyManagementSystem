#pragma checksum "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\PetDetails\PetDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e329d0deb893af1b4f23e68a5d9167e41b3b520"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazor.Pages.PetDetails
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
#line 1 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\PetDetails\PetDetails.razor"
using Blazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\PetDetails\PetDetails.razor"
using Entitiy;

#line default
#line hidden
#nullable disable
    public partial class PetDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Blazor.Pages.RubberComponent>(0);
            __builder.AddAttribute(1, "ComponentTitle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 6 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\PetDetails\PetDetails.razor"
                                  ComponentTitle

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "Family", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Entitiy.Family>(
#nullable restore
#line 6 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\PetDetails\PetDetails.razor"
                                                           Family

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
#nullable restore
#line 7 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\PetDetails\PetDetails.razor"
     if (ComponentTitle.Equals("Pets"))
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\PetDetails\PetDetails.razor"
         if (Family.Pets.Any())
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(4, "table");
                __builder2.AddAttribute(5, "class", "table");
                __builder2.OpenElement(6, "thead");
                __builder2.AddAttribute(7, "class", "thead-dark");
                __builder2.OpenElement(8, "tr");
                __builder2.AddMarkupContent(9, "<th scope=\"col\">Id</th>\r\n                    ");
                __builder2.AddMarkupContent(10, "<th scope=\"col\">Name</th>\r\n                    ");
                __builder2.AddMarkupContent(11, "<th scope=\"col\">Species</th>\r\n                    ");
                __builder2.AddMarkupContent(12, "<th scope=\"col\">Age</th>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(13);
                __builder2.AddAttribute(14, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(15, "<th scope=\"col\">Edit</th>\r\n                            ");
                    __builder3.AddMarkupContent(16, "<th scope=\"col\">Remove</th>");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 28 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\PetDetails\PetDetails.razor"
                 foreach (Pet pet in Family.Pets)
                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(17, "tbody");
                __builder2.OpenElement(18, "tr");
                __builder2.OpenElement(19, "td");
                __builder2.AddContent(20, 
#nullable restore
#line 32 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\PetDetails\PetDetails.razor"
                             pet.Id

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n                        ");
                __builder2.OpenElement(22, "td");
                __builder2.AddContent(23, 
#nullable restore
#line 33 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\PetDetails\PetDetails.razor"
                             pet.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n                        ");
                __builder2.OpenElement(25, "td");
                __builder2.AddContent(26, 
#nullable restore
#line 34 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\PetDetails\PetDetails.razor"
                             pet.Species

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n                        ");
                __builder2.OpenElement(28, "td");
                __builder2.AddContent(29, 
#nullable restore
#line 35 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\PetDetails\PetDetails.razor"
                             pet.Age

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(31);
                __builder2.AddAttribute(32, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder3) => {
                    __builder3.OpenElement(33, "td");
                    __builder3.OpenElement(34, "div");
                    __builder3.OpenComponent<Blazor.Pages.PetDetails.EditPet>(35);
                    __builder3.AddAttribute(36, "petId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 41 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\PetDetails\PetDetails.razor"
                                                         pet.Id

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(37, "ComponentTile", "Pets");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(38, "\r\n                                ");
                    __builder3.OpenElement(39, "td");
                    __builder3.OpenElement(40, "button");
                    __builder3.AddAttribute(41, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 45 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\PetDetails\PetDetails.razor"
                                                        () => RemovePet(pet.Id)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddMarkupContent(42, "<span class=\"oi oi-trash\"></span>");
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 55 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\PetDetails\PetDetails.razor"
                }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
#nullable restore
#line 59 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\PetDetails\PetDetails.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\PetDetails\PetDetails.razor"
         
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\PetDetails\PetDetails.razor"
     if (ComponentTitle.Equals("Child Pets"))
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\PetDetails\PetDetails.razor"
         if (ChildPets().Any())
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(43, "table");
                __builder2.AddAttribute(44, "class", "table");
                __builder2.OpenElement(45, "thead");
                __builder2.AddAttribute(46, "class", "thead-dark");
                __builder2.OpenElement(47, "tr");
                __builder2.AddMarkupContent(48, "<th scope=\"col\">Id</th>\r\n                    ");
                __builder2.AddMarkupContent(49, "<th scope=\"col\">Name</th>\r\n                    ");
                __builder2.AddMarkupContent(50, "<th scope=\"col\">Species</th>\r\n                    ");
                __builder2.AddMarkupContent(51, "<th scope=\"col\">Age</th>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(52);
                __builder2.AddAttribute(53, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(54, "<th scope=\"col\">Edit</th>\r\n                            ");
                    __builder3.AddMarkupContent(55, "<th scope=\"col\">Remove</th>");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 81 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\PetDetails\PetDetails.razor"
                 foreach (Pet pet in ChildPets())
                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(56, "tbody");
                __builder2.OpenElement(57, "tr");
                __builder2.OpenElement(58, "td");
                __builder2.AddContent(59, 
#nullable restore
#line 85 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\PetDetails\PetDetails.razor"
                             pet.Id

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n                        ");
                __builder2.OpenElement(61, "td");
                __builder2.AddContent(62, 
#nullable restore
#line 86 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\PetDetails\PetDetails.razor"
                             pet.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(63, "\r\n                        ");
                __builder2.OpenElement(64, "td");
                __builder2.AddContent(65, 
#nullable restore
#line 87 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\PetDetails\PetDetails.razor"
                             pet.Species

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(66, "\r\n                        ");
                __builder2.OpenElement(67, "td");
                __builder2.AddContent(68, 
#nullable restore
#line 88 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\PetDetails\PetDetails.razor"
                             pet.Age

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(69, "\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(70);
                __builder2.AddAttribute(71, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder3) => {
                    __builder3.OpenElement(72, "td");
                    __builder3.OpenElement(73, "div");
                    __builder3.OpenComponent<Blazor.Pages.PetDetails.EditPet>(74);
                    __builder3.AddAttribute(75, "petId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 93 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\PetDetails\PetDetails.razor"
                                                         pet.Id

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(76, "ComponentTile", "Child Pets");
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(77, "\r\n                                ");
                    __builder3.OpenElement(78, "td");
                    __builder3.OpenElement(79, "button");
                    __builder3.AddAttribute(80, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 97 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\PetDetails\PetDetails.razor"
                                                        () => RemovePet( pet.Id)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddMarkupContent(81, "<span class=\"oi oi-trash\"></span>");
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 106 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\PetDetails\PetDetails.razor"
                }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
#nullable restore
#line 110 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\PetDetails\PetDetails.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 110 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\PetDetails\PetDetails.razor"
         
    }
    else
    {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(82, "<span>Has no Pets</span>");
#nullable restore
#line 115 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\PetDetails\PetDetails.razor"
    }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 119 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\PetDetails\PetDetails.razor"
       
    
    [Parameter]
    public Family Family { get; set; }

    [Parameter]
    public string ComponentTitle { get; set; }

    [Parameter]
    public int Id { get; set; }

    private IList<Pet> ChildPets()
    {
        foreach (var child in Family.Children)
        {
            if (child.Id == Id)
            {
                return child.Pets;
            }
        }
        return null;
    }

    private void RemovePet(int pId)
    {
        Pet petToRemove = Family.Pets.First(p => p.Id == pId);
        familyApi.RemovePet( pId);
        Family.Pets.Remove(petToRemove);
    }






#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFamilyApi familyApi { get; set; }
    }
}
#pragma warning restore 1591
