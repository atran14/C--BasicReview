using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_BasicReview
{
    class Program
    {

        private static DateTime MARCH_22ND_2021_DATE_TIME = new DateTime(2021, 3, 22);

        static void Main(string[] args)
        {

            var membersList = new List<Member>
            {
                new Member("Van A", "Nguyen", 'M', new DateTime(1997, 10, 8), "0961112222", "Ha Noi", new DateTime(2019, 05, 05), new DateTime(2020, 01, 01))
                , new Member("Van B", "Tran", 'F', new DateTime(1989, 5, 25), "0982223333", "TP HCM", new DateTime(2017, 06, 30), new DateTime(2020, 02, 10))
                , new Member("Van C", "Dang", 'M', new DateTime(2001, 8, 17), "0763334444", "Thanh Hoa", new DateTime(2018, 06, 17), new DateTime(2019, 03, 30))
                , new Member("Van D", "Tran", 'F', new DateTime(1998, 5, 23), "0984445555", "Ninh Thuan", new DateTime(2017, 06, 30), new DateTime(2019, 12, 15))
                , new Member("Van H", "Nguyen", 'M', new DateTime(2002, 10, 24), "0967891234", "Ha Noi", new DateTime(2019, 05, 05), new DateTime(2020, 01, 20))
            };

            int choice = -1;
            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("(1) Print list of male (M) members");
                Console.WriteLine("(2) Print the oldest member");
                Console.WriteLine("(3) Print list of full names only");
                Console.WriteLine("(4) Print list of members with certain birth year");
                Console.WriteLine("(5) Print first member born in Hanoi");
                Console.WriteLine("(6) Print list of members who joined class before March 22nd, 2021");
                Console.WriteLine("(7) Exit");
                Console.Write("Choice: ");

                choice = Int32.Parse(Console.ReadLine());
                Console.WriteLine(new String('-', 30));
                switch (choice)
                {
                    case 1:
                        PrintMaleMembers(membersList);
                        break;
                    case 2:
                        PrintOldestMember(membersList);
                        break;
                    case 3:
                        PrintFullNamesFromList(membersList);
                        break;
                    case 4:
                        PrintMembersWithCertainBirthDates(membersList);
                        break;
                    case 5:
                        PrintFirstMemberBornInHanoi(membersList);
                        break;
                    case 6:
                        PrintMembersJoinedClassBeforeMarch22(membersList);
                        break;
                    default:
                        break;
                }
                Console.WriteLine(new String('-', 30));

            } while (choice != 7);
        }

        private static void PrintMaleMembers(List<Member> membersList)
        {
            var maleMembersList =
                from s in membersList
                where s.Gender == 'M'
                select s;
            foreach (Person p in maleMembersList)
            {
                Console.WriteLine(p);
            }
        }

        private static void PrintOldestMember(List<Member> membersList)
        {
            var oldestMember = membersList
                                .OrderBy(s => s.DOB)
                                .FirstOrDefault();
            Console.WriteLine(oldestMember);
        }

        private static void PrintFullNamesFromList(List<Member> membersList)
        {
            var nameOnlyList =
                from s in membersList
                select new { First = s.FirstName, Last = s.LastName };
            foreach (var nameObject in nameOnlyList)
            {
                Console.WriteLine($"{nameObject.Last} {nameObject.First}");
            }
        }

        private static void PrintMembersWithCertainBirthDates(List<Member> membersList)
        {
            int choice = -1;
            Console.WriteLine("Select members born...");
            Console.WriteLine("(1) before 1998");
            Console.WriteLine("(2) in 1998");
            Console.WriteLine("(3) after 1998");
            Console.Write("Choice: ");

            choice = Int32.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    {
                        var queryResult =
                            from s in membersList
                            where s.DOB.Year < 1998
                            select s;

                        foreach (var member in queryResult)
                        {
                            Console.WriteLine(member);
                        }
                    }
                    break;
                case 2:
                    {
                        var queryResult =
                          from s in membersList
                          where s.DOB.Year == 1998
                          select s;

                        foreach (var member in queryResult)
                        {
                            Console.WriteLine(member);
                        }
                    }
                    break;
                case 3:
                    {
                        var queryResult =
                          from s in membersList
                          where s.DOB.Year > 1998
                          select s;

                        foreach (var member in queryResult)
                        {
                            Console.WriteLine(member);
                        }
                    }
                    break;
                default:
                    return;
            }
        }

        private static void PrintFirstMemberBornInHanoi(List<Member> membersList)
        {
            var firstPersonBornInHanoi =
                membersList
                .Where(s => s.BirthPlace == "Ha Noi")
                .FirstOrDefault();
            Console.WriteLine(firstPersonBornInHanoi);
        }

        private static void PrintMembersJoinedClassBeforeMarch22(List<Member> membersList)
        {
            var dateTimeTarget = new DateTime(2021, 3, 22);
            var membersJoinedBeforeList =
                membersList
                .Where(s => s.StartDate < dateTimeTarget);
            foreach (var person in membersJoinedBeforeList)
            {
                Console.WriteLine(person);
            }
        }
    }
}
