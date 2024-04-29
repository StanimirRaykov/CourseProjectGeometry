using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProjectGemoetry.UndoRedo
{
    internal class ResizeCommand : ICommand
    {
        private int previousWidth;
        private int previousHeight;
        private int previousStrokeSize;
        private int width;
        private int height;
        private int strokeSize;
        private Figure figure;

        public ResizeCommand(Figure figure, int previousWidth,int width, int previousHeight,int height, int previousStrokeSize, int strokeSize)
        {
            this.figure = figure;
            this.previousWidth = previousWidth;
            this.width = width;
            this.previousHeight = previousHeight;
            this.height = height;
            this.previousStrokeSize = previousStrokeSize;
            this.strokeSize = strokeSize;
        }

        public void Execute()
        {
            figure.Width = width;
            figure.Height = height;
            figure.StrokeSize = strokeSize;
        }

        public void Undo()
        {
            // Undo the resizing by setting the previous width, height, and stroke size
            figure.Width = previousWidth;
            figure.Height = previousHeight;
            figure.StrokeSize = previousStrokeSize;
        }
    }
}
