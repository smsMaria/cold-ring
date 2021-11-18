using System;
using System.Windows.Forms;

namespace ColdRing
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form1 mainForm = new Form1();

            try
            {
                mainForm.battlefieldScreen1.Grid.DashStyle = Properties.Settings.Default.GridStyle;
                mainForm.battlefieldScreen1.Grid.Color = Properties.Settings.Default.GridColor;
                mainForm.battlefieldScreen1.Grid.Width = Properties.Settings.Default.GridSize;

                mainForm.battlefieldScreen1.MainGrid.DashStyle = Properties.Settings.Default.MainGridStyle;
                mainForm.battlefieldScreen1.MainGrid.Color = Properties.Settings.Default.MainGridColor;
                mainForm.battlefieldScreen1.MainGrid.Width = Properties.Settings.Default.MainGridSize;

                mainForm.battlefieldScreen1.BackgroundColor = Properties.Settings.Default.Backcolor;
                mainForm.battlefieldScreen1.WallColor = Properties.Settings.Default.WallColor;
                mainForm.battlefieldScreen1.DemonColor = Properties.Settings.Default.DemonColor;
                mainForm.battlefieldScreen1.SandroColor = Properties.Settings.Default.SandroColor;
                mainForm.battlefieldScreen1.IsColorDemon = Properties.Settings.Default.isDemonColor;
                mainForm.battlefieldScreen1.IsColorSandro = Properties.Settings.Default.isSandroColor;
                mainForm.battlefieldScreen1.FileDemon = Properties.Settings.Default.ImgDemon;
                mainForm.battlefieldScreen1.FileSandro = Properties.Settings.Default.ImgSandro;

                mainForm.battlefieldScreen1.VisibleGrid = Properties.Settings.Default.VisibleGrid;
                mainForm.gridVisible.Checked = Properties.Settings.Default.VisibleGrid;
                mainForm.WindowState = (Properties.Settings.Default.WindowState == FormWindowState.Minimized ? FormWindowState.Normal : Properties.Settings.Default.WindowState);
            }
            catch
            {

            }


            Application.Run(mainForm);
        }
    }
}
