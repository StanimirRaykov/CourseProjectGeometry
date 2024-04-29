using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CourseProjectGemoetry
{
    [Serializable]
    internal class CircleFigure : Figure
    {
        public CircleFigure(int x, int y, int width, int strokeSize, Color penColor, Color fillColor)
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
            using (Pen pen = new Pen(PenColor, StrokeSize))
            {
                g.DrawEllipse(pen, X, Y, Width, Width);
            }
        }
        public override void Fill(Graphics g)
        {
            using (Brush brush = new SolidBrush(FillColor))
            {
                g.FillEllipse(brush, X, Y, Width, Width);
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
        }
        public override bool ContainsPoint(Point point)
        {
            double centerX = X + Width / 2.0;
            double centerY = Y + Width / 2.0;
            double radiusX = Width / 2.0;
            double radiusY = Width / 2.0;

            double dx = (point.X - centerX) / radiusX;
            double dy = (point.Y - centerY) / radiusY;

            return dx * dx + dy * dy <= 1;
        }
    }
}
