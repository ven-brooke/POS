namespace POS
{
    partial class Registration
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.Rectangle1 = new System.Windows.Forms.PictureBox();
            this.WelcometoPOSimals = new System.Windows.Forms.PictureBox();
            this.PoweredBy = new System.Windows.Forms.PictureBox();
            this.CreateAccount = new System.Windows.Forms.Label();
            this.FirstName = new POS.RoundTextbox();
            this.LastName = new POS.RoundTextbox();
            this.Username = new POS.RoundTextbox();
            this.EmailAddress = new POS.RoundTextbox();
            this.SetPassword = new POS.RoundTextbox();
            this.ConfirmPassword = new POS.RoundTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.roundedButton1 = new POS.RoundedButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Rectangle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WelcometoPOSimals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PoweredBy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Rectangle1
            // 
            this.Rectangle1.Image = ((System.Drawing.Image)(resources.GetObject("Rectangle1.Image")));
            this.Rectangle1.Location = new System.Drawing.Point(351, 0);
            this.Rectangle1.Name = "Rectangle1";
            this.Rectangle1.Size = new System.Drawing.Size(397, 514);
            this.Rectangle1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Rectangle1.TabIndex = 1;
            this.Rectangle1.TabStop = false;
            // 
            // WelcometoPOSimals
            // 
            this.WelcometoPOSimals.Image = ((System.Drawing.Image)(resources.GetObject("WelcometoPOSimals.Image")));
            this.WelcometoPOSimals.Location = new System.Drawing.Point(32, 64);
            this.WelcometoPOSimals.Name = "WelcometoPOSimals";
            this.WelcometoPOSimals.Size = new System.Drawing.Size(313, 342);
            this.WelcometoPOSimals.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.WelcometoPOSimals.TabIndex = 0;
            this.WelcometoPOSimals.TabStop = false;
            // 
            // PoweredBy
            // 
            this.PoweredBy.Image = ((System.Drawing.Image)(resources.GetObject("PoweredBy.Image")));
            this.PoweredBy.Location = new System.Drawing.Point(113, 460);
            this.PoweredBy.Name = "PoweredBy";
            this.PoweredBy.Size = new System.Drawing.Size(149, 10);
            this.PoweredBy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PoweredBy.TabIndex = 2;
            this.PoweredBy.TabStop = false;
            // 
            // CreateAccount
            // 
            this.CreateAccount.BackColor = System.Drawing.Color.LightSkyBlue;
            this.CreateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateAccount.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CreateAccount.ForeColor = System.Drawing.Color.Transparent;
            this.CreateAccount.Location = new System.Drawing.Point(385, 49);
            this.CreateAccount.Name = "CreateAccount";
            this.CreateAccount.Size = new System.Drawing.Size(323, 61);
            this.CreateAccount.TabIndex = 3;
            this.CreateAccount.Text = "Create Account";
            this.CreateAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FirstName
            // 
            this.FirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FirstName.Location = new System.Drawing.Point(404, 168);
            this.FirstName.Name = "FirstName";
            this.FirstName.PlaceholderText = "Enter first name";
            this.FirstName.Size = new System.Drawing.Size(120, 23);
            this.FirstName.TabIndex = 5;
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(566, 168);
            this.LastName.Name = "LastName";
            this.LastName.PlaceholderText = "Enter last name";
            this.LastName.Size = new System.Drawing.Size(120, 23);
            this.LastName.TabIndex = 6;
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(566, 221);
            this.Username.Name = "Username";
            this.Username.PlaceholderText = "Enter username";
            this.Username.Size = new System.Drawing.Size(120, 23);
            this.Username.TabIndex = 7;
            // 
            // EmailAddress
            // 
            this.EmailAddress.Location = new System.Drawing.Point(404, 221);
            this.EmailAddress.Name = "EmailAddress";
            this.EmailAddress.PlaceholderText = "Enter email address";
            this.EmailAddress.Size = new System.Drawing.Size(120, 23);
            this.EmailAddress.TabIndex = 7;
            // 
            // SetPassword
            // 
            this.SetPassword.Location = new System.Drawing.Point(404, 278);
            this.SetPassword.Name = "SetPassword";
            this.SetPassword.PlaceholderText = "Set password";
            this.SetPassword.Size = new System.Drawing.Size(120, 23);
            this.SetPassword.TabIndex = 8;
            // 
            // ConfirmPassword
            // 
            this.ConfirmPassword.Location = new System.Drawing.Point(566, 278);
            this.ConfirmPassword.Name = "ConfirmPassword";
            this.ConfirmPassword.PlaceholderText = "Confirm password";
            this.ConfirmPassword.Size = new System.Drawing.Size(120, 23);
            this.ConfirmPassword.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(405, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(566, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(405, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Email Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(566, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Username";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(405, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(566, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Confirm password";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.checkBox1.Location = new System.Drawing.Point(404, 321);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(231, 16);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "I agree to the Terms and Conditions of POSimals";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(404, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Already have an account?";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.LinkColor = System.Drawing.Color.SteelBlue;
            this.linkLabel1.Location = new System.Drawing.Point(550, 340);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(43, 13);
            this.linkLabel1.TabIndex = 18;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Sign in";
            this.linkLabel1.Click += new System.EventHandler(this.linkLabel1_Click);
            // 
            // roundedButton1
            // 
            this.roundedButton1.BackColor = System.Drawing.Color.White;
            this.roundedButton1.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.roundedButton1.FlatAppearance.BorderSize = 0;
            this.roundedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.roundedButton1.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.roundedButton1.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.roundedButton1.Location = new System.Drawing.Point(445, 417);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Size = new System.Drawing.Size(194, 39);
            this.roundedButton1.TabIndex = 20;
            this.roundedButton1.Text = "Submit";
            this.roundedButton1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(474, 387);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(732, 505);
            this.Controls.Add(this.roundedButton1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConfirmPassword);
            this.Controls.Add(this.SetPassword);
            this.Controls.Add(this.EmailAddress);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.CreateAccount);
            this.Controls.Add(this.PoweredBy);
            this.Controls.Add(this.Rectangle1);
            this.Controls.Add(this.WelcometoPOSimals);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.Rectangle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WelcometoPOSimals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PoweredBy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox Rectangle1;
        private PictureBox WelcometoPOSimals;
        private PictureBox PoweredBy;
        private Label CreateAccount;
        private RoundTextbox FirstName;
        private RoundTextbox LastName;
        private RoundTextbox Username;
        private RoundTextbox EmailAddress;
        private RoundTextbox SetPassword;
        private RoundTextbox ConfirmPassword;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private CheckBox checkBox1;
        private Label label7;
        private LinkLabel linkLabel1;
        private RoundedButton roundedButton1;
        private PictureBox pictureBox1;
    }
}