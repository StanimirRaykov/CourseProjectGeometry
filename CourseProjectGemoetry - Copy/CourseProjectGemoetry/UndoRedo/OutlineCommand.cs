using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProjectGemoetry.UndoRedo
{
    internal class OutlineCommand : ICommand
    {
        private Figure figure;
        private Color previousOutlineColor;
        private Color newOutlineColor;

        public OutlineCommand(Figure figure, Color previousOutlineColor, Color newOutlineColor)
        {
            this.figure = figure;
            this.previousOutlineColor = previousOutlineColor;
            this.newOutlineColor = newOutlineColor;
        }

        public void Execute()
        {
            // Change the outline color of the figure
            figure.PenColor = newOutlineColor;
        }

        public void Undo()
        {
            // Revert the outline color of the figure back to the previous color
            figure.PenColor = previousOutlineColor;
        }
    }
}
