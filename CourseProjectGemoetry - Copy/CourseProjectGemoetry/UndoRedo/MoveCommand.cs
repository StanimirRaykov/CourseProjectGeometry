using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProjectGemoetry.UndoRedo
{
    internal class MoveCommand : ICommand
    {
        private Figure figure;
        private int oldDeltaX;
        private int oldDeltaY;
        private int deltaX;
        private int deltaY;

        public MoveCommand(Figure figure, int deltaX, int deltaY)
        {
            this.figure = figure;
            this.oldDeltaX = deltaX;
            this.oldDeltaY = deltaY;
            this.deltaX = figure.X;
            this.deltaY = figure.Y;
        }

        public void Execute()
        {
            // Execute the move operation
            figure.X = deltaX;
            figure.Y = deltaY;
        }

        public void Undo()
        {
            // Undo the move operation by moving the figure back to its previous position
            figure.X = oldDeltaX;
            figure.Y = oldDeltaY;
        }
    }
}
