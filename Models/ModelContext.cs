using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRegister_K63_2022.Models
{
    public class ModelContext
    {
        private static List<Employee> employees { get; set; } 
        private static List<Address> addresses { get; set; }
        private static List<AddressEmployeeBind> binds { get; set; }

        public ModelContext()
        {
            if (employees == null)
                employees = new List<Employee>();
            if (addresses == null)
                addresses = new List<Address>();
            if (binds == null)
                binds = new List<AddressEmployeeBind>();
        }

        public List<Employee> Employees { get { return employees; } }
        public List<Address> Address { get { return addresses; } }
        public List<AddressEmployeeBind> Binds { get { return binds; } }
    }
}
