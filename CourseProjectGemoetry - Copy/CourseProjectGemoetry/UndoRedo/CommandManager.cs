using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProjectGemoetry.UndoRedo
{
    public class CommandManager
    {
        private List<ICommand> commandHistory = new List<ICommand>();
        private int currentIndex = -1;

        public void ExecuteCommand(ICommand command)
        {
            commandHistory.RemoveRange(currentIndex + 1, commandHistory.Count - currentIndex - 1);

            command.Execute();
            commandHistory.Add(command);
            currentIndex++;
        }

        public void Undo()
        {
            if (currentIndex >= 0)
            {
                ICommand command = commandHistory[currentIndex];
                command.Undo();
                currentIndex--;
            }
        }

        public void Redo()
        {
            if (currentIndex < commandHistory.Count - 1)
            {
                currentIndex++;
                ICommand command = commandHistory[currentIndex];
                command.Execute();
            }
        }
    
    }
}
