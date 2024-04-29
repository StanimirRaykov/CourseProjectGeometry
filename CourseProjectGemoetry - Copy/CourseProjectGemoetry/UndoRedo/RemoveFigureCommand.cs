using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProjectGemoetry.UndoRedo
{
    public class RemoveFigureCommand : ICommand
    {
        private List<Figure> figures;
        private Figure figureToRemove;

        public RemoveFigureCommand(List<Figure> figures, Figure figure)
        {
            this.figures = figures;
            this.figureToRemove = figure;
        }

        public void Execute()
        {
            figures.Remove(figureToRemove);
        }

        public void Undo()
        {
            figures.Add(figureToRemove);
        }
    }
}
