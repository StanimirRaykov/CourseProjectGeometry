using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProjectGemoetry
{
    [Serializable]
    internal class SquareFigure : Figure
    {
        public SquareFigure(int x, int y, int width, int strokeSize, Color penColor, Color fillColor)
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
                g.DrawRectangle(pen, X, Y, Width, Width);
        }
        public override void Fill(Graphics g)
        {
            using (Brush brush = new SolidBrush(FillColor))
            {
                g.FillRectangle(brush, X, Y, Width, Width);
            }
        }
        public override void SetDimensions(Point startPoint, Point endPoint)
        {
            X = Math.Min(startPoint.X, endPoint.X);
            Y = Math.Min(startPoint.Y, endPoint.Y);
            Width = Math.Abs(startPoint.X - endPoint.X);
        }
        public override bool ContainsPoint(Point point)
        {
            return point.X >= X && point.X <= X + Width && point.Y >= Y && point.Y <= Y + Width;
        }
    }
}
