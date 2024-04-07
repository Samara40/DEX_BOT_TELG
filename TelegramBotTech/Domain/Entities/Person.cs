using Domain.FluentValidator;
using Domain.Primitives;
using Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace Domain.Entities
{
    public class Person : BaseEntity
    {

        public Person(FullName fullName)
        {
            var fullnameValodator = new FullnameValodator();
            fullnameValodator.Validate(fullName);
            FullName = fullName;
        }
        public FullName FullName { get; set; }

        public DateTime BirthDay { get; set; }

        public int Age => DateTime.Now.Year - BirthDay.Year;

        public string PhoneNumber { get; set; }

        public string Telegram { get; set; }
        public List<CustomField<string>> CustomFields { get; set; }

        private string ValidatePhoneNumber(string phoneNumber)
        {
            var regex = new Regex(pattern: @"A\+37377 [4-9]\d{5}$");
            if (string.IsNullOrEmpty(phoneNumber) || !regex.IsMatch(phoneNumber))
            {
                throw new ValidationException();
            }
            return phoneNumber;
        }
        private DateTime ValidateBirthDay(DateTime birthDay)
        {

            if (birthDay > DateTime.Now || birthDay < DateTime.Now.AddYears(-150))

            {
                throw new ValidationException();
            }

            return birthDay;
        }

        private string ValidateTelegram(string telegram)
        {
            if (string.IsNullOrEmpty(telegram) || !telegram.StartsWith("@"))
            {
                throw new ValidationException();

            }
            return telegram;
        }


    }
}
