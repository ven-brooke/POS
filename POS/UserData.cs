using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS
{
    [FirestoreData]
    internal class UserData
    {
        [FirestoreProperty]
        public string Username { get; set; }
        [FirestoreProperty]
        public string Password { get; set; }
        [FirestoreProperty]
        public string Email { get; set; }
        [FirestoreProperty]
        public string FirstName { get; set; }
        [FirestoreProperty]
        public string LastName { get; set; }

    }

    [FirestoreData]
    internal class ItemData
    {
        [FirestoreProperty]
        public string Name { get; set; }

        [FirestoreProperty]
        public string Price { get; set; }

        [FirestoreProperty]
        public string ImageUrl { get; set; }
        
        [FirestoreProperty]
        public int Stocks { get; set; }
    }
}
