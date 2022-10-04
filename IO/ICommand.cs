using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRegister_K63_2022.IO
{
    public interface ICommand
    {
        public string Label { get; }
        public void Execute();
    }
}
