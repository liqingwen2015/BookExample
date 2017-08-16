#region

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using _08过滤器.Criteria;

#endregion

namespace _08过滤器
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var persons = new List<Person>
            {
                new Person("Robert", "Male", "Single"),
                new Person("John", "Male", "Married"),
                new Person("Laura", "Female", "Married"),
                new Person("Diana", "Female", "Single"),
                new Person("Mike", "Male", "Single"),
                new Person("Bobby", "Male", "Single")
            };

            var male = new CriteriaMale();
            var female = new CriteriaFemale();
            var single = new CriteriaSingle();
            var singleMale = new AndCriteria(single, male);
            var singleOrFemale = new OrCriteria(single, female);

            Console.WriteLine("Males:");
            PrintPerons(male.MeetCriteria(persons));
            Console.WriteLine();

            Console.WriteLine("Females:");
            PrintPerons(female.MeetCriteria(persons));
            Console.WriteLine();

            Console.WriteLine("Single Males:");
            PrintPerons(singleMale.MeetCriteria(persons));
            Console.WriteLine();

            Console.WriteLine("Single Or Females:");
            PrintPerons(singleOrFemale.MeetCriteria(persons));

            Console.Read();
        }

        private static void PrintPerons(IEnumerable<Person> persons)
        {
            foreach (var person in persons)
                Console.WriteLine(JsonConvert.SerializeObject(person));
        }
    }
}