using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeRegister_K63_2022.IO
{
    public class CreateAnyModel<ModelType> where ModelType : new()
    {
        public ModelType Create()
        {
            var model = new ModelType();

            var labeledProperties = typeof(ModelType).GetProperties()
                                                     .Where(property => Attribute.IsDefined(property, typeof(ModelPropertyLabelAttribute)))
                                                     .OrderBy(property => (Attribute.GetCustomAttribute(property, typeof(ModelPropertyLabelAttribute)) as ModelPropertyLabelAttribute).Priority);

            foreach (var property in labeledProperties)
            {
                var attribute = (Attribute.GetCustomAttribute(property, typeof(ModelPropertyLabelAttribute)) as ModelPropertyLabelAttribute);
                while (true)
                {
                    Console.Write($"Pass value of the {attribute.Label} for new object {typeof(ModelType).Name}: ");
                    var stringValue = Console.ReadLine();
                    try
                    {
                        var value = Convert.ChangeType(stringValue, property.PropertyType);
                        property.SetValue(model, value);
                        break;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine($"Value passed to the property {attribute.Label} is not valid try again.");
                    }
                }
            }

            return model;
        }
    }
}
