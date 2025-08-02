using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace threeemonthCsharp
{
    internal class Linq
    {
        List<Students> stud = new List<Students>()
{
    new Students { ID = 1, Name = "Sweta", Marks = 85, City = "Patna" },
    new Students { ID = 2, Name = "Amit", Marks = 45, City = "Delhi" },
    new Students { ID = 3, Name = "Priya", Marks = 67, City = "Patna" },
    new Students { ID = 4, Name = "John", Marks = 90, City = "Mumbai" },
    new Students { ID = 5, Name = "Sara", Marks = 33, City = "Delhi" },
    new Students { ID = 6, Name = "Rahul", Marks = 75, City = "Mumbai" }
};
        public void StudName()
        {
            var studentname = stud.Where(s => s.City=="Patna" && s.Marks>60).Select(s => s.Name).OrderBy(name => name);
            foreach (var student in studentname)
            {
                Console.WriteLine(student);
            }
        }
        public void AverageMark()
        {
            var avrstud = stud.GroupBy(s => s.City).Select(g => new { city = g.Key, averagemark = g.Average(s => s.Marks) });
            foreach (var s in avrstud)
            {
                Console.WriteLine($"{s.city}-{s.averagemark}");
            }
        }
        public void highestmark()
        {
            var secondhigh = stud.OrderByDescending(s => s.Marks).Skip(1).FirstOrDefault();
            Console.WriteLine($"second highest:{secondhigh.Name}-{secondhigh.Marks}");
        }

        public void Lowestmark()
        {
            var lowestmarks = stud.GroupBy(s => s.City).Select(g => g.OrderBy(s => s.Marks).First());
            foreach (var s in lowestmarks)
            {
                Console.WriteLine($"lowestmarks:{s.Name}-{s.Marks}");
            }
        }
        public void Countstudent()
        {
            var countstud = stud.GroupBy(s => s.City).Select(g => new { city = g.Key, stud = g.Count() });
            foreach (var s in countstud)
            {
                Console.WriteLine($"Countstudent:{s.city}-{s.stud}");
            }
        }
        public void Mark()
        {
            var countstud = stud.Where(s => s.Marks<50).Select(g => g.Name.ToUpper());

            foreach (var s in countstud)
            {
                Console.WriteLine($"Name:{s}");
            }
           

        }
        public void Letter()
        {
            var countstud = stud.Where(s=>s.Name.ToLower().Contains('a')).Select(g => g.Name);

            foreach (var s in countstud)
            {
                Console.WriteLine($"Name:{s}");
            }


        }
        public void Highmark()
        {
            var hishmarks = stud.GroupBy(s => s.City).Select(g => g.OrderByDescending(s => s.Marks).First());
            foreach (var s in hishmarks)
            {
                Console.WriteLine($"highmark:{s.Name}-{s.Marks}");
            }
        }
    }
    public class Students
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Marks { get; set; }
        public string City { get; set; }
    }

}

