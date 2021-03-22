using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CSharp_BasicReview
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public char Gender { get; set; }
        public DateTime DOB { get; set; }
        public string PhoneNumber { get; set; }
        public string BirthPlace { get; set; }

        public Person(
            string firstName,
            string lastName,
            char gender,
            DateTime dob,
            string phoneNumber,
            string birthPlace)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Gender = gender;
            this.DOB = dob;
            this.PhoneNumber = phoneNumber;
            this.BirthPlace = birthPlace;
        }
    }
}