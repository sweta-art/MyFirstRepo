using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace threeemonthCsharp
{
    public class UnderAgeException : Exception
    {
        public UnderAgeException(string message) : base(message) { }
    }
    public class validate
    {
        public void ValidateAge()
        {
            Console.WriteLine("Enter the age:");
            if (!int.TryParse(Console.ReadLine(), out int cage))
            {
                Console.WriteLine("Please enter valid age");
                return;
            }
            if (cage < 18)
            {
                throw new UnderAgeException("Age is below 18");
            }

            Console.WriteLine($"Age is valid:{cage}");
        }
        public void calculator()
        {
            try
            {
                Console.WriteLine($"Enter 2 numbers:");
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                if (b==0)
                {
                    Console.WriteLine("Can not divide by 0");
                    throw new DivideByZeroException();
                }
                int div = a/b;

                Console.WriteLine($"Division of numbers {a} and {b}:{div}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception:{ex.Message.ToString()}");
            }
            finally
            {
                Console.WriteLine("Operation Completed");
            }
        }

        public void Withdrw()
        {
            try
            {
                int bal = 5000;
                Console.WriteLine($"Enter amount:");
                int amoun = int.Parse(Console.ReadLine());
                if (bal<amoun)
                {
                    Console.WriteLine("insuff balance");
                    throw new InsufficientFundsException("Insufficient balance");
                }
                else
                {
                    Console.WriteLine($"remaining Balance:{bal-amoun}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception:{ex.ToString()}");
            }
        }
    }
    public class InsufficientFundsException : Exception
    {
        public InsufficientFundsException(string message) : base(message) { }
    }
}
