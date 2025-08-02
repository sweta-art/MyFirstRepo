using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace threeemonthCsharp
{
    public class stringhandling
    {
        public void replace()
        {
            string text = "Sweta is becoming a pro in Java and JavaScript";

            string rep = text.Replace("Java", "c#");
            string[] splitsen = rep.Split(' ');

            Console.WriteLine($"{string.Join("|", splitsen)}");
            
            Console.WriteLine(rep);
            Console.WriteLine($"Index of text:{rep.IndexOf("pro")}");

        }
    }
}
