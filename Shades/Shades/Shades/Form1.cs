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
    public partial class Shades : Form
    {
        public int So_Hang = 5, So_Cot = 4, Kich_Thuoc = 60;
        private Random roi = new Random();
        private bool chamday = true;
        public int cot = -1;
        public int hang = 0;
        public int diem = 0;

        Label[,] A = new Label[5, 4];


        //enum Position
        //{
        //    Left, Right, Up, Down
        //}

        //private int _x;
        //private int _y;
        //private Position _objPosition;
         
        public Shades()
        {
            InitializeComponent();

            //_x = 50;
            //_y = 50;
            //_objPosition = Position.Down;

            A[0, 0] = label1;
            A[0, 1] = label2;
            A[0, 2] = label3;
            A[0, 3] = label4;
            A[1, 0] = label5;
            A[1, 1] = label6;
            A[1, 2] = label7;
            A[1, 3] = label8;
            A[2, 0] = label9;
            A[2, 1] = label10;
            A[2, 2] = label11;
            A[2, 3] = label12;
            A[3, 0] = label13;
            A[3, 1] = label14;
            A[3, 2] = label15;
            A[3, 3] = label16;
            A[4, 0] = label17;
            A[4, 1] = label18;
            A[4, 2] = label19;
            A[4, 3] = label20;

            for (int i = 0; i < So_Hang; i++)
                for (int j = 0; j < So_Cot; j++)
                    A[i, j].Text = "" + 0;
            timer1.Enabled = true;
        }

        private void Shades_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.FillRectangle(Brushes.Red, _x, _y, 70, 50);

            Color color = Color.Black;
            for (int i = 0; i < So_Hang; i++)
            {
                for (int j = 0; j < So_Cot; j++)
                {
                    switch (A[i, j].Text)
                    {
                        case "0": color = Color.Black; break;
                        case "1": color = Color.LightGreen; break;
                        case "2": color = Color.Green;break;
                        case "4": color = Color.DarkGreen;break;
                    }
                    A[i, j].BackColor = color;
                }
            }
        }

        private void Shades_Load(object sender, EventArgs e)
        {
            
        }

        private void KT()
        {
            for (int i = So_Hang - 1; i >= 0; i--)
                if (KTHang(i))
                {
                    // day cac hang tren xuong
                    DayHangXuong(i);
                    diem += 10;
                    HienThiDiem();
                }

            //for (int j =0; j < Cols; j++)
        }

        private void HienThiDiem()
        {
            lblDiem.Text = "" + diem;
        }

        private void DayHangXuong(int i)
        {
            for (int k = i; k > 0; k--)
                for (int j = 0; j < So_Cot; j++)
                    A[k, j].Text = A[k - 1, j].Text;
            for (int j = 0; j < So_Cot; j++)
                A[0, j].Text = "" + 0;
        }

        private bool KTHang(int i)
        {
            int tam = int.Parse(A[i, 0].Text);
            if (tam == 0) return false;
            for (int j = 1; j < So_Cot; j++)
                if (int.Parse(A[i, j].Text) != tam)
                    return false;
            return true;
            
        }

        public int Them0()
        {
            Random r = new Random();
            int j = r.Next(0, 4);

            A[0, j].Text = "" + 1;
            return j;
            
        }

        private void lblDiem_Click(object sender, EventArgs e)
        {
            
            
        }

        private void Shades_Load_1(object sender, EventArgs e)
        {

        }

        //private void Draw()
        //{

        //    Invalidate();
        //}

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (chamday)
            {
                cot = Them0();
                hang = 0;
                chamday = false;
            }
            else
            {
                if (hang == So_Hang - 1)
                {
                    chamday = true;
                }
                else
                {
                    if (A[hang, cot].Text != "4" && A[hang + 1, cot].Text == A[hang, cot].Text)
                    {
                        int tam = int.Parse(A[hang + 1, cot].Text) + int.Parse(A[hang, cot].Text);
                        A[hang + 1, cot].Text = "" + tam;
                        A[hang, cot].Text = "" + 0;
                        hang = hang + 1;
                    }
                    else if (A[hang + 1, cot].Text == "0")
                    {
                        A[hang + 1, cot].Text = A[hang, cot].Text;
                        A[hang, cot].Text = "" + 0;
                        hang = hang + 1;
                    }
                    else
                        chamday = true;
                }
            }
            Invalidate();

            KT();
            Invalidate();
        }

        //private void tmrMoving_Tick(object sender, EventArgs e)
        //{
        //    if (_objPosition == Position.Left)
        //    {

        //        _x -= 10;

        //        _x -= 5;

        //    }
        //    else if (_objPosition == Position.Right)
        //    {
        //        _x += 5;
        //    }


        //    else if (_objPosition == Position.Up)
        //    {
        //        _y -= 5;
        //    }
        //    else if (_objPosition == Position.Down)
        //    {
        //        _y += 5;
        //    }

        //    Invalidate();
        //}

        private void Shades_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                cot -= 1;
            }
            else if (e.KeyCode == Keys.Right)
            {
                cot += 1;
            }
        }


    }
}