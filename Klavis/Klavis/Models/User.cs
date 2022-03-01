using System;
using Google.Cloud.Firestore;

namespace Klavis.Models
{
    [FirestoreData]
    public class User
    {
        public string userID { get; set; }
        [FirestoreProperty]
        public bool accountStatus { get; set; }
        [FirestoreProperty]
        public bool cardCreated { get; set; }
        [FirestoreProperty]
        public string cardSerial { get; set; }
        [FirestoreProperty]
        public DateTime dateCreated { get; set; }
        [FirestoreProperty]
        public string email { get; set; }
        [FirestoreProperty]
        public string firstName { get; set; }
        [FirestoreProperty]
        public string lastName { get; set; }
        [FirestoreProperty]
        public string pictureLink { get; set; }
        
        
        

    }
    
}
