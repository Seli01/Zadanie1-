using EmployeeRegister_K63_2022.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRegister_K63_2022.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [ModelPropertyLabel(Label = "first name", Priority = 1)]
        public string FirstName { get; set; }
        [ModelPropertyLabel(Label = "last name", Priority = 2)]
        public string LastName { get; set; }
        [ModelPropertyLabel(Label = "age", Priority = 3)]
        public int Age { get; set; }
        [ModelPropertyLabel(Label = "sex", Priority = 4)]
        public char Sex { get; set; }
    }
}
