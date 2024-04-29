using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace CourseProjectGemoetry
{
    [Serializable]
    public abstract class Figure
    {
        protected int x,y,width,height, strokeSize;
        protected Color penColor, fillColor;
        public Color FillColor
        {
            get { return fillColor; }
            set { fillColor = value; }
        }

        public Color PenColor
        {
            get { return penColor; }
            set { penColor = value; }
        }

        public int StrokeSize 
        {
            get { return strokeSize; }
            set { strokeSize = value; }
        }
        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        public int Height
        {
            get { return height; }
            set { height = value; }
        }
        public virtual void Move(int dX, int dY)
        {
            X += dX;
            Y += dY;
        }

        public abstract void Draw(Graphics g);
        public abstract void Fill(Graphics g);  
        public abstract void SetDimensions(Point startPoint, Point endPoint);
        public abstract bool ContainsPoint(Point point);
    }
}
