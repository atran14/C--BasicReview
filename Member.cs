using System;
using System.Text;

namespace CSharp_BasicReview {
    public class Member : Person
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public Member(
            string firstName,
            string lastName,
            char gender,
            DateTime dob,
            string phoneNumber,
            string birthPlace,
            DateTime startDate,
            DateTime endDate) : base(firstName, lastName, gender, dob, phoneNumber, birthPlace)
        {
            this.StartDate = startDate;
            this.EndDate = endDate;
        }
        
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("Member:{");
            return sb
                .AppendFormat("firstName={0},", this.FirstName)
                .AppendFormat("lastName={0},", this.LastName)
                .AppendFormat("gender={0},", this.Gender)
                .AppendFormat("dob={0},", this.DOB.ToShortDateString())
                .AppendFormat("phoneNumber={0},", this.PhoneNumber)
                .AppendFormat("birthPlace={0},", this.BirthPlace)
                .AppendFormat("startDate={0},", this.StartDate.ToShortDateString())
                .AppendFormat("endDate={0}", this.EndDate.ToShortDateString())
                .Append("}")
                .ToString();
        }
    }
}