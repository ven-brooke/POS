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
        public Sales(string currentUsername)
        {
            InitializeComponent();
            _currentUsername = currentUsername;
        }
        bool expand = false;

        private void Sales_Load(object sender, EventArgs e)
        {
        }
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
