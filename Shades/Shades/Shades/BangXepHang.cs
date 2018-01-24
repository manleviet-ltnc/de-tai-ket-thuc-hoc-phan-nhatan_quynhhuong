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
    public partial class frmBang_Xep_Hang : Form
    {
        public int Cac_Hang = 5;
        public int Cac_Cot =4;
        private string[] A;

        public frmBang_Xep_Hang()
        {
            InitializeComponent();
        }

        private void frmBangXepHang(object sender, EventArgs e)
        {
            A = new string[Cac_Cot];
            for (int Dem = 0; Dem < Cac_Hang; Dem++)
            {
                for (int i = 0; i < Cac_Cot; i++)
                {
                    A[i] = "";
                }
                ListViewItem items = new ListViewItem(A);
                lsvBangXepHang.Items.Add(items);
            }
        }
    }
}
