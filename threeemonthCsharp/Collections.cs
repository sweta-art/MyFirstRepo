using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace threeemonthCsharp
{
    public class Collections
    {
        List<string> colors=new List<string>();
        public void color()
        {
            Console.WriteLine("Enter color count:");
            int a=int.Parse(Console.ReadLine());
            for (int i = 0; i<a; i++)
            {
                string color=Console.ReadLine();
                colors.Add(color);
            }
            foreach (string color in colors)
            {
                Console.WriteLine($"colors are:{color}");
            }
        }
        public void rollnumber()
        {

            Dictionary<int,string> keyValuePairs = new Dictionary<int,string>();
            Console.WriteLine("enter the roll number count:");
            int a= int.Parse(Console.ReadLine());
            for (int i = 0;i<a; i++)
            {
                Console.WriteLine($"Roll number and student name of:{i+1} student");
                string name = Console.ReadLine();
                keyValuePairs.Add(i+1,name);
            }
            Console.WriteLine("rollnumber and student name:");
            foreach(KeyValuePair<int,string> value in keyValuePairs)
            {
                Console.WriteLine($"roll number:{value.Key}.:{value.Value} ");
            }
            
        }
        public void ticketcounter()
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("sweta");
            queue.Enqueue("richa");
            queue.Enqueue("abhay");
            for(int i=-1;i<=queue.Count;i++)
            {
                Console.WriteLine(queue.Dequeue());

            }
        }
        public void booktitle()
        {
            Stack<string> book = new Stack<string>();
            book.Push("Ekigai");
            book.Push("Harry potter");
            book.Push("Alchemisht");
            Console.WriteLine($"Top book title before pop::{book.Peek()}");
            string poptitle = book.Pop();
            Console.WriteLine($"Popped book title::{poptitle}");
            Console.WriteLine($"First booktitle was:{book.Peek()}");

        }

     }
}
