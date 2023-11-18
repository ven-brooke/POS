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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace POS
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
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
        private void Registration_Load(object sender, EventArgs e)
        {
            InitializeComponent();
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!termsCheckbox.Checked)
                {
                    MessageBox.Show("Please accept the terms and conditions before submitting.");
                    return;
                }
                var db = FirestoreHelper.Database;
                if (CheckIfUserExists())
                {
                    MessageBox.Show("User already exists!");
                    return;
                }

                var data = GetWriteData();
                DocumentReference docRef = db.Collection("UserData").Document(data.Username);
                docRef.SetAsync(data);
                MessageBox.Show("Success!");

                Login login = new Login();
                this.Hide();
                login.Show();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred in submitButton_Click: {ex.Message}");
                MessageBox.Show("An error occurred. Please try again");
            }
        }
        private UserData GetWriteData()
        {
            string firstName = FirstName_input.Text.Trim();
            string lastName = LastName_input.Text.Trim();
            string email = EmailAddress_input.Text.Trim();
            string username = Username_input.Text.Trim();
            string password = SetPassword_input.Text.Trim();

            return new UserData()
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                Username = username,
                Password = password
            };
        }
        private bool CheckIfUserExists()
        {
            try
            {
                string username = Username_input.Text.Trim();

                var db = FirestoreHelper.Database;
                DocumentReference docRef = db.Collection("UserData").Document(username);
                UserData data = docRef.GetSnapshotAsync().Result.ConvertTo<UserData>();

                if (data != null)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred in CheckIfUserExists: {ex.Message}");
                return false; // or throw the exception if you want to propagate it
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

    //Code rani para sa round rectangles
    class RoundTextbox : TextBox
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
        int nLeftRect,      // x-coordinate of upper-left corner
        int nTopRect,       // y-coordinate of upper-left corner
        int nRightRect,     // x-coordinate of lower-right corner
        int nBottomRect,    // y-coordinate of lower-right corner
        int nheightRect,    // height of ellipse 
        int nweightRect     // width of ellipse
        );
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(1, 1, this.Width, this.Height, 10, 10)); //play with these values till you are happy
        }
    }
    class RoundedButton : Button
    {
        GraphicsPath GetRoundPath(RectangleF Rect, int radius)
        {
            float r2 = radius / 2f;
            GraphicsPath GraphPath = new GraphicsPath();
            GraphPath.AddArc(Rect.X, Rect.Y, radius, radius, 180, 90);
            GraphPath.AddLine(Rect.X + r2, Rect.Y, Rect.Width - r2, Rect.Y);
            GraphPath.AddArc(Rect.X + Rect.Width - radius, Rect.Y, radius, radius, 270, 90);
            GraphPath.AddLine(Rect.Width, Rect.Y + r2, Rect.Width, Rect.Height - r2);
            GraphPath.AddArc(Rect.X + Rect.Width - radius,
                             Rect.Y + Rect.Height - radius, radius, radius, 0, 90);
            GraphPath.AddLine(Rect.Width - r2, Rect.Height, Rect.X + r2, Rect.Height);
            GraphPath.AddArc(Rect.X, Rect.Y + Rect.Height - radius, radius, radius, 90, 90);
            GraphPath.AddLine(Rect.X, Rect.Height - r2, Rect.X, Rect.Y + r2);
            GraphPath.CloseFigure();
            return GraphPath;        
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            RectangleF Rect = new RectangleF(0, 0, this.Width, this.Height);
            using (GraphicsPath GraphPath = GetRoundPath(Rect, 50))
            {
                this.Region = new Region(GraphPath);
                using (Pen pen = new Pen(Color.CadetBlue, 1.75f))
                {
                    pen.Alignment = PenAlignment.Inset;
                    e.Graphics.DrawPath(pen, GraphPath);
                }
            }
        }       
    }    
}