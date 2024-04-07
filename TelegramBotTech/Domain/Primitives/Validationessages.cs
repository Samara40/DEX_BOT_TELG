using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Primitives
{
    public static class Validationessages
    {
        public static Func<string, string> NotNull { get; set; } =
        (propertyName)=>$"Свойство {propertyName} не может быть NULL";
        public static Func<string, string> NotEmpty { get; set; } =
       (propertyName) => $"Свойство {propertyName} не может быть пустым";
        public static Func<string, string> InvalidProperty { get; set; } =
       (propertyName) => $"Свойство {propertyName} Имеет недопустимые значения ";
    }
}
