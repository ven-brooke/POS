using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Cloud.Firestore;
using Google.Cloud.Storage.V1;
using System.Net;
using System.Diagnostics;

namespace POS
{
    public partial class RemoveItem : Form
    {
        private Manage_Items? _Manage_ItemsInstance;
        private string _currentUsername;
        public RemoveItem(Manage_Items Manage_ItemsInstance, string currentUsername)
        {
            InitializeComponent();
            _Manage_ItemsInstance = Manage_ItemsInstance;
            _currentUsername = currentUsername;
        }
        public void SetManage_ItemsInstance(Manage_Items Manage_ItemsInstance)
        {
            _Manage_ItemsInstance = Manage_ItemsInstance;
        }

        private async void removeButton_Click(object sender, EventArgs e)
        {
            string itemName = nameTextBox.Text;

            if (string.IsNullOrEmpty(itemName))
            {
                MessageBox.Show("Please enter an item name.");
                return;
            }

            // Check if item exists in Firestore
            if (await ItemExistsInFirestore(itemName))
            {
                // Retrieve item data (including image URL) from Firestore
                ItemData item = await GetItemDataFromFirestore(itemName);

                // Delete item's image from Google Cloud Storage
                await DeleteImageFromStorage(item.ImageUrl);

                // Delete item from Firestore
                await DeleteItemFromFirestore(itemName);

                // Update UI in ManageItemsForm to remove the item
                _Manage_ItemsInstance.RemoveItemFromUI(itemName);

                MessageBox.Show("Item removed successfully.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Item does not exist. Please try again.");
                // Optionally clear the nameTextBox or take other actions
            }
        }

        // Method to check if item exists in Firestore
        private async Task<bool> ItemExistsInFirestore(string itemName)
        {
            if (string.IsNullOrWhiteSpace(itemName))
            {
                // Optionally handle the case where itemName is null or empty
                return false;
            }

            try
            {
                var db = FirestoreHelper.Database;
                DocumentReference userDocRef = db.Collection("UserData").Document(_currentUsername);
                CollectionReference itemsCollection = userDocRef.Collection("Items");

                Query query = itemsCollection.WhereEqualTo("Name", itemName);

                QuerySnapshot querySnapshot = await query.GetSnapshotAsync();

                return querySnapshot.Count > 0;
            }
            catch (Exception ex)
            {
                // Handle any exceptions that might occur during Firestore query
                Console.WriteLine($"Error checking item existence: {ex.Message}");
                return false;
            }
        }

        // Method to get item data from Firestore
        private async Task<ItemData?> GetItemDataFromFirestore(string itemName)
        {
            try
            {
                var db = FirestoreHelper.Database;
                DocumentReference userDocRef = db.Collection("UserData").Document(_currentUsername);
                CollectionReference itemsCollection = userDocRef.Collection("Items");

                Query query = itemsCollection.WhereEqualTo("Name", itemName).Limit(1);

                QuerySnapshot querySnapshot = await query.GetSnapshotAsync();

                if (querySnapshot.Count > 0)
                {
                    DocumentSnapshot documentSnapshot = querySnapshot.Documents[0];

                    // Retrieve item data from the document
                    ItemData item = new ItemData
                    {
                        Name = documentSnapshot.GetValue<string>("Name"),
                        Price = documentSnapshot.GetValue<string>("Price"),
                        ImageUrl = documentSnapshot.GetValue<string>("ImageUrl")
                        // Add other fields if needed
                    };

                    return item;
                }
                else
                {
                    // Return null or handle the case where the item is not found
                    return null;
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that might occur during Firestore query
                Console.WriteLine($"Error retrieving item data: {ex.Message}");
                MessageBox.Show("An error occurred while retrieving item data. Please try again later.");
                return null;
            }
        }

        // Method to delete item from Firestore
        private async Task DeleteItemFromFirestore(string itemName)
        {
            try
            {
                var db = FirestoreHelper.Database;
                DocumentReference userDocRef = db.Collection("UserData").Document(_currentUsername);
                CollectionReference itemsCollection = userDocRef.Collection("Items");

                Query query = itemsCollection.WhereEqualTo("Name", itemName);

                QuerySnapshot querySnapshot = await query.GetSnapshotAsync();

                foreach (DocumentSnapshot documentSnapshot in querySnapshot.Documents)
                {
                    await documentSnapshot.Reference.DeleteAsync();
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that might occur during deletion
                Console.WriteLine($"Error deleting item: {ex.Message}");
                MessageBox.Show("An error occurred while deleting the item. Please try again later.");
            }
        }

        // Method to Check if item's image from Google Cloud Storage
        private async Task<bool> ImageExistsInStorage(string bucketName, string objectName)
        {
            try
            {
                var storage = StorageClient.Create();

                var storageObject = await storage.GetObjectAsync(bucketName, objectName);

                // If the object exists in the bucket, return true; otherwise, return false
                return storageObject != null;
            }
            catch (Google.GoogleApiException ex) // Handle Google API exceptions
            {
                Console.WriteLine($"Google API Exception: {ex.Message}");
                // Log or handle the exception accordingly
                return false; // For simplicity, returning false on exception
            }
            catch (Exception ex) // Handle other exceptions
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
                // Log or handle the exception accordingly
                return false; // For simplicity, returning false on exception
            }
        }

        // Method to delete item's image from Google Cloud Storage
        private async Task DeleteImageFromStorage(string imageUrl)
        {
            try
            {
                Uri uri = new Uri(imageUrl);
                string bucketName = uri.Host;
                string objectName = uri.AbsolutePath.TrimStart('/');

                // Log the bucketName and objectName to ensure they're correct
                Debug.WriteLine($"Bucket Name: {bucketName}, Object Name: {objectName}");

                if (await ImageExistsInStorage(bucketName, objectName))
                {
                    var storage = StorageClient.Create();
                    await storage.DeleteObjectAsync(bucketName, objectName);
                    Debug.WriteLine("Image deleted from storage successfully.");
                }
                else
                {
                    Debug.WriteLine("Image object not found. Deletion failed.");
                    // Handle the case where the image object to delete is not found
                }
            }
            catch (Google.GoogleApiException ex)
            {
                Debug.WriteLine($"Failed to delete image: {ex.Message}");
                MessageBox.Show("An error occurred while deleting the image from storage. Please try again later.");
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"An unexpected error occurred: {ex.Message}");
                MessageBox.Show("An unexpected error occurred while deleting the image from storage. Please try again later.");
            }

        }
    }
}
