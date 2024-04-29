using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProjectGemoetry
{
    [Serializable]
    internal class RectangleFigure : Figure
    {
        public RectangleFigure(int x, int y, int width, int height,int strokeSize, Color penColor, Color fillColor)
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
                g.DrawRectangle(pen, X, Y, Width, Height);
        }
        public override void Fill(Graphics g)
        {
            using (Brush brush = new SolidBrush(FillColor))
            {
                g.FillRectangle(brush, X, Y, Width, Height);
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
            Height = Math.Abs(startPoint.Y - endPoint.Y);
        }
        public override bool ContainsPoint(Point point)
        {
            return point.X >= X && point.X <= X + Width && point.Y >= Y && point.Y <= Y + Height;
        }
    }
}
