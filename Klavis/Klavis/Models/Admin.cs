using System;
using Google.Cloud.Firestore;

namespace Klavis.Models
{
	[FirestoreData]
	public class Admin
	{
		[FirestoreProperty]
		public string email { get; set; }
	}
}