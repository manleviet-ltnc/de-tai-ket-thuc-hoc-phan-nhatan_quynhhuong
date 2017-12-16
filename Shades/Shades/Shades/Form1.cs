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

            _x = 0;
            _y = 0;
            _objPosition = Position.Down;
        }

        private void Shades_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Red, _x, _y, 70, 50);
        }

        private void tmrMoving_Tick(object sender, EventArgs e)
        {
            if (_objPosition == Position.Left)
            {
                _x += 10;
            }
            else if (_objPosition == Position.Right)
            {
                _x += 10;
            }
            else if (_objPosition == Position.Up)
            {
                _y += 10;
            }
            else if (_objPosition == Position.Down)
            {
                _y += 10;
            }

            Invalidate();
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
