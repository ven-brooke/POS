using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Google.Cloud.Firestore;
using Google.Cloud.Storage.V1;
using System.Net;

namespace POS
{
    public partial class Manage_Items : Form
    {
        private int pictureCount = 0;
        private string _currentUsername;
        public Manage_Items(string currentUsername)
        {
            InitializeComponent();
            _currentUsername = currentUsername;
        }
        bool expand = false;

        private void timer1_Tick(object sender, EventArgs e)
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

        private void receiptButton_Click(object sender, EventArgs e)
        {

        }

        private void cartButton_Click(object sender, EventArgs e)
        {
            Sales salesForm = new Sales(_currentUsername);
            this.Hide();
            salesForm.Show();
        }

        //Backend
        private void addButton_Click(object sender, EventArgs e)
        {
            AddItems form = new AddItems(_currentUsername);
            form.SetManage_ItemsInstance(this); // Pass the current instance of manageItemsForm
            form.ShowDialog();
        }

        private async void Manage_Items_Load(object sender, EventArgs e)
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
                    string itemPrice = document.GetValue<string>("Price");
                    string imageUrl = document.GetValue<string>("ImageUrl");

                    await AddItemsToUI(itemName, itemPrice, imageUrl); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading items: {ex.Message}");
            }
        }

        public async Task AddItemsToUI(string nameTextBox, string priceTextBox, string imageUrl)
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

        private void removeItemLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RemoveItem form = new RemoveItem(this, _currentUsername); // Pass the current instance of manageItemsForm
            form.SetManage_ItemsInstance(this);
            form.ShowDialog();
        }

        public void RemoveItemFromUI(string itemName)
        {
            foreach (Panel itemPanel in flowLayoutPanel1.Controls.OfType<Panel>())
            {
                Label upperLabel = itemPanel.Controls.OfType<Label>().FirstOrDefault(l => l.Text == itemName);
                if (upperLabel != null)
                {
                    flowLayoutPanel1.Controls.Remove(itemPanel);
                    itemPanel.Dispose();
                    break;
                }
            }
        }

        private void manageButton_Click(object sender, EventArgs e)
        {

        }
    }
}
