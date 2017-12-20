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


        enum Position
        {
            Left, Right, Up, Down
        }

        private int _x;
        private int _y;
        private Position _objPosition;

        public Shades()
        {
            InitializeComponent();

            _x = 50;
            _y = 50;
            _objPosition = Position.Down;
        }

        private void Shades_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Red, _x, _y, 70, 50);


        }

        private void Shades_Load(object sender, EventArgs e)
        {
            int[,] A = new int[So_Hang, So_Cot];

            for (int i = 0; i < So_Hang; i++)
                for (int j = 0; j < So_Cot; j++)
                    A[i, j] = 0;
            while (true)
            {
                if (chamday)
                {
                    So_Cot = Them0();
                    So_Hang = 0;
                    chamday = false;
                    Draw();
                }
                else
                {
                    if (hang == So_Hang - 1)
                    {
                        chamday = true;
                        continue;
                    }
                    else
                    {
                        if (A[hang, cot] != 4 && A[hang + 1, cot] == A[hang, cot])
                        {
                            A[hang + 1, cot] += A[hang, cot];
                            A[hang, cot] = 0;
                            hang = hang + 1;
                        }
                        else if (A[hang + 1, cot] == 0)
                        {
                            A[hang + 1, cot] = A[hang, cot];
                            A[hang, cot] = 0;
                            hang = hang + 1;
                        }
                        else
                            chamday = true;
                    }
                    KT();
                }
            }
        }

        private void KT()
        {
            for (int i = So_Hang - 1; i >= 0; i--)
                if (KTHang(i))
                    // day cac hang tren xuong
                    DayHangXuong(i);

            //for (int j =0; j < Cols; j++)

        }

        private void DayHangXuong(int i)
        {
            int[,] A = new int[So_Hang, So_Cot];
            for (int k = i; k > 0; k--)
                for (int j = 0; j < So_Cot; j++)
                    A[k, j] = A[k - 1, j];
            for (int j = 0; j < So_Cot; j++)
                A[0, j] = 0;
        }

        private bool KTHang(int i)
        {
            int[,] A = new int[So_Hang, So_Cot];
            int tam = A[i, 0];
            if (tam == 0) return false;
            for (int j = 1; j < So_Cot; j++)
                if (A[i, j] != tam)
                    return false;
            return true;
        }

        public int Them0()
        {
            int[,] A = new int[So_Hang, So_Cot];
            Random r = new Random();
            int j = r.Next(0, 4);

            A[0, j] = 1;
            return j;
        }

        private void Draw()
        {
            for (int i = 0; i < So_Hang; i++)
            {
                for (int j = 0; j < So_Cot; j++) ;
            }
        }


        private void tmrMoving_Tick(object sender, EventArgs e)
        {
            if (_objPosition == Position.Left)
            {

                _x -= 10;

                _x -= 5;

            }
            else if (_objPosition == Position.Right)
            {
                _x += 5;
            }


            else if (_objPosition == Position.Up)
            {
                _y -= 5;
            }
            else if (_objPosition == Position.Down)
            {
                _y += 5;
            }

            //Invalidate();
        }

        private void Shades_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                _objPosition = Position.Left;
            }
            else if (e.KeyCode == Keys.Right)
            {
                _objPosition = Position.Right;
            }

            else if (e.KeyCode == Keys.Up)
            {
                _objPosition = Position.Up;
            }
            else if (e.KeyCode == Keys.Down)
            {
                _objPosition = Position.Down;

            }

        }


    }
}