using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieMaker.Classes
{
    internal class InstructionExecutor
    {
        List<ICommand> commandHistory;
        int num;
        static InstructionExecutor instance;

        private InstructionExecutor()
        {
            commandHistory = new List<ICommand>();
            
            num = 0;
        }
        public static InstructionExecutor Get()
        {
            if(instance == null) instance = new InstructionExecutor();
            return instance;
        }
        public bool Execute(ICommand command)
        {
            if(command.Execute())
            {
                commandHistory.RemoveRange(num, commandHistory.Count - num);
                commandHistory.Add(command);
                num++;
                return true;
            }
            return false;
        }
        public void Undo()
        {
            if(num>0) commandHistory[--num].Undo();
        }
        public void Retry()
        {
            if(num<commandHistory.Count) commandHistory[num++].Execute();
        }
    }
}
