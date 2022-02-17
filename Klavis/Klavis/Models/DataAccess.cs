using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Google.Cloud.Firestore;
using Newtonsoft.Json;

namespace Klavis.Models
{
    public class DataAccess
    {
        string projectId;
        FirestoreDb fireStoreDb;
        public DataAccess()
        {
            string filepath = "D:\\OneDrive\\Documents\\GitHub\\klavis-web\\klavis-4b8d1-firebase-adminsdk-qfivj-43bca72afa.json";
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", filepath);
            projectId = "klavis-4b8d1";
            fireStoreDb = FirestoreDb.Create(projectId);
        }
        

        public async void addUser(User user, string location)
        {
            
            // Updating database
            DocumentReference userRef = fireStoreDb.Collection("access").Document(location).Collection("users").Document(user.userID);
            Dictionary<string, object> userData = new Dictionary<string, object>
                {
                    { "firstname", user.firstName },
                    { "lastname", user.lastName },
                    { "pictureLink", user.pictureLink }
                };
            await userRef.SetAsync(userData);

            //Querying database to check
            DocumentReference checkuserRef = fireStoreDb.Collection("access").Document(location).Collection("users").Document(user.userID);
            DocumentSnapshot snapshot = await checkuserRef.GetSnapshotAsync();

            if (snapshot.Exists)
            {
                
            }
        }
        public async void deleteUser(User user, string location)
        {
            try
            {
                DocumentReference checkuserRef = fireStoreDb.Collection("access").Document(location).Collection("users").Document(user.userID);
                await checkuserRef.DeleteAsync();
            }
            catch
            {
                throw;
            }
        }
        public async void updateUser(User user, string location)
        {
            try
            {
                DocumentReference userRef = fireStoreDb.Collection("access").Document(location).Collection("users").Document(user.userID);

                await userRef.SetAsync(user, SetOptions.Overwrite);
            }
            catch
            {
                throw;
            }
        }

        public async Task<User> queryUser(string user, string terminal)
        {
            try
            {
                DocumentReference userRef = fireStoreDb.Collection("access").Document(terminal).Collection("users").Document(user);
                DocumentSnapshot snapshot = await userRef.GetSnapshotAsync();

                if (snapshot.Exists)
                {
                    User usr = snapshot.ConvertTo<User>();
                    return usr;
                }
                else
                {
                    return new User();
                }
            }
            catch
            {
                throw;
            }
        }

        public async Task<List<Terminals>> queryTerminals()
        {
            try
            {
                Query terminalsQuery = fireStoreDb.Collection("access");
                QuerySnapshot terminalsQuerySnapshot = await terminalsQuery.GetSnapshotAsync();
                List<Terminals> lstTerminal = new List<Terminals>();

                foreach (DocumentSnapshot documentSnapshot in terminalsQuerySnapshot.Documents)
                {
                    if (documentSnapshot.Exists)
                    {
                        Dictionary<string, object> terminal = documentSnapshot.ToDictionary();
                        string json = JsonConvert.SerializeObject(terminal);
                        Terminals newTerminal = JsonConvert.DeserializeObject<Terminals>(json);
                        lstTerminal.Add(newTerminal);
                    }
                }
                return lstTerminal;
            }
            catch
            {
                throw;
            }
        }
    }
}
