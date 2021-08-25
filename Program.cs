using System;
using System.Collections.Generic;

namespace LearnRecords
{
    class Program
    {
        public record Person(string FirstName, string LastName)
        {
            public string[] PhoneNumbers { get; init; }
        }

        public List<Person> People {get;set;} = new List<Person>();


        public static void Main()
        {

            
              //SSRSReports.ReportListValue.RemoveAll(e => e.Hidden == true);
            
            
            string dog = "5";
            string cat = "7";

            Console.WriteLine(dog == cat); // output: ?
            Console.WriteLine(ReferenceEquals(dog, cat)); // output: ?

            //People 

            Person person1 = new("Nancy", "Davolio") { PhoneNumbers = new string[1] };
            Console.WriteLine(person1);
            // output: Person { FirstName = Nancy, LastName = Davolio, PhoneNumbers = System.String[] }

            Person person2 = person1 with { FirstName = "John" };
            Console.WriteLine(person2);
            // output: Person { FirstName = John, LastName = Davolio, PhoneNumbers = System.String[] }
            Console.WriteLine(person1 == person2); // output: False

            person2 = person1 with { PhoneNumbers = new string[1] };
            Console.WriteLine(person2);
            // output: Person { FirstName = Nancy, LastName = Davolio, PhoneNumbers = System.String[] }
            Console.WriteLine(person1 == person2); // output: False

            person2 = person1 with { };
            Console.WriteLine(person1 == person2); // output: True
        }
    }
}
