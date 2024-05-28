using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using System.Windows.Forms;
using Google.Cloud.Firestore;
using Google.Cloud.Storage.V1;
using System.Net;
using System.Diagnostics;
namespace POS
{

    public partial class AddItems : Form
    {
        private Manage_Items? _Manage_ItemsInstance;
        private string _currentUsername;
        public AddItems(string currentUsername)
        {
            InitializeComponent();
            _currentUsername = currentUsername;
        }
        public void SetManage_ItemsInstance(Manage_Items Manage_ItemsInstance)
        {
            _Manage_ItemsInstance = Manage_ItemsInstance;
        }

        private async void addItemsButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (_Manage_ItemsInstance != null && !string.IsNullOrEmpty(_currentUsername))
                {
                    string name = nameTextBox.Text;
                    string price = priceTextBox.Text;

                    if (string.IsNullOrEmpty(name))
                    {
                        MessageBox.Show("Name cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (string.IsNullOrEmpty(price))
                    {
                        MessageBox.Show("Price cannot be empty.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    int stocks;
                    if (!int.TryParse(stockTextBox.Text, out stocks))
                    {
                        MessageBox.Show("Invalid stock value.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string imageUrl = await UploadImage();

                    if (string.IsNullOrEmpty(imageUrl))
                    {
                        MessageBox.Show("Failed to upload the image.", "Image Upload Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var db = FirestoreHelper.Database;
                    DocumentReference userDocRef = db.Collection("UserData").Document(_currentUsername);
                    CollectionReference itemsCollection = userDocRef.Collection("Items");

                    ItemData item = new ItemData
                    {
                        Name = name,
                        Price = price,
                        ImageUrl = imageUrl,
                        Stocks = stocks
                    };

                    await itemsCollection.AddAsync(item);

                    _Manage_ItemsInstance?.AddItemsToUI(name, price, imageUrl, stocks);

                    MessageBox.Show("Item added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Validate if the loaded file is a valid image
        private bool ImageIsValid(string imagePath)
        {
            try
            {
                using (Image img = Image.FromFile(imagePath))
                {
                    return img.RawFormat.Guid == ImageFormat.MemoryBmp.Guid ||
                           img.RawFormat.Guid == ImageFormat.Bmp.Guid ||
                           img.RawFormat.Guid == ImageFormat.Jpeg.Guid ||
                           img.RawFormat.Guid == ImageFormat.Gif.Guid ||
                           img.RawFormat.Guid == ImageFormat.Png.Guid;
                }
            }
            catch
            {
                return false;
            }
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.BMP;*.JPG;*.GIF;*.PNG;*.JPEG)|*.BMP;*.JPG;*.GIF;*.PNG;*.JPEG|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                try
                {
                    if (ImageIsValid(imagePath))
                    {
                        pictureBox.Image = Image.FromFile(imagePath);
                        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox.Size = new Size(100, 100);
                    }
                    else
                    {
                        MessageBox.Show("Please select a valid image file.", "Invalid File", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private async Task<string> UploadImage()
        {
            if (pictureBox.Image != null)
            {
                try
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        // Get the image format from the loaded image
                        ImageFormat format = pictureBox.Image.RawFormat;

                        // Check for known unsupported image formats
                        if (format.Guid == ImageFormat.MemoryBmp.Guid ||
                            format.Guid == ImageFormat.Emf.Guid ||
                            format.Guid == ImageFormat.Wmf.Guid)
                        {
                            MessageBox.Show("Unsupported image format. Please select a different image.");
                            return string.Empty;
                        }

                        // Save the image in its original format
                        pictureBox.Image.Save(ms, format);

                        byte[] imageBytes = ms.ToArray();

                        string projectId = "test-76d3d";
                        string bucketName = $"{projectId}.appspot.com";
                        string objectName = $"images/{Guid.NewGuid()}";

                        var storage = StorageClient.Create();
                        await storage.UploadObjectAsync(bucketName, objectName, null, new MemoryStream(imageBytes));
                        
                        return $"https://storage.googleapis.com/{bucketName}/{objectName}";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error uploading image: {ex.Message}");
                    return string.Empty;
                }
            }
            else
            {
                MessageBox.Show("Please select an image before uploading.");
                return string.Empty;
            }
        }
    }
}
