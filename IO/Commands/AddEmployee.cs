using EmployeeRegister_K63_2022.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRegister_K63_2022.IO.Commands
{
    public class AddEmployee : ICommand
    {
        public string Label 
        {
            get
            {
                return "add employee";
            }
        }

        public void Execute()
        {
            var creator = new CreateAnyModel<Employee>();
            var employee = creator.Create();

            var context = new ModelContext();
            context.Employees.Add(employee);
            Console.WriteLine("Added!");
        }
    }
}
