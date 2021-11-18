using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColdRing
{
    public partial class BattlefieldScreen : UserControl
    {
        private abstract class Figura
        {
            protected Point MainPoint;
            public bool IsAnimation = true;
            public Point Position
            {
                get
                {
                    return MainPoint;
                }
                set
                {
                    MainPoint = value;
                }
            }

            public Figura(Point a)
            {
                MainPoint = a;
            }

            public Figura(double x, double y)
            {
                MainPoint = new Point(x, y);
            }
        }

        private class FPoint : Figura
        {
            public int Width = 10;

            public FPoint(Point a, int width = 10) : base(a)
            {
                Width = width;
            }

            public FPoint(double x, double y, int width = 10) : base(x, y)
            {
                Width = width;
            }
        }

        private Dictionary<int, FPoint> turn = new Dictionary<int, FPoint>(); // очередь отрисовки
        private FPoint SandroPosition = new FPoint(0, 0);   // позиция Сандро
        private int zoom = 100;     // масштаб в процентах
        private int offsetX = 0;    // смещение по x
        private int offsetY = 0;    // смещение по y
        private Point Center = new Point();

        public Color DemonColor = Color.Black;
        public Color SandroColor = Color.Blue;
        public Color WallColor = Color.Blue;
        public Color BackgroundColor = Color.White;
        public Pen Grid = new Pen(Color.Gray, 1);
        public Pen MainGrid = new Pen(Color.DarkGray, 2);

        public Image Screen
        {
            get
            {
                return Cover.Image;
            }
        }

        public bool IsColorDemon = true;
        public bool IsColorSandro = true;

        public string FileDemon = "";
        public string FileSandro = "";

        private bool _visibleGrid = true;
        public bool VisibleGrid
        {
            get
            {
                return _visibleGrid;
            }

            set
            {
                _visibleGrid = value;
                Repaint();
            }
        }

        private double _radius = 0;
        public double Radius
        {
            get
            {
                return _radius;
            }

            set
            {
                _radius = value;
                Repaint();
            }
        }

        public BattlefieldScreen()
        {
            InitializeComponent();
            hScrollBar1.Maximum = Cover.Width;
            vScrollBar1.Maximum = Cover.Height;
            hScrollBar1.LargeChange = Cover.Width + 1;
            vScrollBar1.LargeChange = Cover.Height + 1;
            Cover.MouseWheel += WheelZoom;
            ScaleNumber.Value = Properties.Settings.Default.Zoom;
            TrackScale.Value = Properties.Settings.Default.Zoom;
        }

        private void WheelZoom(object sender, MouseEventArgs e)
        {
            int delta = e.Delta / 120 * 100;
            if (TrackScale.Value + delta > TrackScale.Maximum)
            {
                delta = TrackScale.Maximum - TrackScale.Value;
            }
            else if (TrackScale.Value + delta < TrackScale.Minimum)
            {
                delta = TrackScale.Minimum - TrackScale.Value;
            }

            TrackScale.Value += delta;
            ScaleNumber.Value += delta;
            zoom = TrackScale.Value;
        }

        private float ZoomSize(float width)
        {
            return width * ((float)zoom / 100);
        }

        private float TransformSize(float width)
        {
            return ZoomSize(width * 20);
        }

        private Point TransformPoint(Point point)
        {
            float Xcenter = (float)Center.X;
            float Ycenter = (float)Center.Y;
            return new Point(Xcenter + ZoomSize((float)point.X * 20), Ycenter - ZoomSize((float)point.Y * 20));
        }

        private void DrawObject(FPoint item, Graphics cover, ref double minX, ref double minY, ref double maxX, ref double maxY, Color color, Image img = null)
        {
            float width = ZoomSize(item.Width);
            Point XY = TransformPoint(new Point(item.Position.X, item.Position.Y));
            float x = (float)XY.X - width / 2;
            float y = (float)XY.Y - width / 2;

            if (x > maxX)
            {
                maxX = x;
            }
            else if (x < minX)
            {
                minX = x;
            }

            if (y > maxY)
            {
                maxY = y;
            }
            else if (y < minY)
            {
                minY = y;
            }
            x -= offsetX;
            y -= offsetY;

            RectangleF rect = new RectangleF(x, y, width, width);
            if (img == null)
            {
                cover.FillEllipse(new SolidBrush(color), rect);
            }
            else
            {
                cover.DrawImage(img, rect);
            }
        }

        private Point ZoomSizeToPixel(Point a)
        {
            double coordX = (a.X + offsetX - Center.X) / ZoomSize(20);
            double coordY = (Center.Y - a.Y - offsetY) / ZoomSize(20);
            return new Point(coordX, coordY);
        }

        private void AsyncRepaint()
        {
            Bitmap bitmap = new Bitmap(Cover.Width, Cover.Height);

            Graphics cover = Graphics.FromImage(bitmap);
            cover.Clear(BackgroundColor);
            cover.SmoothingMode = SmoothingMode.AntiAlias;
            double minX = 0;
            double minY = 0;
            double maxX = Cover.Width;
            double maxY = Cover.Height;

            lock (new object())
            {
                if (VisibleGrid)
                {
                    float lineXL = (float)Center.X - offsetX;
                    float lineXR = (float)Center.X - offsetX;
                    float lineYD = (float)Center.Y - offsetY;
                    float lineYU = (float)Center.Y - offsetY;

                    while (lineXL >= 0 || lineXR <= Cover.Width || lineYU >= 0 || lineYD <= Cover.Height)
                    {
                        if (lineXL >= 0)
                        {
                            double relativeX = ZoomSizeToPixel(new Point(lineXL, Center.Y)).X;
                            cover.DrawLine(relativeX == 0 ? MainGrid : Grid, lineXL, 0, lineXL, Cover.Height);
                            lineXL -= ZoomSize(20);
                        }

                        if (lineXR <= Cover.Width)
                        {
                            double relativeX = ZoomSizeToPixel(new Point(lineXR, Center.Y)).X;
                            cover.DrawLine(relativeX == 0 ? MainGrid : Grid, lineXR, 0, lineXR, Cover.Height);
                            lineXR += ZoomSize(20);
                        }

                        if (lineYU >= 0)
                        {
                            double relativeY = ZoomSizeToPixel(new Point(Center.X, lineYU)).Y;

                            cover.DrawLine(relativeY == 0 ? MainGrid : Grid, 0, lineYU, Cover.Width, lineYU);
                            lineYU -= ZoomSize(20);
                        }

                        if (lineYD <= Cover.Height)
                        {
                            double relativeY = ZoomSizeToPixel(new Point(Center.X, lineYD)).Y;
                            cover.DrawLine(relativeY == 0 ? MainGrid : Grid, 0, lineYD, Cover.Width, lineYD);
                            lineYD += ZoomSize(20);
                        }
                    }
                }
            }


            bool demonFlag = !IsColorDemon && File.Exists(FileDemon);

            Image demon = null;
            if (demonFlag)
            {
                try
                {
                    demon = Image.FromFile(FileDemon);
                }
                catch
                {
                    IsColorDemon = true;
                    FileDemon = "";
                }
            }


            foreach (KeyValuePair<int, FPoint> item in turn)
            {
                DrawObject(item.Value, cover, ref minX, ref minY, ref maxX, ref maxY, DemonColor, demon);
            }

            bool sandroFlag = !IsColorSandro && File.Exists(FileSandro);


            Image sandro = null;
            if (sandroFlag)
            {
                try
                {
                    sandro = Image.FromFile(FileSandro);
                }
                catch
                {
                    IsColorSandro = true;
                    FileSandro = "";
                }
            }

            DrawObject(SandroPosition, cover, ref minX, ref minY, ref maxX, ref maxY, SandroColor, sandro);

            if (_radius > 0)
            {

                Point xy = TransformPoint(new Point(SandroPosition.Position.X, SandroPosition.Position.Y));
                float radius = TransformSize((float)_radius);
                xy.X -= radius;
                xy.Y -= radius;
                int radius2x = (int)Math.Round(radius * 2);

                if (xy.X + radius2x > maxX)
                {
                    maxX = xy.X + radius2x;
                }

                if (xy.Y + radius2x > maxY)
                {
                    maxY = xy.Y + radius2x;
                }

                Rectangle wall = new Rectangle((int)xy.X - offsetX, (int)xy.Y - offsetY, radius2x, radius2x);

                cover.DrawEllipse(new Pen(WallColor, ZoomSize(2)), wall);
            }

            BeginInvoke(new Action(() => Cover.Image = bitmap));

            BeginInvoke(new Action(() =>
            {
                hScrollBar1.Maximum = (int)(maxX + ZoomSize(40));
                vScrollBar1.Maximum = (int)(maxY + ZoomSize(40));
                hScrollBar1.Minimum = (int)(minX - ZoomSize(40));
                vScrollBar1.Minimum = (int)(minY - ZoomSize(40));

            }));
        }

        private void Repaint()
        {
            Size size = Cover.Size;
            float Xcenter = (float)size.Width / 2;
            float Ycenter = (float)size.Height / 2;
            Center.X = Xcenter;
            Center.Y = Ycenter;
            /*Graphics cover = Cover.CreateGraphics();
            cover.Clear(BacgroundColor);            
            Console.WriteLine(Center.ToString());
            cover.DrawLine(new Pen(Color.White), new PointF(Xcenter, 0), new PointF(Xcenter, size.Height));
            cover.DrawLine(new Pen(Color.White), new PointF(0, Ycenter), new PointF(size.Width, Ycenter));*/
            Task.Run(new Action(() => AsyncRepaint()));
        }

        public void AddDemon(Point p)
        {
            FPoint newDemon = new FPoint(p);
            newDemon.IsAnimation = true;
            try
            {
                turn.Add(p.ID, newDemon);
            }
            catch { }

            Repaint();
        }

        public void AddDemon(double x, double y, int id)
        {
            AddDemon(new Point(x, y, id));
        }

        public void AddDemon(List<Point> demonList)
        {
            foreach (Point demon in demonList)
            {
                AddDemon(demon);
            }
        }

        public void Clear()
        {
            turn.Clear();
            SandroPosition.Position = new Point(0, 0);
            _radius = 0;
            Repaint();
        }

        public void MoveSandro(Point p)
        {
            SandroPosition.Position = p;
            Repaint();
        }

        public void MoveSandro(double x, double y)
        {
            MoveSandro(new Point(x, y));
        }

        private void Cover_Paint(object sender, PaintEventArgs e)
        {
            Repaint();
        }

        private void TrackScale_Scroll(object sender, EventArgs e)
        {
            zoom = TrackScale.Value;
            ScaleNumber.Value = TrackScale.Value;
            Properties.Settings.Default.Zoom = TrackScale.Value;
            Cover.Invalidate();
        }

        private void ScaleNumber_ValueChanged(object sender, EventArgs e)
        {
            if (ScaleNumber.Value > 0)
            {
                zoom = (int)ScaleNumber.Value;
                TrackScale.Value = (int)ScaleNumber.Value;
                Properties.Settings.Default.Zoom = (int)ScaleNumber.Value;
                Cover.Invalidate();

            }
        }

        private void BattlefieldScreen_Resize(object sender, EventArgs e)
        {
            hScrollBar1.Maximum = Cover.Width;
            vScrollBar1.Maximum = Cover.Height;
            hScrollBar1.LargeChange = Cover.Width + 1;
            vScrollBar1.LargeChange = Cover.Height + 1;
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            offsetY = e.NewValue;
            Cover.Invalidate();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            offsetX = e.NewValue;
            Cover.Invalidate();
        }

        private void Cover_MouseMove(object sender, MouseEventArgs e)
        {
            Point xy = ZoomSizeToPixel(new Point(e.X, e.Y));
            //toolTipXY.Show(string.Format("x = {0:f2}\ny = {1:f2}", xy.X, xy.Y), Cover);
            toolTipXY.Show(string.Format("x = {0:f2}\ny = {1:f2}", xy.X, xy.Y), Cover, e.X + 10, e.Y + 10);
        }

        private void Cover_MouseLeave(object sender, EventArgs e)
        {
            toolTipXY.Hide(Cover);
        }
    }
}
