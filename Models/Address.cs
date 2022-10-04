using EmployeeRegister_K63_2022.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRegister_K63_2022.Models
{
    [Serializable]
    public class Address
    {
        
       

        public int Id { get; set; }

        [ModelPropertyLabel(Label = "City", Priority = 5)]
        public string City { get; set; }

        [ModelPropertyLabel(Label = "PostalCode", Priority = 6)]
        public string PostalCode { get; set; }

        [ModelPropertyLabel(Label = "Street", Priority = 7)]
        public int Street { get; set; }

        [ModelPropertyLabel(Label = "HouseNumber", Priority = 8)]
        public char HouseNumber { get; set; }

    }
}

