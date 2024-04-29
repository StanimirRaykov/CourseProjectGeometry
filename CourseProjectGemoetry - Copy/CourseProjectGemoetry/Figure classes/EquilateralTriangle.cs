using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CourseProjectGemoetry.Figure_classes
{
    internal class EquilateralTriangle : Figure
    {
        public EquilateralTriangle(int x, int y, int width, int strokeSize, Color penColor, Color fillColor)
        {
            X = x;
            Y = y;
            Width = width;
            StrokeSize = strokeSize;
            PenColor = penColor;
            FillColor = fillColor;
        }
        public override void Draw(Graphics g)
        {
            Point[] points =
            {
                new Point(X, Y + Width),
                new Point(X + Width / 2, Y),
                new Point(X + Width, Y + Width)
            };
            using (Pen pen = new Pen(PenColor, StrokeSize))
            {

                g.DrawPolygon(pen, points);
            }
        }
        public override void Fill(Graphics g)
        {
            Point[] points =
            {
                new Point(X, Y + Width),
                new Point(X + Width / 2, Y),
                new Point(X + Width, Y + Width)
            };
            using (Brush brush = new SolidBrush(FillColor))
            {

                g.FillPolygon(brush, points);
            }
        }
        public override void Move(int dx, int dy)
        {
            X += dx;
            Y += dy;
        }
        public override void SetDimensions(Point startPoint, Point endPoint)
        {
            X = Math.Min(startPoint.X, endPoint.X);
            Y = Math.Min(startPoint.Y, endPoint.Y);
            Width = Math.Abs(startPoint.X - endPoint.X);
            Height = (int)(Width * Math.Sqrt(3) / 2);
            Y = Y + (Width - Height) / 2;
        }
        public override bool ContainsPoint(Point point)
        {
            PointF point1 = new PointF(X + Width / 2, Y);
            PointF point2 = new PointF(X, Y + Height);
            PointF point3 = new PointF(X + Width, Y + Height);

            var v0 = new PointF(point3.X - point1.X, point3.Y - point1.Y);
            var v1 = new PointF(point2.X - point1.X, point2.Y - point1.Y);
            var v2 = new PointF(point.X - point1.X, point.Y - point1.Y);

            var dot00 = DotProduct(v0, v0);
            var dot01 = DotProduct(v0, v1);
            var dot02 = DotProduct(v0, v2);
            var dot11 = DotProduct(v1, v1);
            var dot12 = DotProduct(v1, v2);

            var invDenom = 1 / (dot00 * dot11 - dot01 * dot01);
            var u = (dot11 * dot02 - dot01 * dot12) * invDenom;
            var v = (dot00 * dot12 - dot01 * dot02) * invDenom;

            return (u >= 0) && (v >= 0) && (u + v <= 1);
        }

        private float DotProduct(PointF p1, PointF p2)
        {
            return p1.X * p2.X + p1.Y * p2.Y;
        }
    }
}
