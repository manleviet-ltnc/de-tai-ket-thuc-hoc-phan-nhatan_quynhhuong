using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shades
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "Form1";
            this.Click += new System.EventHandler(this.Form1_Click);
            this.ResumeLayout(false);

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            SolidBrush sb = new SolidBrush(Color.Red);

            Graphics g = this.CreateGraphics();

            g.FillRectangle(sb, 70, 0, 70, 50);

            sb.Dispose();
            g.Dispose();
        }

        // Khoi tao 3 hang so luu buoc diem thuong , so luong dong va cot nhieu nhat
        const int BONUS_SCORE = 100;
        const int MAX_ROW = 5;
        const int MAX_COL = 4;      
    }
}
