using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProjectGemoetry.UndoRedo
{
    public class AddFigureCommand : ICommand
    {
        private List<Figure> figures;
        private Figure figureToAdd;

        public AddFigureCommand(List<Figure> figures, Figure figure)
        {
            this.figures = figures;
            this.figureToAdd = figure;
        }

        public void Execute()
        {
            figures.Add(figureToAdd);
        }

        public void Undo()
        {
            figures.Remove(figureToAdd);
        }
    }
}
