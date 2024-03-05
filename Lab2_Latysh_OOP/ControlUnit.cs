using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Latysh_OOP
{
     class ControlUnit
    {
        private List<Command> commands = new List<Command>();
        int curr = 0;
        public void StoreComm(Command command)
        {
            commands.Add(command);
        }
        public void ExecuteComm()
        {
            commands[curr].Execute();
            curr++;
        }
        public void Undo(int levels)
        {
            for (int i = 0; i < levels; i++)
            {
                if (curr > 0)
                    commands[--curr].UnExecute();
            }
        }
        public void Redo(int levels) 
        {
            for (int i = 0; i < levels; i++)
            {
                if(curr<commands.Count-1)
                    commands[curr++].Execute();
            }
        }
    }
}
