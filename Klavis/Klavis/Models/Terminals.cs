using System;
using Google.Cloud.Firestore;

namespace Klavis.Models
{
    [FirestoreData]
    public class Terminals
    {
        public string terminalName { get; set; }
    }
}
