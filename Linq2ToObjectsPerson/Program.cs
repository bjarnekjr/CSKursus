using System;
using System.Linq;

namespace Linq2ToObjectsPerson
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = MCronberg.PersonRepositoryStatic.JustGetPeople();
            //foreach (var person in people)
            //    Console.WriteLine(person.Name);
            //var res = people.OrderBy(i => i.Name);
            //foreach (var pers in res)
            //    Console.WriteLine(pers.Name);
            //var res1 = people.OrderBy(i => i.Gender).ThenBy(i => i.Name);
            //foreach (var pers in res1)
            //    Console.WriteLine(pers.Gender + " " + pers.Name);
            //var res2 = people.Where(i => i.Height < 170);
            //foreach (var pers in res2)
            //    Console.WriteLine(pers.Height + " " + pers.Name);
            //var res3 = people.Where(i => i.Height <= 170 && i.IsHealthy);
            //foreach (var pers in res3)
            //    Console.WriteLine(pers.Height + " " + pers.Name + " " + pers.IsHealthy);
            //var res4 = people.GroupBy(i => i.Gender);
            //foreach (var group in res4)
            //{
            //    Console.WriteLine(group.Key);
            //    foreach (var person in group)
            //        Console.WriteLine("  => " + person.Name + " " + person.Gender);
            //}
            var res5 = people.OrderBy(i => i.Height).GroupBy(i => i.Height / 10);
            foreach (var group in res5)
            {
                Console.WriteLine(group.Key*10);
                foreach (var pers in group)
                    Console.WriteLine(pers.Height + " " + pers.Name);
            }
        }
    }
}
