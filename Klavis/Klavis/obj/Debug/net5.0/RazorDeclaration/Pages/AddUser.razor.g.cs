// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Klavis.Pages
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\OneDrive\Documents\GitHub\klavis-web\Klavis\Klavis\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\OneDrive\Documents\GitHub\klavis-web\Klavis\Klavis\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\OneDrive\Documents\GitHub\klavis-web\Klavis\Klavis\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\OneDrive\Documents\GitHub\klavis-web\Klavis\Klavis\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\OneDrive\Documents\GitHub\klavis-web\Klavis\Klavis\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\OneDrive\Documents\GitHub\klavis-web\Klavis\Klavis\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\OneDrive\Documents\GitHub\klavis-web\Klavis\Klavis\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\OneDrive\Documents\GitHub\klavis-web\Klavis\Klavis\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\OneDrive\Documents\GitHub\klavis-web\Klavis\Klavis\_Imports.razor"
using Klavis;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\OneDrive\Documents\GitHub\klavis-web\Klavis\Klavis\_Imports.razor"
using Klavis.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\OneDrive\Documents\GitHub\klavis-web\Klavis\Klavis\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\OneDrive\Documents\GitHub\klavis-web\Klavis\Klavis\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\OneDrive\Documents\GitHub\klavis-web\Klavis\Klavis\Pages\AddUser.razor"
using Google.Cloud.Firestore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\OneDrive\Documents\GitHub\klavis-web\Klavis\Klavis\Pages\AddUser.razor"
using System;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/adduser")]
    public partial class AddUser : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 81 "D:\OneDrive\Documents\GitHub\klavis-web\Klavis\Klavis\Pages\AddUser.razor"
      
    FirestoreDb fireStoreDb;
    private string firstName;
    private string lastName;
    private string userID;
    private string email;
    private string pictureLink;
    private bool cardCreated;
    private bool accountStatus;


    protected override async Task OnInitializedAsync()
    {
        Console.WriteLine("Connecting");
        string filepath = "wwwroot/klavis-4b8d1-eb6f81dfbefe.json";
        Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", filepath);
        fireStoreDb = FirestoreDb.Create("klavis-4b8d1");

        StateHasChanged();
    }

    async void addUser()
    {
        Dictionary<string, object> log = new Dictionary<string, object>
            {
                { "firstname", firstName },
                { "lastname", lastName },
                { "email", email },
                { "accountStatus", true },
                { "cardCreated", cardCreated },
                { "pictureLink", pictureLink },
                { "created", DateTime.UtcNow }
            };
            await fireStoreDb.Collection("users").Document(userID).SetAsync(log);
            NavigationManager.NavigateTo("/usermanagement");
    }

    void cancel(){
        NavigationManager.NavigateTo("/usermanagement");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
