using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ColdRing
{
    public partial class AddDemonForm : Form
    {
        private List<Point> demons = new List<Point>();
        private DataGridView table = null;

        public AddDemonForm()
        {
            InitializeComponent();
        }

        public AddDemonForm(List<ColdRing.Point> demons, ref DataGridView table)
        {
            this.demons = demons;
            this.table = table;
            InitializeComponent();
        }

        private void InputX_KeyPress(object sender, KeyPressEventArgs e)
        {
            int[] allowKeys = new int[] { (int)Keys.Back, (int)Keys.Delete, (int)Keys.Left, (int)Keys.Right };
            if (allowKeys.Contains(e.KeyChar))
            {
                return;
            }

            if (e.KeyChar == (int)Keys.Enter)
            {
                saved();
                return;
            }

            if (e.KeyChar == '-' && !(sender as TextBox).Text.Contains("-") && (sender as TextBox).SelectionStart == 0)
            {
                return;
            }

            if (!int.TryParse(e.KeyChar.ToString(), out int a))
            {
                e.Handled = true;
            }
        }

        private void saved()
        {
            if (InputX.Text == string.Empty)
            {
                InputX.Text = "0";
            }

            if (InputY.Text == string.Empty)
            {
                InputY.Text = "0";
            }

            Point newPoint = new ColdRing.Point(int.Parse(InputX.Text), int.Parse(InputY.Text));

            if (newPoint.X == 0 && newPoint.Y == 0)
            {
                Status.Text = "Демон не может находиться в точке (0;0)";
                return;
            }

            foreach (Point demon in demons)
            {
                if (demon.X == newPoint.X && demon.Y == newPoint.Y)
                {
                    Status.Text = "Демон с такими координатами существует";
                    return;
                }
            }

            table.Rows.Add(int.Parse(InputX.Text), int.Parse(InputY.Text));
            Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            saved();
        }

        private void buttonCansel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void InputX_Click(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text == "0")
            {
                (sender as TextBox).Text = "";
            }
        }

        private void InputY_Leave(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text == string.Empty)
            {
                (sender as TextBox).Text = "0";
            }
            else
            {
                if (int.TryParse((sender as TextBox).Text, out int val))
                {
                    (sender as TextBox).Text = val.ToString();
                }
                else
                {
                    (sender as TextBox).Text = "0";
                }
            }
        }

        private void AddDemonForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = false;
                e.Handled = true;
                saved();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                e.SuppressKeyPress = false;
                e.Handled = true;
                Close();
            }
        }
    }
}
