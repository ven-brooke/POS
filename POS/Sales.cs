﻿using Google.Cloud.Firestore;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class Sales : Form
    {
        private string _currentUsername;
        private int pictureCount = 0;
        public Sales(string currentUsername)
        {
            InitializeComponent();
            _currentUsername = currentUsername;
        }
        bool expand = false;

        private async void Sales_Load(object sender, EventArgs e)
        {
            try
            {
                var db = FirestoreHelper.Database;
                DocumentReference userDocRef = db.Collection("UserData").Document(_currentUsername);
                CollectionReference itemsCollection = userDocRef.Collection("Items");

                DocumentSnapshot userSnapshot = await userDocRef.GetSnapshotAsync();
                if (userSnapshot.Exists)
                {
                    string userName = userSnapshot.GetValue<string>("FirstName");

                    // Set the user's name to the label
                    accName.Text = $"{userName}";
                }

                var querySnapshot = await itemsCollection.GetSnapshotAsync();
                foreach (var document in querySnapshot.Documents)
                {
                    string itemName = document.GetValue<string>("Name");
                    productName_comboBox.Items.Add(itemName);
                    string itemPrice = document.GetValue<string>("Price");
                    string imageUrl = document.GetValue<string>("ImageUrl");

                    await AddSalesToUI(itemName, itemPrice, imageUrl);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading items: {ex.Message}");
            }
        }

        public async Task AddSalesToUI(string nameTextBox, string priceTextBox, string imageUrl)
        {
            int pictureBoxWidth = 100; // Width of each PictureBox
            int pictureBoxMargin = 1; // Margin around each PictureBox

            int availableWidth = flowLayoutPanel1.ClientSize.Width; // Available width in the FlowLayoutPanel
            int totalMargin = pictureBoxMargin * 2; // Total margin (both sides)

            int numberOfColumns = (availableWidth - totalMargin) / (pictureBoxWidth + pictureBoxMargin);

            PictureBox pictureBox = new PictureBox();
            pictureBox.Width = pictureBoxWidth;
            pictureBox.Height = 100;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.BackColor = Color.Black; // Set the background color to white (blank)
            pictureBox.BorderStyle = BorderStyle.FixedSingle; // Optional: Add a border to visualize the PictureBox

            Label upperLabel = new Label();
            upperLabel.Text = "" + nameTextBox;
            upperLabel.TextAlign = ContentAlignment.MiddleCenter;
            upperLabel.AutoSize = false;
            upperLabel.Width = pictureBoxWidth; // Match label width to PictureBox width
            upperLabel.Height = 20;// Set label height
            upperLabel.Location = new Point(0, 105);
            upperLabel.ForeColor = Color.SteelBlue;
            upperLabel.Font = new Font(upperLabel.Font, FontStyle.Bold);

            Label lowerLabel = new Label();
            lowerLabel.Text = "P" + priceTextBox;
            lowerLabel.TextAlign = ContentAlignment.MiddleCenter;
            lowerLabel.AutoSize = false;
            lowerLabel.Width = pictureBoxWidth; // Match label width to PictureBox width
            lowerLabel.Height = 20; // Set label height
            lowerLabel.Location = new Point(0, 125); // Position label below the upper label
            lowerLabel.ForeColor = Color.SteelBlue;
            lowerLabel.Font = new Font(lowerLabel.Font, FontStyle.Bold);

            // Adjust the margin and padding of the PictureBox for spacing
            pictureBox.Margin = new Padding(pictureBoxMargin); // Add margin to create spacing

            // Create a Panel to hold the PictureBox and Labels
            Panel itemPanel = new Panel();
            itemPanel.AutoSize = true;
            itemPanel.Controls.Add(pictureBox);
            itemPanel.Controls.Add(upperLabel);
            itemPanel.Controls.Add(lowerLabel);


            // Add the panel to the main FlowLayoutPanel (flowLayoutPanel1)
            flowLayoutPanel1.Controls.Add(itemPanel);

            pictureCount++;

            if (pictureCount % numberOfColumns == 0)
            {
                flowLayoutPanel1.SetFlowBreak(itemPanel, true); // Start a new row after reaching the calculated number of columns
            }

            // Load the image asynchronously and set it to the PictureBox
            try
            {
                Image image = await LoadImageAsync(imageUrl);
                if (image != null)
                {
                    pictureBox.Image = image;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load image: {ex.Message}");
                // Log the exception details or handle it accordingly
            }
        }

        private readonly Dictionary<string, Image> _imageCache = new Dictionary<string, Image>();

        private async Task<Image> LoadImageAsync(string imageUrl)
        {
            if (_imageCache.ContainsKey(imageUrl))
            {
                return _imageCache[imageUrl];
            }

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    byte[] data = await client.GetByteArrayAsync(imageUrl);
                    using (var stream = new MemoryStream(data))
                    {
                        Image image = Image.FromStream(stream);
                        _imageCache.Add(imageUrl, image);
                        return image;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to load image: {ex.Message}");
                return null;
            }
        }

        private void AddToCart(string itemName, string itemPrice, int quantity)
        {
            // Add a new row to the DataGridView
            dataGridView1.Rows.Add(itemName, itemPrice, quantity);
        }

        //minor features
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (expand == false)
            {
                menuDrop.Height += 210;
                if (menuDrop.Height >= menuDrop.MaximumSize.Height)
                {
                    timer1.Stop();
                    expand = true;
                }
            }
            else
            {
                menuDrop.Height -= 210;
                if (menuDrop.Height <= menuDrop.MinimumSize.Height)
                {
                    timer1.Stop();
                    expand = false;
                }
            }
        }
        private void menuButton_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void manageButton_Click(object sender, EventArgs e)
        {
            Manage_Items manageForm = new Manage_Items(_currentUsername);
            this.Hide();
            manageForm.Show();
        }

        private async void addToCart_Click(object sender, EventArgs e)
        {
            string selectedProductName = productName_comboBox.SelectedItem as string;
            if (string.IsNullOrEmpty(selectedProductName))
            {
                MessageBox.Show("Please select a product.");
                return;
            }

            string quantityText = quantity_textBox.Text;
            if (!int.TryParse(quantityText, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity.");
                return;
            }

            try
            {
                var db = FirestoreHelper.Database;
                DocumentReference userDocRef = db.Collection("UserData").Document(_currentUsername);
                CollectionReference itemsCollection = userDocRef.Collection("Items");

                // Query the Firestore database to get details for the selected product
                Query query = itemsCollection.WhereEqualTo("Name", selectedProductName);
                QuerySnapshot querySnapshot = await query.GetSnapshotAsync();

                foreach (DocumentSnapshot document in querySnapshot.Documents)
                {
                    string itemName = document.GetValue<string>("Name");
                    string itemPrice = document.GetValue<string>("Price");
                    string imageUrl = document.GetValue<string>("ImageUrl");
                    int currentStock = document.GetValue<int>("Stocks"); // Retrieve current stock count

                    // Check if requested quantity exceeds available stock count
                    if (quantity > currentStock)
                    {
                        MessageBox.Show($"Insufficient stock for {selectedProductName}. Available stock: {currentStock}");
                        return;
                    }

                    // Calculate the total price based on quantity
                    decimal totalPrice = decimal.Parse(itemPrice) * quantity;

                    // Update the stock count in Firestore
                    await document.Reference.UpdateAsync("Stocks", currentStock - quantity);

                    // Add the selected product to the DataGridView
                    dataGridView1.Rows.Add(itemName, itemPrice, quantity, totalPrice, imageUrl);

                    foreach (DataGridViewColumn column in dataGridView1.Columns)
                    {
                        column.DefaultCellStyle.ForeColor = Color.Black;
                    }
                }

                if (querySnapshot.Documents.Count == 0)
                {
                    MessageBox.Show("Selected product not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding to cart: {ex.Message}");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void GenerateReceipt()
        {
            StringBuilder receiptContent = new StringBuilder();

            // Add header information to the receipt
            receiptContent.AppendLine("************ Receipt ************");
            receiptContent.AppendLine($"Date: {DateTime.Now}");
            receiptContent.AppendLine("*********************************");
            receiptContent.AppendLine();

            // Add items from the DataGridView to the receipt
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Check if the cell value is not null before accessing its ToString method
                string itemName = row.Cells[0].Value != null ? row.Cells[0].Value.ToString() : string.Empty;
                string itemPrice = row.Cells[1].Value != null ? row.Cells[1].Value.ToString() : string.Empty;
                string quantity = row.Cells[2].Value != null ? row.Cells[2].Value.ToString() : string.Empty;
                string totalPrice = row.Cells[3].Value != null ? row.Cells[3].Value.ToString() : string.Empty;

                receiptContent.AppendLine($"{itemName} - {itemPrice} x {quantity} = {totalPrice}");
            }

            // Add footer information to the receipt
            receiptContent.AppendLine();
            receiptContent.AppendLine("*********************************");
            receiptContent.AppendLine("Thank you for shopping with us!");
            receiptContent.AppendLine("*********************************");

            // Display the receipt or save it to a file, or print it, etc.
            MessageBox.Show(receiptContent.ToString(), "Receipt", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void payButton_Click(object sender, EventArgs e)
        {
            // Check if the DataGridView contains items
            bool hasItems = dataGridView1.Rows.Cast<DataGridViewRow>().Any(row =>
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && !string.IsNullOrEmpty(cell.Value.ToString()))
                    {
                        return true; // Found a non-empty cell, so the row contains data
                    }
                }
                return false; // All cells in the row are empty
            });

            if (!hasItems)
            {
                MessageBox.Show("There are no items in the cart.", "Empty Cart", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the method without generating a receipt
            }

            // Generate and present the receipt
            GenerateReceipt();

            // Store the receipt in Firestore
            await StoreReceiptInFirestore();
        }

        private async Task StoreReceiptInFirestore()
        {
            try
            {
                var db = FirestoreHelper.Database;
                DocumentReference userDocRef = db.Collection("UserData").Document(_currentUsername);
                CollectionReference receiptsCollection = userDocRef.Collection("Receipts");

                // Create a new document with receipt details
                var receiptDocument = new Dictionary<string, object>
                {
                    { "Items", GetReceiptItems() }, // Use a helper method to get receipt items
                    // Add more fields as needed
                };

                // Add the document to the Receipts collection
                await receiptsCollection.AddAsync(receiptDocument);

                MessageBox.Show("Receipt stored in Firestore.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error storing receipt in Firestore: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<Dictionary<string, object>> GetReceiptItems()
        {
            List<Dictionary<string, object>> receiptItems = new List<Dictionary<string, object>>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string itemName = row.Cells[0].Value != null ? row.Cells[0].Value.ToString() : string.Empty;
                string itemPrice = row.Cells[1].Value != null ? row.Cells[1].Value.ToString() : string.Empty;
                string quantity = row.Cells[2].Value != null ? row.Cells[2].Value.ToString() : string.Empty;
                string totalPrice = row.Cells[3].Value != null ? row.Cells[3].Value.ToString() : string.Empty;

                // Create a dictionary for each item
                var itemDetails = new Dictionary<string, object>
                {
                    { "Name", itemName },
                    { "Price", itemPrice },
                    { "Quantity", quantity },
                    { "TotalPrice", totalPrice },
                    // Add more fields as needed
                };                                                                          

                receiptItems.Add(itemDetails);
            }

            return receiptItems;
        }

        private void receiptButton_Click(object sender, EventArgs e)
        {
            Receipt receiptForm = new Receipt(_currentUsername); // Pass any necessary parameters to the ReceiptForm constructor
            receiptForm.Show();

            this.Hide();
        }
    }

    //for rounded panels
    class RoundedPanel : Panel
    {
        GraphicsPath GetRoundPath(RectangleF rect, int radius)
        {
            float r2 = radius / 2f;
            GraphicsPath graphPath = new GraphicsPath();
            graphPath.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            graphPath.AddLine(rect.X + r2, rect.Y, rect.Width - r2, rect.Y);
            graphPath.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
            graphPath.AddLine(rect.Width, rect.Y + r2, rect.Width, rect.Height - r2);
            graphPath.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
            graphPath.AddLine(rect.Width - r2, rect.Height, rect.X + r2, rect.Height);
            graphPath.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
            graphPath.AddLine(rect.X, rect.Height - r2, rect.X, rect.Y + r2);
            graphPath.CloseFigure();
            return graphPath;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            RectangleF rect = new RectangleF(0, 0, this.Width, this.Height);
            using (GraphicsPath graphPath = GetRoundPath(rect, 20)) // You can adjust the radius here
            {
                this.Region = new Region(graphPath);
                using (SolidBrush brush = new SolidBrush(this.BackColor))
                {
                    e.Graphics.FillPath(brush, graphPath);
                }
                using (Pen pen = new Pen(Color.Black, 1.75f))
                {
                    e.Graphics.DrawPath(pen, graphPath);
                }
            }
        }
    }
}
