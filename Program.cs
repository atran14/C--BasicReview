using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_BasicReview
{
    class Program
    {
        static void Main(string[] args)
        {

            var membersList = new List<Person>
            {
                new Member("Van A", "Nguyen", 'M', new DateTime(1997, 10, 8), "0961112222", "Hanoi", new DateTime(2019, 05, 05), new DateTime(2020, 01, 01))
                , new Member("Van B", "Tran", 'F', new DateTime(1989, 5, 25), "0982223333", "TP HCM", new DateTime(2017, 06, 30), new DateTime(2020, 02, 10))
                , new Member("Van C", "Dang", 'M', new DateTime(2001, 8, 17), "0763334444", "Thanh Hoa", new DateTime(2018, 06, 17), new DateTime(2019, 03, 30))
                , new Member("Van D", "Tran", 'F', new DateTime(1998, 5, 23), "0984445555", "Ninh Thuan", new DateTime(2017, 06, 30), new DateTime(2019, 12, 15))
            };

            Console.WriteLine("(1) List of male (M) members");
            var maleMembersList =
                from s in membersList
                where s.Gender == 'M'
                select s;
            foreach (Person p in maleMembersList)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine(new String('-', 30));

            Console.WriteLine("(2) The oldest member");
            var oldestMember = membersList
                                .OrderBy(s => s.DOB)
                                .FirstOrDefault();
            Console.WriteLine(oldestMember);
            Console.WriteLine(new String('-', 30));

            Console.WriteLine("(3) List of full names only");
            var nameOnlyList =
                from s in membersList
                select new { First = s.FirstName, Last = s.LastName };
            foreach (var nameObject in nameOnlyList)
            {
                Console.WriteLine($"{nameObject.Last} {nameObject.First}");
            }
            Console.WriteLine(new String('-', 30));

            Console.WriteLine("(4-1) List of members born in 1998");
            var membersBornIn1998List =
                from s in membersList
                where s.DOB.Year == 1998
                select s;
            foreach (var member in membersBornIn1998List)
            {
                Console.WriteLine(member);
            }
            Console.WriteLine(new String('-', 30));

            Console.WriteLine("(4-2) List of members born before 1998");
            var membersBornBefore1998List =
                from s in membersList
                where s.DOB.Year < 1998
                select s;
            foreach (var member in membersBornBefore1998List)
            {
                Console.WriteLine(member);
            }
            Console.WriteLine(new String('-', 30));

            Console.WriteLine("(4-1) List of members born after 1998");
            var membersBornAfter1998List =
                from s in membersList
                where s.DOB.Year > 1998
                select s;
            foreach (var member in membersBornAfter1998List)
            {
                Console.WriteLine(member);
            }
            Console.WriteLine(new String('-', 30));
        }
    }
}
