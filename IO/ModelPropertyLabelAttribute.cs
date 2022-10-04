using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRegister_K63_2022.IO
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ModelPropertyLabelAttribute: Attribute
    {
        public string Label { get; set; }
        public int Priority { get; set; }
    }
}
