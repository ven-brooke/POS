using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class Manage_Items : Form
    {
        public Manage_Items()
        {
            InitializeComponent();
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
            Sales salesForm = new Sales();
            this.Hide();
            salesForm.Show();
        }
    }
}
