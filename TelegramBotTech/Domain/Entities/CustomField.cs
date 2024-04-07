using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class CustomField<TType>:BaseEntity
    {
        public string Name { get; set; }
        public TType Value { get; set; }
    }
}
