namespace POS
{
    partial class Manage_Items
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manage_Items));
            this.editQty_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuDrop = new POS.RoundedPanel();
            this.settingsButton = new System.Windows.Forms.PictureBox();
            this.manageButton = new System.Windows.Forms.PictureBox();
            this.receiptButton = new System.Windows.Forms.PictureBox();
            this.accName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.roundedPanel2 = new POS.RoundedPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.dropdownButton = new System.Windows.Forms.PictureBox();
            this.profilePicture = new System.Windows.Forms.PictureBox();
            this.cartButton = new System.Windows.Forms.PictureBox();
            this.menuButton = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.roundTextbox1 = new POS.RoundTextbox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.allProducts_link = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.addButton = new POS.RoundedButton();
            this.removeItemLabel = new System.Windows.Forms.LinkLabel();
            this.menuDrop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manageButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.roundedPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dropdownButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // editQty_label
            // 
            this.editQty_label.AutoSize = true;
            this.editQty_label.Font = new System.Drawing.Font("Segoe UI", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.editQty_label.ForeColor = System.Drawing.Color.Red;
            this.editQty_label.Location = new System.Drawing.Point(159, 14);
            this.editQty_label.Name = "editQty_label";
            this.editQty_label.Size = new System.Drawing.Size(27, 13);
            this.editQty_label.TabIndex = 19;
            this.editQty_label.Text = "Edit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(79, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 18;
            // 
            // menuDrop
            // 
            this.menuDrop.Controls.Add(this.settingsButton);
            this.menuDrop.Controls.Add(this.manageButton);
            this.menuDrop.Controls.Add(this.receiptButton);
            this.menuDrop.Controls.Add(this.accName);
            this.menuDrop.Controls.Add(this.pictureBox1);
            this.menuDrop.Location = new System.Drawing.Point(18, 73);
            this.menuDrop.Name = "menuDrop";
            this.menuDrop.Size = new System.Drawing.Size(140, 10);
            this.menuDrop.TabIndex = 27;
            // 
            // settingsButton
            // 
            this.settingsButton.Image = ((System.Drawing.Image)(resources.GetObject("settingsButton.Image")));
            this.settingsButton.Location = new System.Drawing.Point(0, 139);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(140, 35);
            this.settingsButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.settingsButton.TabIndex = 26;
            this.settingsButton.TabStop = false;
            // 
            // manageButton
            // 
            this.manageButton.Image = ((System.Drawing.Image)(resources.GetObject("manageButton.Image")));
            this.manageButton.Location = new System.Drawing.Point(0, 98);
            this.manageButton.Name = "manageButton";
            this.manageButton.Size = new System.Drawing.Size(140, 35);
            this.manageButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.manageButton.TabIndex = 25;
            this.manageButton.TabStop = false;
            // 
            // receiptButton
            // 
            this.receiptButton.Image = ((System.Drawing.Image)(resources.GetObject("receiptButton.Image")));
            this.receiptButton.Location = new System.Drawing.Point(0, 57);
            this.receiptButton.Name = "receiptButton";
            this.receiptButton.Size = new System.Drawing.Size(140, 35);
            this.receiptButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.receiptButton.TabIndex = 23;
            this.receiptButton.TabStop = false;
            this.receiptButton.Click += new System.EventHandler(this.receiptButton_Click);
            // 
            // accName
            // 
            this.accName.AutoSize = true;
            this.accName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.accName.ForeColor = System.Drawing.Color.SteelBlue;
            this.accName.Location = new System.Drawing.Point(63, 13);
            this.accName.Name = "accName";
            this.accName.Size = new System.Drawing.Size(46, 13);
            this.accName.TabIndex = 21;
            this.accName.Text = "(Name)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(15, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Product";
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.BackColor = System.Drawing.Color.White;
            this.roundedPanel2.Controls.Add(this.editQty_label);
            this.roundedPanel2.Controls.Add(this.label3);
            this.roundedPanel2.Controls.Add(this.label2);
            this.roundedPanel2.Location = new System.Drawing.Point(504, 117);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.Size = new System.Drawing.Size(196, 315);
            this.roundedPanel2.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(23, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "My Products";
            // 
            // dropdownButton
            // 
            this.dropdownButton.Image = ((System.Drawing.Image)(resources.GetObject("dropdownButton.Image")));
            this.dropdownButton.Location = new System.Drawing.Point(675, 19);
            this.dropdownButton.Name = "dropdownButton";
            this.dropdownButton.Size = new System.Drawing.Size(29, 34);
            this.dropdownButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dropdownButton.TabIndex = 3;
            this.dropdownButton.TabStop = false;
            // 
            // profilePicture
            // 
            this.profilePicture.Image = ((System.Drawing.Image)(resources.GetObject("profilePicture.Image")));
            this.profilePicture.Location = new System.Drawing.Point(629, 9);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.Size = new System.Drawing.Size(40, 44);
            this.profilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profilePicture.TabIndex = 2;
            this.profilePicture.TabStop = false;
            // 
            // cartButton
            // 
            this.cartButton.Image = ((System.Drawing.Image)(resources.GetObject("cartButton.Image")));
            this.cartButton.Location = new System.Drawing.Point(564, 12);
            this.cartButton.Name = "cartButton";
            this.cartButton.Size = new System.Drawing.Size(31, 41);
            this.cartButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cartButton.TabIndex = 1;
            this.cartButton.TabStop = false;
            this.cartButton.Click += new System.EventHandler(this.cartButton_Click);
            // 
            // menuButton
            // 
            this.menuButton.Image = ((System.Drawing.Image)(resources.GetObject("menuButton.Image")));
            this.menuButton.Location = new System.Drawing.Point(45, 12);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(31, 41);
            this.menuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.menuButton.TabIndex = 0;
            this.menuButton.TabStop = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.dropdownButton);
            this.panel1.Controls.Add(this.profilePicture);
            this.panel1.Controls.Add(this.cartButton);
            this.panel1.Controls.Add(this.menuButton);
            this.panel1.Location = new System.Drawing.Point(-19, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(732, 67);
            this.panel1.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(578, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 15);
            this.label5.TabIndex = 28;
            this.label5.Text = "Categories";
            // 
            // roundTextbox1
            // 
            this.roundTextbox1.BackColor = System.Drawing.Color.Gainsboro;
            this.roundTextbox1.Location = new System.Drawing.Point(12, 98);
            this.roundTextbox1.Name = "roundTextbox1";
            this.roundTextbox1.PlaceholderText = "Search item";
            this.roundTextbox1.Size = new System.Drawing.Size(111, 23);
            this.roundTextbox1.TabIndex = 10;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(129, 100);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(19, 21);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // allProducts_link
            // 
            this.allProducts_link.AutoSize = true;
            this.allProducts_link.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.allProducts_link.ForeColor = System.Drawing.Color.SteelBlue;
            this.allProducts_link.Location = new System.Drawing.Point(155, 101);
            this.allProducts_link.Name = "allProducts_link";
            this.allProducts_link.Size = new System.Drawing.Size(73, 15);
            this.allProducts_link.TabIndex = 15;
            this.allProducts_link.Text = "All Products";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 117);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(447, 315);
            this.flowLayoutPanel1.TabIndex = 29;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.SkyBlue;
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(457, 389);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(46, 43);
            this.addButton.TabIndex = 30;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // removeItemLabel
            // 
            this.removeItemLabel.AutoSize = true;
            this.removeItemLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.removeItemLabel.LinkColor = System.Drawing.Color.Red;
            this.removeItemLabel.Location = new System.Drawing.Point(405, 101);
            this.removeItemLabel.Name = "removeItemLabel";
            this.removeItemLabel.Size = new System.Drawing.Size(54, 15);
            this.removeItemLabel.TabIndex = 31;
            this.removeItemLabel.TabStop = true;
            this.removeItemLabel.Text = "Remove";
            this.removeItemLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.removeItemLabel_LinkClicked);
            // 
            // Manage_Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 444);
            this.Controls.Add(this.menuDrop);
            this.Controls.Add(this.removeItemLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.allProducts_link);
            this.Controls.Add(this.roundedPanel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.roundTextbox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Manage_Items";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage_Items";
            this.Load += new System.EventHandler(this.Manage_Items_Load);
            this.menuDrop.ResumeLayout(false);
            this.menuDrop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manageButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.roundedPanel2.ResumeLayout(false);
            this.roundedPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dropdownButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label editQty_label;
        private Label label3;
        private RoundedPanel menuDrop;
        private PictureBox settingsButton;
        private PictureBox manageButton;
        private PictureBox receiptButton;
        private Label accName;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private Label label2;
        private RoundedPanel roundedPanel2;
        private Label label1;
        private PictureBox dropdownButton;
        private PictureBox profilePicture;
        private PictureBox cartButton;
        private PictureBox menuButton;
        private Panel panel1;
        private Label label5;
        private RoundTextbox roundTextbox1;
        private PictureBox pictureBox2;
        private Label allProducts_link;
        private FlowLayoutPanel flowLayoutPanel1;
        private ColorDialog colorDialog1;
        private RoundedButton addButton;
        private LinkLabel removeItemLabel;
    }
}