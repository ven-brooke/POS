namespace POS
{
    partial class Sales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sales));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cartButton = new System.Windows.Forms.PictureBox();
            this.menuButton = new System.Windows.Forms.PictureBox();
            this.roundedPanel2 = new POS.RoundedPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.payButton = new POS.RoundedButton();
            this.cancelButton = new POS.RoundedButton();
            this.addToCart = new POS.RoundedButton();
            this.menuDrop = new POS.RoundedPanel();
            this.settingsButton = new System.Windows.Forms.PictureBox();
            this.manageButton = new System.Windows.Forms.PictureBox();
            this.receiptButton = new System.Windows.Forms.PictureBox();
            this.accName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.quantity_textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.productName_comboBox = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            this.roundedPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuDrop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manageButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.cartButton);
            this.panel1.Controls.Add(this.menuButton);
            this.panel1.Location = new System.Drawing.Point(-3, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(722, 59);
            this.panel1.TabIndex = 0;
            // 
            // cartButton
            // 
            this.cartButton.Image = ((System.Drawing.Image)(resources.GetObject("cartButton.Image")));
            this.cartButton.Location = new System.Drawing.Point(678, 15);
            this.cartButton.Name = "cartButton";
            this.cartButton.Size = new System.Drawing.Size(31, 33);
            this.cartButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cartButton.TabIndex = 1;
            this.cartButton.TabStop = false;
            // 
            // menuButton
            // 
            this.menuButton.Image = ((System.Drawing.Image)(resources.GetObject("menuButton.Image")));
            this.menuButton.Location = new System.Drawing.Point(25, 15);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(31, 33);
            this.menuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.menuButton.TabIndex = 0;
            this.menuButton.TabStop = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.BackColor = System.Drawing.Color.White;
            this.roundedPanel2.Controls.Add(this.dataGridView1);
            this.roundedPanel2.Controls.Add(this.label5);
            this.roundedPanel2.Controls.Add(this.label1);
            this.roundedPanel2.Location = new System.Drawing.Point(364, 75);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.Size = new System.Drawing.Size(342, 299);
            this.roundedPanel2.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemName,
            this.itemPrice,
            this.quantity,
            this.totalPrice});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(14, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(314, 207);
            this.dataGridView1.TabIndex = 21;
            // 
            // itemName
            // 
            this.itemName.HeaderText = "Item Name";
            this.itemName.Name = "itemName";
            // 
            // itemPrice
            // 
            this.itemPrice.HeaderText = "Item Price";
            this.itemPrice.Name = "itemPrice";
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            // 
            // totalPrice
            // 
            this.totalPrice.HeaderText = "Total Price";
            this.totalPrice.Name = "totalPrice";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label5.Location = new System.Drawing.Point(14, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "Total";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(144, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Checkout";
            // 
            // payButton
            // 
            this.payButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.payButton.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.payButton.Location = new System.Drawing.Point(515, 380);
            this.payButton.Name = "payButton";
            this.payButton.Size = new System.Drawing.Size(191, 49);
            this.payButton.TabIndex = 3;
            this.payButton.Text = "Pay (Total)";
            this.payButton.UseVisualStyleBackColor = false;
            this.payButton.Click += new System.EventHandler(this.payButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.IndianRed;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancelButton.Location = new System.Drawing.Point(363, 383);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(132, 49);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel Order";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addToCart
            // 
            this.addToCart.BackColor = System.Drawing.Color.White;
            this.addToCart.FlatAppearance.BorderSize = 0;
            this.addToCart.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addToCart.ForeColor = System.Drawing.Color.SteelBlue;
            this.addToCart.Location = new System.Drawing.Point(201, 342);
            this.addToCart.Name = "addToCart";
            this.addToCart.Size = new System.Drawing.Size(84, 34);
            this.addToCart.TabIndex = 5;
            this.addToCart.Text = "Add";
            this.addToCart.UseVisualStyleBackColor = false;
            this.addToCart.Click += new System.EventHandler(this.addToCart_Click);
            // 
            // menuDrop
            // 
            this.menuDrop.Controls.Add(this.settingsButton);
            this.menuDrop.Controls.Add(this.manageButton);
            this.menuDrop.Controls.Add(this.receiptButton);
            this.menuDrop.Controls.Add(this.accName);
            this.menuDrop.Controls.Add(this.pictureBox1);
            this.menuDrop.Location = new System.Drawing.Point(21, 62);
            this.menuDrop.Name = "menuDrop";
            this.menuDrop.Size = new System.Drawing.Size(140, 10);
            this.menuDrop.TabIndex = 16;
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
            this.manageButton.Click += new System.EventHandler(this.manageButton_Click);
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
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.ForeColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(24, 78);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(334, 239);
            this.flowLayoutPanel1.TabIndex = 17;
            // 
            // quantity_textBox
            // 
            this.quantity_textBox.Location = new System.Drawing.Point(95, 350);
            this.quantity_textBox.Name = "quantity_textBox";
            this.quantity_textBox.Size = new System.Drawing.Size(100, 23);
            this.quantity_textBox.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(22, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Quantity:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.SteelBlue;
            this.label7.Location = new System.Drawing.Point(22, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "Product";
            // 
            // productName_comboBox
            // 
            this.productName_comboBox.FormattingEnabled = true;
            this.productName_comboBox.Location = new System.Drawing.Point(95, 321);
            this.productName_comboBox.Name = "productName_comboBox";
            this.productName_comboBox.Size = new System.Drawing.Size(100, 23);
            this.productName_comboBox.TabIndex = 22;
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(718, 444);
            this.Controls.Add(this.productName_comboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.quantity_textBox);
            this.Controls.Add(this.menuDrop);
            this.Controls.Add(this.addToCart);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.payButton);
            this.Controls.Add(this.roundedPanel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.Sales_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cartButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            this.roundedPanel2.ResumeLayout(false);
            this.roundedPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuDrop.ResumeLayout(false);
            this.menuDrop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manageButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private PictureBox menuButton;
        private PictureBox cartButton;
        private RoundedPanel roundedPanel2;
        private RoundedButton payButton;
        private RoundedButton cancelButton;
        private RoundedButton addToCart;
        private Label label5;
        private Label label1;
        private RoundedPanel menuDrop;
        private PictureBox settingsButton;
        private PictureBox manageButton;
        private PictureBox receiptButton;
        private Label accName;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private FlowLayoutPanel flowLayoutPanel1;
        private DataGridView dataGridView1;
        private TextBox quantity_textBox;
        private Label label6;
        private Label label7;
        private ComboBox productName_comboBox;
        private DataGridViewTextBoxColumn itemName;
        private DataGridViewTextBoxColumn itemPrice;
        private DataGridViewTextBoxColumn quantity;
        private DataGridViewTextBoxColumn totalPrice;
    }
}