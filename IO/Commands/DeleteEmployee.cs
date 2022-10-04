using EmployeeRegister_K63_2022.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRegister_K63_2022.IO.Commands
{
    public  class DeleteEmployee : ICommand
    {
        public string Label
        {
            get
            {
                return "delete employee";
            }

        }
        public void Execute()
        {
            var context = ModelContext.CreateContext();
            Console.WriteLine("Employee ID to delete:");
            int del_id = int.Parse(Console.ReadLine());

            if (del_id > 0)
            {
                context.Employees.RemoveAll(id => id.Id == del_id);
            }

        }
    }
}
