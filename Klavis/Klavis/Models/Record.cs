using System;
using Google.Cloud.Firestore;

namespace Klavis.Models
{
    [FirestoreData]
    public class Record
    {
        public string userID { get; set; }
        public DateTime timestamp { get; set; }
        [FirestoreProperty]
        public string firstName { get; set; }
        [FirestoreProperty]
        public string lastName { get; set; }
        [FirestoreProperty]
        public string pictureLink { get; set; }
        [FirestoreProperty]
        public bool accessStatus { get; set; }
        [FirestoreProperty]
        public bool accountStatus { get; set; }

    }
}
