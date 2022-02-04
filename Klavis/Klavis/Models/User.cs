using System;
using Google.Cloud.Firestore;

namespace Klavis.Models
{
    [FirestoreData]
    public class User
    {
        public string UserID { get; set; }
        public DateTime date { get; set; }
        [FirestoreProperty]
        public string firstName { get; set; }
        [FirestoreProperty]
        public string lastName { get; set; }
        [FirestoreProperty]
        public string pictureLink { get; set; }
        [FirestoreProperty]
        public bool accountStatus { get; set; }
        [FirestoreProperty]
        public bool cardCreated { get; set; }
        [FirestoreProperty]
        public DateTime dateCreated { get; set; }

    }
    
}
