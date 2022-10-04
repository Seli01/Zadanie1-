using EmployeeRegister_K63_2022.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRegister_K63_2022.IO.Commands
{
    public class Search : ICommand
    {
        public string Label
        {
            get
            {
                return "search employee";
            }

        }
        public void Execute()
        {
            Console.WriteLine("Employee ID to search:");
            int id_ser = int.Parse(Console.ReadLine());


            var context = ModelContext.CreateContext();

            if (id_ser == context.)
            {
                
                foreach (var employee in context.Employees)
                {
                    Console.WriteLine($"{employee.Id}. {employee.FirstName[0]}, {employee.LastName},");
                }
                Console.WriteLine();
            }
        }
    }
}
