using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ColdRing
{
    public partial class ObjectSetting : UserControl
    {
        public ObjectSetting()
        {
            InitializeComponent();
            colorDialog.Color = panel1.BackColor;
        }

        public string Title
        {
            get
            {
                return groupBox1.Text;
            }

            set
            {
                groupBox1.Text = value;
            }
        }
        public Color Color
        {
            get
            {
                return colorDialog.Color;
            }

            set
            {
                colorDialog.Color = value;
                if (panel1.Enabled)
                {
                    panel1.BackColor = value;
                }
            }
        }
        public string FileName
        {
            get
            {
                return openImgDialog.FileName;
            }

            set
            {
                if (File.Exists(value))
                {
                    openImgDialog.FileName = value;
                    string[] itemPath = openImgDialog.FileName.Split(new char[] { '\\' });
                    label1.Text = itemPath[itemPath.Length - 1];
                }
            }
        }
        public bool IsColor
        {
            get
            {
                return radioButton1.Checked;
            }

            set
            {
                radioButton1.Checked = value;
                radioButton2.Checked = !value;
                panel1.Enabled = radioButton1.Checked;
                if (panel1.Enabled)
                {
                    panel1.BackColor = colorDialog.Color;
                }
                else
                {
                    panel1.BackColor = Color.FromKnownColor(KnownColor.Control);
                }

                button1.Enabled = radioButton2.Checked;
                label1.Visible = radioButton2.Checked;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openImgDialog.ShowDialog();
            string[] itemPath = openImgDialog.FileName.Split(new char[] { '\\' });
            label1.Text = itemPath[itemPath.Length - 1];
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            (sender as Panel).BackColor = colorDialog.Color;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Enabled = radioButton1.Checked;
            if (panel1.Enabled)
            {
                panel1.BackColor = colorDialog.Color;
            }
            else
            {
                panel1.BackColor = Color.FromKnownColor(KnownColor.Control);
            }

            button1.Enabled = radioButton2.Checked;
            label1.Visible = radioButton2.Checked;
        }
    }
}
