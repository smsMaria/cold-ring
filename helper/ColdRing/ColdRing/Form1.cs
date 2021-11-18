using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ColdRing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InputTable_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string val = e.FormattedValue.ToString();

            if (val == string.Empty)
            {
                InputTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "0";
                return;
            }


            if (!int.TryParse(val, out int a))
            {
                MessageBox.Show("В качестве координат могут выступать только целые числа!", "Ошибка ввода");
                e.Cancel = true;
            }
        }

        private Point GetPointMoving(List<Point> array)
        {
            double max_x, max_y, min_x, min_y;
            double[] array_x = new double[array.Count];
            double[] array_y = new double[array.Count];
            for (int i = 0; i < array.Count; i++)
            {
                array_x[i] = array[i].X;
                array_y[i] = array[i].Y;
            }


            max_x = array_x.Max();
            max_y = array_y.Max();
            min_x = array_x.Min();
            min_y = array_y.Min();


            double X = (max_x + min_x) / 2;
            double Y = (max_y + min_y) / 2;
            X = Math.Floor(X);
            Y = Math.Floor(Y);
            return new Point(X, Y);
        }

        private Point CalcCenterLine(Point one, Point two)
        {
            return new Point((one.X + two.X) / 2, (one.Y + two.Y) / 2);
        }

        private List<ColdRing.Point> GetDemonList()
        {
            List<Point> list = new List<Point>();
            for (int i = 0; i < InputTable.Rows.Count; i++)
            {
                int x = 0;
                if (InputTable.Rows[i].Cells[0].Value != null && InputTable.Rows[i].Cells[0].Value.ToString() != "")
                    x = int.Parse(InputTable.Rows[i].Cells[0].Value.ToString());

                int y = 0;
                if (InputTable.Rows[i].Cells[1].Value != null && InputTable.Rows[i].Cells[1].Value.ToString() != "")
                    y = int.Parse(InputTable.Rows[i].Cells[1].Value.ToString());

                list.Add(new Point(x, y, (int)(InputTable.Rows[i].Tag != null ? InputTable.Rows[i].Tag : 0)));
            }

            return list;
        }

        private void RepaintbattleScreen()
        {
            List<Point> list = GetDemonList();
            if (list.Count == 0)
            {
                toolStripButton2.Enabled = false;
                toolStripButton3.Enabled = false;
                toolStripButton4.Enabled = false;
                DemonEdit.Enabled = false;
                DemonDelete.Enabled = false;
                DemonClear.Enabled = false;
                battlefieldScreen1.Clear();
                return;
            }

            battlefieldScreen1.Clear();

            battlefieldScreen1.AddDemon(list);

            Point pointMove = new Point();

            if (list.Count >= 3)
            {
                pointMove = GetPointMoving(list);
            }
            else
            {
                if (list.Count == 1)
                {
                    list.Add(new Point(0, 0));
                }

                pointMove = CalcCenterLine(list[0], list[1]);
            }

            battlefieldScreen1.MoveSandro(pointMove);

            double maxDelta = 0;
            foreach (Point demon in list)
            {
                double newDelta = demon.Distance(pointMove);
                if (newDelta > maxDelta)
                {
                    maxDelta = newDelta;
                }
            }

            battlefieldScreen1.Radius = maxDelta;
            OutX.Text = pointMove.X.ToString();
            OutY.Text = pointMove.Y.ToString();
            OutR.Text = maxDelta.ToString();
        }

        private void InputTable_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            RepaintbattleScreen();
        }

        private void InputTable_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            isSaved = false;

            for (int i = e.RowIndex; i < e.RowIndex + e.RowCount; i++)
            {
                InputTable.Rows[i].Tag = i > 0 ? (int)InputTable.Rows[i - 1].Tag + 1 : 0;
            }
        }

        private void InputTable_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            isSaved = false;
            if (InputTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null && InputTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() != "")
            {
                InputTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = int.Parse(InputTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());

            }
            else
            {
                InputTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 0;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            List<Point> list = GetDemonList();
            AddDemonForm demonForm = new AddDemonForm(list, ref InputTable);
            demonForm.ShowDialog();
            RepaintbattleScreen();
        }

        private void InputTable_SelectionChanged(object sender, EventArgs e)
        {
            toolStripButton2.Enabled = true;
            toolStripButton3.Enabled = true;
            toolStripButton4.Enabled = true;
            DemonEdit.Enabled = true;
            DemonDelete.Enabled = true;
            DemonClear.Enabled = true;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            toolStripButton2.Enabled = false;
            toolStripButton3.Enabled = false;
            toolStripButton4.Enabled = false;
            DemonEdit.Enabled = false;
            DemonDelete.Enabled = false;
            DemonClear.Enabled = false;
            InputTable.Rows.Clear();
            battlefieldScreen1.Clear();

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (InputTable.SelectedRows.Count == 0)
            {
                return;
            }
            InputTable.Rows.RemoveAt(InputTable.SelectedRows[0].Index);
            RepaintbattleScreen();
        }

        private void DemonEdit_Click(object sender, EventArgs e)
        {
            if (InputTable.SelectedRows.Count == 0)
            {
                if (InputTable.Rows.Count == 0)
                {
                    MessageBox.Show("Ни один демон не добавлен,\nредактирование недоступно", "Ошибка");
                }
                else
                {
                    MessageBox.Show("Демон для редактирования не выбран", "Ошибка");
                }

                return;
            }

            List<Point> list = GetDemonList();
            EditDemonForm demonForm = new EditDemonForm(list, ref InputTable);
            demonForm.ShowDialog();
        }

        private void gridVisible_Click(object sender, EventArgs e)
        {
            gridVisible.Checked = !gridVisible.Checked;
            Properties.Settings.Default.VisibleGrid = gridVisible.Checked;
            battlefieldScreen1.VisibleGrid = gridVisible.Checked;
        }

        private void Setting_Click(object sender, EventArgs e)
        {
            Setting dialog = new Setting();

            dialog.colorBack.BackColor = Properties.Settings.Default.Backcolor;
            dialog.SandroSetting.Color = Properties.Settings.Default.SandroColor;
            dialog.demonSetting.Color = Properties.Settings.Default.DemonColor;
            dialog.WallColor.BackColor = Properties.Settings.Default.WallColor;

            dialog.SandroSetting.IsColor = Properties.Settings.Default.isSandroColor;
            dialog.demonSetting.IsColor = Properties.Settings.Default.isDemonColor;

            dialog.demonSetting.FileName = Properties.Settings.Default.ImgDemon;
            dialog.SandroSetting.FileName = Properties.Settings.Default.ImgSandro;

            Pen grid = new Pen(Properties.Settings.Default.GridColor, Properties.Settings.Default.GridSize);
            grid.DashStyle = Properties.Settings.Default.GridStyle;
            dialog.GridLine = grid;

            Pen mainGrid = new Pen(Properties.Settings.Default.MainGridColor, Properties.Settings.Default.MainGridSize);
            mainGrid.DashStyle = Properties.Settings.Default.MainGridStyle;
            dialog.MainGridLine = mainGrid;

            dialog.ShowDialog();
            if (dialog.DialogResult != DialogResult.OK)
            {
                return;
            }

            battlefieldScreen1.BackgroundColor = dialog.colorBack.BackColor;
            battlefieldScreen1.SandroColor = dialog.SandroSetting.Color;
            battlefieldScreen1.DemonColor = dialog.demonSetting.Color;
            battlefieldScreen1.WallColor = dialog.WallColor.BackColor;

            battlefieldScreen1.IsColorSandro = dialog.SandroSetting.IsColor;
            battlefieldScreen1.IsColorDemon = dialog.demonSetting.IsColor;

            battlefieldScreen1.FileDemon = dialog.demonSetting.FileName;
            battlefieldScreen1.FileSandro = dialog.SandroSetting.FileName;

            battlefieldScreen1.Grid = dialog.GridLine;
            battlefieldScreen1.MainGrid = dialog.MainGridLine;

            Properties.Settings.Default.GridColor = dialog.GridLine.Color;
            Properties.Settings.Default.GridSize = dialog.GridLine.Width;
            Properties.Settings.Default.GridStyle = dialog.GridLine.DashStyle;

            Properties.Settings.Default.MainGridColor = dialog.MainGridLine.Color;
            Properties.Settings.Default.MainGridSize = dialog.MainGridLine.Width;
            Properties.Settings.Default.MainGridStyle = dialog.MainGridLine.DashStyle;

            Properties.Settings.Default.DemonColor = dialog.demonSetting.Color;
            Properties.Settings.Default.isDemonColor = dialog.demonSetting.IsColor;
            Properties.Settings.Default.ImgDemon = dialog.demonSetting.FileName;

            Properties.Settings.Default.SandroColor = dialog.SandroSetting.Color;
            Properties.Settings.Default.isSandroColor = dialog.SandroSetting.IsColor;
            Properties.Settings.Default.ImgSandro = dialog.SandroSetting.FileName;

            Properties.Settings.Default.Backcolor = dialog.colorBack.BackColor;
            Properties.Settings.Default.WallColor = dialog.WallColor.BackColor;

            dialog.Dispose();
            RepaintbattleScreen();
        }

        private void About_Click(object sender, EventArgs e)
        {
            (new AboutBox1()).ShowDialog();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SaveData(object sender, CancelEventArgs e)
        {
            try
            {
                Stream sw = saveDemonsFileDialog.OpenFile();
                sw.Position = 0;
                List<Point> data = GetDemonList();
                foreach (Point demon in data)
                {
                    byte[] bdemon = Encoding.ASCII.GetBytes(demon.ToString() + '\n');
                    sw.Write(bdemon, 0, bdemon.Length);
                }
                sw.Close();
                isSaved = true;
            }
            catch
            {
                MessageBox.Show("Ошибка записи в файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void OpenData(object sender, CancelEventArgs e)
        {
            isSaved = true;
            InputTable.Rows.Clear();
            try
            {
                Stream sw = openDemonFileDialog.OpenFile();
                sw.Position = 0;
                byte[] data = new byte[sw.Length];
                sw.Read(data, 0, data.Length);
                string[] sdata = Encoding.ASCII.GetString(data).Split('\n');
                foreach (string demon in sdata)
                {
                    if (demon == string.Empty)
                    {
                        continue;
                    }

                    string[] tmp = demon.Split(' ');
                    int x = int.Parse(tmp[0]);
                    int y = int.Parse(tmp[1]);
                    InputTable.Rows.Add(x, y);
                }

                RepaintbattleScreen();
            }
            catch
            {
                MessageBox.Show("Ошибка чтения из файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private bool isSaved = false;

        private void Save_Click(object sender, EventArgs e)
        {
            saveDemonsFileDialog.ShowDialog();
        }

        private void Open_Click(object sender, EventArgs e)
        {
            DialogResult flag = DialogResult.Yes;
            if (InputTable.Rows.Count > 0 && !isSaved)
            {
                flag = MessageBox.Show("При загрузке координат, несохраненные данные будут потеряны." +
                    "\nЖелаете продолжить?", "Внимание", MessageBoxButtons.YesNo);
            }

            if (flag == DialogResult.Yes)
            {
                openDemonFileDialog.ShowDialog();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult flag = DialogResult.No;
            if (InputTable.Rows.Count > 0 && !isSaved)
            {
                flag = MessageBox.Show("Имеются несохраненные данные." +
                    "\nСохранить эти данные?", "Внимание", MessageBoxButtons.YesNoCancel);
            }
            
            switch (flag)
            {
                case DialogResult.Yes:
                    saveDemonsFileDialog.ShowDialog();
                    break;

                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
            }

            Properties.Settings.Default.WindowState = WindowState;

            Properties.Settings.Default.Save();
        }

        private void ScreenSave_Click(object sender, EventArgs e)
        {
            saveScreenFileDialog.ShowDialog();
        }

        private void SaveImage(object sender, CancelEventArgs e)
        {
            try
            {
                ImageFormat[] option = new ImageFormat[] { ImageFormat.Png, ImageFormat.Bmp, ImageFormat.Jpeg };
                SaveFileDialog tmp = (sender as SaveFileDialog);
                battlefieldScreen1.Screen.Save(tmp.FileName, option[tmp.FilterIndex]);
            }
            catch
            {
                MessageBox.Show("Ошибка сохранения изображения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
