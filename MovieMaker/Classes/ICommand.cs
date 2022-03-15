using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieMaker.Classes
{
    internal interface ICommand
    {
        bool Execute();
        void Undo(); 
    }
}
