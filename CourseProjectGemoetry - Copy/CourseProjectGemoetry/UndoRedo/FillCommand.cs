using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProjectGemoetry.UndoRedo
{
    internal class FillCommand : ICommand
    {
        private Figure figure;
        private Color previousFillColor;
        private Color newFillColor;

        public FillCommand(Figure figure, Color previousOutlineColor, Color newOutlineColor)
        {
            this.figure = figure;
            this.previousFillColor = previousOutlineColor;
            this.newFillColor = newOutlineColor;
        }

        public void Execute()
        {
            // Change the outline color of the figure
            figure.FillColor = newFillColor;
        }

        public void Undo()
        {
            // Revert the outline color of the figure back to the previous color
            figure.FillColor = previousFillColor;
        }
    }
}
