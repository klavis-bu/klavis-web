using System;
using Google.Cloud.Firestore;

namespace Klavis.Models
{
    [FirestoreData]
    public class User
    {
        public string userID { get; set; }
        public DateTime date { get; set; }
        [FirestoreProperty]
        public string firstName { get; set; }
        [FirestoreProperty]
        public string lastName { get; set; }
        [FirestoreProperty]
        public string pictureLink { get; set; }

    }
}
