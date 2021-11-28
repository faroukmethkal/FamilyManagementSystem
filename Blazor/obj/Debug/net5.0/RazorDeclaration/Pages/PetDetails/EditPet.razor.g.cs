// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Blazor.Pages.PetDetails
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
#line 2 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\PetDetails\EditPet.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\PetDetails\EditPet.razor"
using Blazor.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\PetDetails\EditPet.razor"
using Entitiy;

#line default
#line hidden
#nullable disable
    public partial class EditPet : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 56 "F:\VIA\Third Semester\C#\ThierdAssignment\FamilyRegistration\Blazor\Pages\PetDetails\EditPet.razor"
       
    [Parameter]
    public string ComponentTile { get; set; }

    [Parameter]
    public int petId { get; set; }
 
    
    private Pet petToEdit;

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
        petToEdit = await familyApi.GetPet(petId);
    }

    private void AddPet()
    {
        try
        {
         
          familyApi.UpdatePet(petToEdit);
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
#pragma warning restore 1591
