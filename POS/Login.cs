using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using Google.Cloud.Firestore;

namespace POS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent(); this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        //Form with rounded corners
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        private async void submitButton_Click(object sender, EventArgs e)
        {
            string username = usernameInput.Text.Trim();
            string password = passwordInput.Text.Trim();

            var db = FirestoreHelper.Database;
            DocumentReference docRef = db.Collection("UserData").Document(username);
            UserData data = docRef.GetSnapshotAsync().Result.ConvertTo<UserData>();

            if (data != null)
            {
                if (password == data.Password)
                {
                    MessageBox.Show("Login Success");
                    Hide();
                    // Proceed to another form (ex: Sales form)
                    Sales sales = new Sales(username);
                    sales.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show("Login Failed: Invalid username or password.");
                }
            }
            else
            {
                MessageBox.Show("Login Failed: User does not exist.");
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            this.Hide();
            registration.Show();
        }
    }
}
