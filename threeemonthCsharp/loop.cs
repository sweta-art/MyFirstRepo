using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace threeemonthCsharp
{
    internal class loop
    {
        public void EvenNumber()
        {
            int i = 1;
            while (i<=20)
            {
                if (i%2==0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
        }

        public void SumNumb(int a)
        {
            int i = 0;
            while (i<a)
            {
                i++;
            }
            Console.WriteLine($"sum is:{i}");
        }

        public void correctPassword(string pass)
        {
            while (pass!="Hello")
            {
                Console.WriteLine("incorrect password,enter right password");
                pass=Console.ReadLine();
            }
            Console.WriteLine("Correct password");
        }

        public void Reverse()
        {
            Console.WriteLine("Enter number");
            int number = int.Parse(Console.ReadLine());
            int reversed = 0;
            while (number>0)
            {
                int digit = number%10;
                reversed=reversed*10+digit;
                number= number/10;
            }
            Console.WriteLine("reverse number is:"+reversed);
        }
        public void OddNumber()
        {
            for (int i = 1; i<15; i+=2)
            {
                Console.WriteLine($"Number is:{i}");

            }
        }
        public void Multiplication()
        {
            Console.WriteLine("Enter number:");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i<=10; i++)
            {
                Console.WriteLine($"multiplication {i}*{num}:{i*num}");
            }
        }
        public void sumofnumb()
        {
            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                sum=sum+i;
            }
            Console.WriteLine($"sum of number:{sum}");

        }
        public void ReverseFor()
        {
            Console.WriteLine("Enter the number:");
            int num = int.Parse(Console.ReadLine());
            int reverse = 0;
            for(int i = 0;i<=num; i++)
            {
                int digit = num%10;
                reverse = reverse*10+digit;
                num= num/10;
            }
            Console.WriteLine($"reverse num:{reverse}");
        }

        public void Factorialnum()
        {
            Console.WriteLine("Enter the number:");
            int num = int.Parse(Console.ReadLine());
            long fact = 1;
            for (int i = 1; i<=num; i++)
            {
                fact=fact*i;   
            }
            Console.WriteLine($"Factorial num:{fact}");


        }
        public void Stringname()
        {
            string[] names = { "Sweta","Richa","Abhay"};
            foreach(string name in names)
            {
                Console.WriteLine($"Hello,{name}");
            }
        }

        public void Evennumb()
        {
            List<int> numbers = new List<int> { 12,4,1,5,22,67,11,89,12};

            foreach (int number in numbers)
            {
                if(number%2==0)
                {
                    Console.WriteLine($"even number:{number}");
                }
            }
        }

        public void PrintChar()
        {
            char[] chars = { 'S','W','E','T','A' };

            foreach (char charname in chars)
            {
                Console.WriteLine($"Name is:{charname}");
            }
        }
        public void PrintCountry()
        {
            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>()
           {
                { "India","NewDelhi" },
                { "America","Washington" },
                { "France","Paris" },

           };
            foreach(KeyValuePair<string,string> keyvalue in keyValuePairs )
            {
                Console.WriteLine($"The capital of {keyvalue.Key} is {keyvalue.Value}.");
            }
        }
        public void SquareNumb()
        {
            int[] numbers = { 5, 10, 15, 20, 25 };
            foreach (int number in numbers)
            {
                Console.WriteLine($"Square of{number}:{number*number}");
            }
        }
        public void Addednumber()
        {
            int[] numbers = { 5, 10, 15, 20, 25 };
           for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i]=numbers[i]+5;
            }
            Console.Write($"Updated number:");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i]);
                if (i < numbers.Length-1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }
        public void AddednumberList()
        {
            List<int> numbers = new List<int>{ 5, 10, 15, 20, 25 };
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i]=numbers[i]*2;
            }
            Console.Write($"Updated number:");

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.Write(numbers[i]);
                if (i < numbers.Count-1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }

        public void Printnumb()
        {
            List<int> numbers = new List<int> { 5, 10, 15, 20, 25 };
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i]=numbers[i]+3;
            }
            Console.Write($"Updated number:");

            List<int> filteted = numbers.Where(x => x > 20).ToList();
            for (int i = 0; i < filteted.Count; i++)
            {
                
                    Console.Write(filteted[i]);
                    if (i < filteted.Count-1)
                    {
                        Console.Write(", ");
                    }
                
            }
            Console.WriteLine();
        }


    }
}
