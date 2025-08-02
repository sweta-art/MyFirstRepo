using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace threeemonthCsharp
{
    public delegate void MathOperation(int a, int b);

    public class Delegate
    {
        public void Add(int a, int b)
        {
            int sum = a+b;
            Console.WriteLine($"Addition:{sum}");
        }
        public void Sub(int a, int b)
        {
            if (b>a)
            {
                Console.WriteLine($"{b} cant be greater than {a}");
            }
            int sum = a-b;
            Console.WriteLine($"Subtraction:{sum}");
        }
        public void Mul(int a, int b)
        {
            int sum = a*b;
            Console.WriteLine($"Multiplication:{sum}");
        }
        public void Div(int a, int b)
        {
            try
            {
                int sum = a/b;
                if (b==0)
                {
                    throw new DivideByZeroException();
                }
                Console.WriteLine($"Division:{sum}");
            }
            catch (Exception ex) {
                Console.WriteLine($"Exception:{ex.Message}");
            }
        }

    }

    public class NewsAgency
    {
        public delegate void AlarmEventHandler();
        public event AlarmEventHandler NewsPublished;
        public void PublishNews(string news)
        {

        }
    }
}
