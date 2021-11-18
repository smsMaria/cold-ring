using System;

namespace ColdRing
{
    public class Point
    {
        private double x, y;

        public double X
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }
        }
        public double Y
        {
            get
            {
                return y;
            }

            set
            {
                y = value;
            }
        }
        public readonly int ID = -1;

        public Point()
        {
            x = 0;
            y = 0;
        }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public Point(int x, int y, int id)
        {
            this.x = x;
            this.y = y;
            ID = id;
        }

        public Point(double x, double y, int id)
        {
            this.x = x;
            this.y = y;
            ID = id;
        }

        public static Point operator +(Point a, Point b)
        {
            return new Point(a.X + b.X, a.Y + b.Y);
        }

        public static Point operator -(Point a, Point b)
        {
            return new Point(a.X - b.X, a.Y - b.Y);
        }

        public static Point operator +(Point a, double b)
        {
            return new Point(a.X + b, a.Y + b);
        }

        public static Point operator -(Point a, double b)
        {
            return new Point(a.X - b, a.Y - b);
        }

        public static Point operator +(Point a, int b)
        {
            return new Point(a.X + b, a.Y + b);
        }

        public static Point operator -(Point a, int b)
        {
            return new Point(a.X - b, a.Y - b);
        }

        public double Distance(Point a)
        {
            return Distance(a.X, a.Y);
        }

        public double Distance(double x, double y)
        {
            return Math.Sqrt(Math.Pow(x - this.x, 2) + Math.Pow(y - this.y, 2));
        }

        public double Distance(int x, int y)
        {
            return Distance((double)x, (double)y);
        }

        override public string ToString()
        {
            return string.Format("{0} {1}", X, Y);
        }
    }
}
