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

        private void btnMau_Click(object sender, EventArgs e)
        {
            //khởi tạo 1 đối tượng của class ColorDialog
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                //thiết lập màu nền của textbox1 là màu đã chọn
                button1.BackColor = colorDialog.Color;
            }
        }
    }
}
