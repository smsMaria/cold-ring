using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ColdRing
{
    public partial class LineSetting : Form
    {
        private DashStyle[] types = new DashStyle[] { DashStyle.Solid, DashStyle.Dash, DashStyle.Dot, DashStyle.DashDot, DashStyle.DashDotDot };

        public LineSetting()
        {
            InitializeComponent();
            foreach (object o in types)
            {
                typeLine.Items.Add(o);
            }
            typeLine.SelectedIndex = 0;
        }

        private void OnEditColor(object sender, EventArgs e)
        {
            colorDialog.Color = (sender as Panel).BackColor;
            colorDialog.ShowDialog();
            (sender as Panel).BackColor = colorDialog.Color;
        }

        private void comboBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            var a = e.Graphics;
            var r = e.Bounds;
            r.X += 5;
            r.Y += (r.Height / 2);
            float w = (float)lineSize.Value;
            w = (float)lineSize.Value > 7 ? 7 : (float)lineSize.Value;
            Pen p = new Pen(Color.Black, w);
            p.DashStyle = types[e.Index];
            a.DrawLine(p, r.X, r.Y, r.Width - 5, r.Y);
        }

        private void lineSize_ValueChanged(object sender, EventArgs e)
        {
            typeLine.Invalidate();
        }

        public float LineSize
        {
            get
            {
                return (float)lineSize.Value;
            }

            set
            {
                lineSize.Value = (decimal)value;
            }
        }

        public DashStyle LineStyle
        {
            get
            {
                return types[typeLine.SelectedIndex];
            }

            set
            {
                for (int i = 0; i < types.Length; i++)
                {
                    if (types[i].Equals(value))
                    {
                        typeLine.SelectedIndex = i;
                        return;
                    }
                }

                typeLine.SelectedIndex = 0;

            }
        }

        public Color LineColor
        {
            get
            {
                return lineColor.BackColor;
            }

            set
            {
                lineColor.BackColor = value;
            }
        }

        public Pen LinePen
        {
            get
            {
                Pen p = new Pen(LineColor, LineSize);
                p.DashStyle = LineStyle;
                return p;
            }

            set
            {
                LineStyle = value.DashStyle;
                LineColor = value.Color;
                LineSize = value.Width;
            }
        }
    }
}
