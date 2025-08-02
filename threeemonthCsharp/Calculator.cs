using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace threeemonthCsharp
{
    internal class Calculator
    {
        public void Cal()
        {
            while (true)
            
            {
                Console.WriteLine("Enter your choice:");
                Console.WriteLine("1* Add \n 2* Sub \n 3* Mul \n 4* Div \n 5* Exit");
                //int choice=int.Parse(Console.ReadLine());
                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Enter valid choice");
                    continue;
                }
                if (choice == 5)
                    break;
                Console.WriteLine("Enter 2 values");
                if (!int.TryParse(Console.ReadLine(), out int a)||(!int.TryParse(Console.ReadLine(), out int b)))
                {
                    Console.WriteLine("Enter valid inputs");
                    continue;
                }
               
                switch (choice)
                {
                    case 1: Console.WriteLine($"Sum of number :{a} and {b}:{a+b}"); break;
                    case 2: Console.WriteLine($"Sub of number :{a} and {b}:{a-b}"); break;
                    case 3: Console.WriteLine($"Mul of number :{a} and {b}:{a*b}"); break;
                    case 4:
                        if (b!=0)
                        {
                            Console.WriteLine($"Div of number :{a} and {b}:{a/b}"); break;
                        }
                        else
                        {
                            Console.WriteLine($"can not divide by 0"); break;
                        }
                    default:
                        Console.WriteLine("wrong choice");

                        break;

                }
            }

        }
    }
}
