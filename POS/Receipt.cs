using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class Receipt : Form
    {
        private string _currentUsername;

        public Receipt(string currentUsername)
        {
            InitializeComponent();
            _currentUsername = currentUsername;
        }

        private async void Receipt_Load(object sender, EventArgs e)
        {
            await DisplayReceiptsInDataGridView();
        }

        private async Task DisplayReceiptsInDataGridView()
        {
            try
            {
                var db = FirestoreHelper.Database;
                DocumentReference userDocRef = db.Collection("UserData").Document(_currentUsername);
                CollectionReference receiptsCollection = userDocRef.Collection("Receipts");

                // Fetch all documents from the Receipts collection
                var querySnapshot = await receiptsCollection.GetSnapshotAsync();

                // Clear existing rows and columns in the DataGridView
                dataGridView1.Rows.Clear();
                dataGridView1.Columns.Clear();

                dataGridView1.Columns.Add("ItemName", "Item Name");
                dataGridView1.Columns.Add("ItemPrice", "Item Price");
                dataGridView1.Columns.Add("ItemQuantity", "Item Quantity");
                dataGridView1.Columns.Add("TotalPrice", "Total Price");

                // Loop through each document and add its data to the DataGridView
                foreach (var document in querySnapshot.Documents)
                {
                    List<Dictionary<string, object>> items = document.GetValue<List<Dictionary<string, object>>>("Items");

                    // Add a new row for each item
                    foreach (var item in items)
                    {
                        string itemName = item["Name"].ToString();
                        string itemPrice = item["Price"].ToString();
                        string itemQuantity = item["Quantity"].ToString();
                        string totalPrice = item["TotalPrice"].ToString(); // Replace with the actual field name in your document

                        // Add a new row to the DataGridView
                        dataGridView1.Rows.Add(itemName, itemPrice, itemQuantity, totalPrice);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error displaying receipts: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetItemsAsString(List<Dictionary<string, object>> items)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in items)
            {
                string itemName = item["Name"].ToString();
                string itemPrice = item["Price"].ToString();
                string itemQuantity = item["Quantity"].ToString();

                sb.AppendLine($"Item: {itemName}, Price: {itemPrice}, Quantity: {itemQuantity}");
            }

            return sb.ToString();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Sales salesForm = new Sales(_currentUsername);
            this.Hide();
            salesForm.Show();
        }
    }
}
