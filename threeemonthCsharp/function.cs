using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace threeemonthCsharp
{
    internal class function
    {
        public void welcome(string name)
        {
            Console.WriteLine($"Hello,{name}");
        }
        public void Multiply(int a, int b)
        {
            int multi = a*b;
            Console.WriteLine($"Multiplication of:{multi}");
        }
        public void UseParams(params int[] num)
        {
            int sum = 0;
            for (int i = 0; i < num.Length; i++)
            {
                sum+=num[i];
            }
            Console.WriteLine($"Added numbers:{sum}");
        }

        public int cubenum(int a)
        {
            return a*a*a;
        }
        public string GetStatus(int marks)
        {
            if (marks >40) return "pass";
            else
                return "fail";
        }
        public bool Evennumber(int num)
        {
            if (num % 2==0) return true;
            else
                return false;
        }
        public void Greet()
        {
            Console.WriteLine("Hello");
        }
        public string Greet(string name)
        {
            return name;
        }
        public int Multiplication(int a, int b)
        {
            return a*b;
        }
        public double Multiplication(double a, double b)
        {
            return a*b;
        }
        public string DisplayInfo(string name)
        {
            return name;
        }
        public void DisplayInfo(string name, int age)
        {
            Console.WriteLine($"name:{name},age:{age}");
        }
        public void DisplayInfo(int age, string name)
        {
            Console.WriteLine($"name:{name},age:{age}");
        }
    }
}
