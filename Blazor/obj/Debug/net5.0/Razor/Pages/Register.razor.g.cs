#pragma checksum "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\Register.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d81eafe4c851c2aabb4c58a70e4bc98deef5e060"
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
#line 2 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\Register.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\Register.razor"
using Entitiy;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\Register.razor"
using Blazor.Authentication;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Register")]
    public partial class Register : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "form");
            __builder.AddAttribute(2, "b-be1upc63yq");
            __builder.AddMarkupContent(3, "<div class=\"form-header\" b-be1upc63yq><h2 b-be1upc63yq>\r\n            Login\r\n        </h2></div>\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "b-be1upc63yq");
            __builder.OpenElement(6, "span");
            __builder.AddAttribute(7, "class", "error-message");
            __builder.AddAttribute(8, "b-be1upc63yq");
            __builder.AddContent(9, 
#nullable restore
#line 15 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\Register.razor"
                                     errorMessage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "form__group");
            __builder.AddAttribute(13, "b-be1upc63yq");
            __builder.OpenElement(14, "input");
            __builder.AddAttribute(15, "type", "text");
            __builder.AddAttribute(16, "class", "form__input");
            __builder.AddAttribute(17, "placeholder", "Username");
            __builder.AddAttribute(18, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\Register.razor"
                                                                              newUser.FirstName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newUser.FirstName = __value, newUser.FirstName));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(20, "b-be1upc63yq");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n        ");
            __builder.AddMarkupContent(22, "<label for=\"name\" class=\"form__label\" b-be1upc63yq>First name</label>");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n\r\n    ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "form__group");
            __builder.AddAttribute(26, "b-be1upc63yq");
            __builder.OpenElement(27, "input");
            __builder.AddAttribute(28, "type", "text");
            __builder.AddAttribute(29, "class", "form__input");
            __builder.AddAttribute(30, "placeholder", "Username");
            __builder.AddAttribute(31, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 23 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\Register.razor"
                                                                              newUser.LastNAme

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(32, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newUser.LastNAme = __value, newUser.LastNAme));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(33, "b-be1upc63yq");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n        ");
            __builder.AddMarkupContent(35, "<label for=\"name\" class=\"form__label\" b-be1upc63yq>Last name</label>");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n\r\n\r\n    ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "form__group");
            __builder.AddAttribute(39, "b-be1upc63yq");
            __builder.OpenElement(40, "input");
            __builder.AddAttribute(41, "type", "text");
            __builder.AddAttribute(42, "class", "form__input");
            __builder.AddAttribute(43, "placeholder", "Username");
            __builder.AddAttribute(44, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 29 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\Register.razor"
                                                                              newUser.Username

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(45, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newUser.Username = __value, newUser.Username));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(46, "b-be1upc63yq");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n        ");
            __builder.AddMarkupContent(48, "<label for=\"name\" class=\"form__label\" b-be1upc63yq>Username</label>");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n\r\n    ");
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "class", "form__group");
            __builder.AddAttribute(52, "b-be1upc63yq");
            __builder.OpenElement(53, "input");
            __builder.AddAttribute(54, "type", "password");
            __builder.AddAttribute(55, "class", "form__input");
            __builder.AddAttribute(56, "placeholder", "Password");
            __builder.AddAttribute(57, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 34 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\Register.razor"
                                                                                  newUser.Password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(58, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newUser.Password = __value, newUser.Password));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(59, "b-be1upc63yq");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n        ");
            __builder.AddMarkupContent(61, "<label class=\"form__label\" b-be1upc63yq>Password</label>");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n    ");
            __builder.OpenElement(63, "div");
            __builder.AddAttribute(64, "class", "form__group");
            __builder.AddAttribute(65, "b-be1upc63yq");
            __builder.OpenElement(66, "div");
            __builder.AddAttribute(67, "b-be1upc63yq");
            __builder.OpenElement(68, "select");
            __builder.AddAttribute(69, "name", "role");
            __builder.AddAttribute(70, "class", "form__input_select");
            __builder.AddAttribute(71, "rows", "1");
            __builder.AddAttribute(72, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 40 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\Register.razor"
                                                                           newUser.Role

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(73, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newUser.Role = __value, newUser.Role));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(74, "b-be1upc63yq");
            __builder.OpenElement(75, "option");
            __builder.AddAttribute(76, "value", 
#nullable restore
#line 41 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\Register.razor"
                                Role.Admin

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(77, "b-be1upc63yq");
            __builder.AddContent(78, "Admin");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n                ");
            __builder.OpenElement(80, "option");
            __builder.AddAttribute(81, "value", 
#nullable restore
#line 42 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\Register.razor"
                                Role.SocialHelper

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(82, "b-be1upc63yq");
            __builder.AddContent(83, "Social Helper");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n        ");
            __builder.AddMarkupContent(85, "<div class=\"icon\" b-be1upc63yq><label class=\"form__label\" b-be1upc63yq><span class=\"oi oi-pencil\" b-be1upc63yq></span> Role</label></div>");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n\r\n    ");
            __builder.OpenElement(87, "div");
            __builder.AddAttribute(88, "class", "form__group");
            __builder.AddAttribute(89, "b-be1upc63yq");
            __builder.OpenElement(90, "button");
            __builder.AddAttribute(91, "class", "button-white");
            __builder.AddAttribute(92, "type", "submit");
            __builder.AddAttribute(93, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 52 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\Register.razor"
                                                             PerformRegisteration

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(94, "b-be1upc63yq");
            __builder.AddContent(95, "Register");
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n        ");
            __builder.AddMarkupContent(97, "<a class=\"button-white\" href=\"Login\" b-be1upc63yq>Login</a>");
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n    <div class=\"form__group\" b-be1upc63yq></div>");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 60 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\Register.razor"
       

    User newUser = new User();
    private string errorMessage;

    public async Task PerformRegisteration()
    {
        try
        {
            await ((CustomAuthenticationStateProvider) AuthenticationStateProvider).ValidateRegistration(newUser);
            NavgMan.NavigateTo("/");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            errorMessage = e.Message;
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavgMan { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
