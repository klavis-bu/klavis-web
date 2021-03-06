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
#line 3 "D:\OneDrive\Documents\GitHub\klavis-web\Klavis\Klavis\Pages\History.razor"
using Google.Cloud.Firestore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\OneDrive\Documents\GitHub\klavis-web\Klavis\Klavis\Pages\History.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\OneDrive\Documents\GitHub\klavis-web\Klavis\Klavis\Pages\History.razor"
using Klavis.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/history")]
    public partial class History : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "D:\OneDrive\Documents\GitHub\klavis-web\Klavis\Klavis\Pages\History.razor"
       

    FirestoreDb fireStoreDb;
    private string security_key_path = "wwwroot/klavis-4b8d1-eb6f81dfbefe.json";
    private string userID;
    private string terminal;
    private string terminalList;
    private string firstName;
    private string lastName;
    private string picturePath;
    private Google.Cloud.Firestore.Timestamp timestamp;
    private string connection = "Disconnected";
    private bool accessStatus;
    private bool accountStatus;
    private List<Dictionary<string, object>> accessHistory = null;

    protected override async Task OnInitializedAsync()
    {
        Console.WriteLine("Connecting");
        string filepath = "wwwroot/klavis-4b8d1-eb6f81dfbefe.json";
        Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", filepath);
        fireStoreDb = FirestoreDb.Create("klavis-4b8d1");

        DocumentReference userRef = fireStoreDb.Collection("access").Document("designlab");
        DocumentSnapshot snapshot = await userRef.GetSnapshotAsync();
        if (snapshot.Exists)
        {
            connection = "Connected";
        }
        queryHistory("designlab");
        StateHasChanged();
    }

    async void queryHistory(string terminal)
    {
        Google.Cloud.Firestore.Query historyQuery = fireStoreDb.Collection("history").WhereEqualTo("terminal",terminal);
        QuerySnapshot historyQuerySnapshot = await historyQuery.GetSnapshotAsync();
        List<Dictionary<string, object>> records = new List<Dictionary<string, object>>();
        foreach (DocumentSnapshot documentSnapshot in historyQuerySnapshot.Documents)
        {
            Dictionary<string, object> recordDictionary = documentSnapshot.ToDictionary();
            records.Add(recordDictionary);

            accessStatus = (bool) recordDictionary["accessStatus"];
            accountStatus = (bool) recordDictionary["accountStatus"];
            userID = (string) recordDictionary["id"];
            firstName = (string) recordDictionary["firstname"];
            lastName = (string) recordDictionary["lastname"];
            timestamp= (Google.Cloud.Firestore.Timestamp) recordDictionary["timestamp"];
        }
        accessHistory = records;
        StateHasChanged(); 



    }

    async void clearHistory()
    {
        QuerySnapshot snapshot = await fireStoreDb.Collection("history").Limit(64).GetSnapshotAsync();
        IReadOnlyList<DocumentSnapshot> documents = snapshot.Documents;
        while (documents.Count > 0)
        {
            foreach (DocumentSnapshot document in documents)
            {
                await document.Reference.DeleteAsync();
            }
            snapshot = await fireStoreDb.Collection("history").Limit(64).GetSnapshotAsync();
            documents = snapshot.Documents;
        }
        StateHasChanged();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
