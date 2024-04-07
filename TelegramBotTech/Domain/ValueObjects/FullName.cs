using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ValueObjects
{
    public class FullName : BaseValueObject
    {
        
            public FullName(string firstName, string lastName, string? middleName)
            {
                FirstName = firstName;
                LastName = lastName;
                MiddleName = middleName;
            }

            public string FirstName { get; set; }

            public string LastName { get; set; }

            /// <summary>
            /// Может быть отчетством
            /// </summary>
            public string? MiddleName { get; set; }

            public bool DeepCompare(FullName other)
            {
                return other != null && GetType().GetProperties().All(property => Equals(property.GetValue(this), property.GetValue(other)));
            }

            public FullName DeepClone()
            {
                return new FullName(FirstName, LastName, MiddleName);
            }
        }
    }


