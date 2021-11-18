using System;
using System.Drawing;
using System.Windows.Forms;

namespace ColdRing
{
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
            pictureGridLine.Tag = new Pen(Color.Gray, 1);
            pictureMainGridLine.Tag = new Pen(Color.DarkGray, 2);

            DrawStyleLine(pictureGridLine, (Pen)pictureGridLine.Tag);
            DrawStyleLine(pictureMainGridLine, (Pen)pictureMainGridLine.Tag);

        }

        public Pen GridLine
        {
            get
            {
                return (Pen)pictureGridLine.Tag;
            }

            set
            {
                pictureGridLine.Tag = value;
                DrawStyleLine(pictureGridLine, value);
            }

        }

        public Pen MainGridLine
        {
            get
            {
                return (Pen)pictureMainGridLine.Tag;
            }

            set
            {
                pictureMainGridLine.Tag = value;
                DrawStyleLine(pictureMainGridLine, value);
            }
        }

        private void OnEditColor(object sender, EventArgs e)
        {
            colorDialog.Color = (sender as Panel).BackColor;
            colorDialog.ShowDialog();
            (sender as Panel).BackColor = colorDialog.Color;
        }

        private void DrawStyleLine(PictureBox obj, Pen p)
        {
            Image img = new Bitmap(obj.Size.Width, obj.Size.Height);
            Graphics cover = Graphics.FromImage(img);
            cover.Clear(Color.FromKnownColor(KnownColor.Control));
            cover.DrawLine(p, 10, img.Height / 2 - 1, img.Width - 12, img.Height / 2 - 1);
            obj.Image = img;
        }

        private void OnOpenLineSetting(object sender, EventArgs e)
        {
            LineSetting dialog = new LineSetting();
            dialog.LinePen = (Pen)(sender as PictureBox).Tag;
            dialog.ShowDialog();
            if (dialog.DialogResult != DialogResult.OK)
            {
                return;
            }

            (sender as PictureBox).Tag = dialog.LinePen;
            DrawStyleLine((sender as PictureBox), dialog.LinePen);
            dialog.Dispose();
        }
    }
}
