using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProjectGemoetry
{
    [Serializable]
    internal class EllipseFigure : Figure
    {
        public EllipseFigure(int x, int y, int width, int height,int strokeSize, Color penColor, Color fillColor)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
            StrokeSize = strokeSize;
            PenColor = penColor;
            FillColor = fillColor;
        }

        public override void Draw(Graphics g)
        {
            using (Pen pen = new Pen(PenColor, StrokeSize))
            {
                g.DrawEllipse(pen, X, Y, Width, Height);
            }
        }
        public override void Fill(Graphics g)
        {
            using (Brush brush = new SolidBrush(FillColor))
            {
                g.FillEllipse(brush, X, Y, Width, Height);
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
            Width = Math.Abs(endPoint.X - startPoint.X);
            Height = Math.Abs(endPoint.Y - startPoint.Y);
        }
        public override bool ContainsPoint(Point point)
        {
            double centerX = X + Width / 2.0;
            double centerY = Y + Height / 2.0;
            double radiusX = Width / 2.0;
            double radiusY = Height / 2.0;

            double dx = (point.X - centerX) / radiusX;
            double dy = (point.Y - centerY) / radiusY;

            return dx * dx + dy * dy <= 1;
        }
    }
}
