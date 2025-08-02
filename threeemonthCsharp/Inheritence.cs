using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace threeemonthCsharp
{
    //public class Inheritence
    //{
    //}
    public class vehicle
    {
        public string Brand { get; set; }
        public void Start()
        {
            Console.WriteLine($"vehicle:{Brand}");
        }

    }
    public class Cars :vehicle
    {
        public void Drive()
        {
            Console.WriteLine($"Drive:{Brand}");
        }
    }

    public class Device
    { 
    public void display()
        {
            Console.WriteLine($"Device");
        }
        public class Computer:Device
        {
            public void Boot()
            {
                Console.WriteLine($"Computer");

            }
        }
        public class Laptop:Computer
        {
            public void Openid()
            {
                Console.WriteLine($"Laptop");

            }
        }
        public class Person
        {
            public void Introduce()
            {
                Console.WriteLine($"Person:Introduce");
            }
        }
        public class Teacher:Person
        {
            public void Teach()
            {
                Console.WriteLine($"Teacher:Teach");
            }

        }
        public class Students : Person
        {
            public void Study()
            {
                Console.WriteLine($"Student:Study");
            }

        }
        public interface IWriter
        {
            void Write();
        }
        public interface IRead
        {
            void read();
        }
        public class Author:IWriter,IRead

        {
            public void Write()
            {
                Console.WriteLine("write");
            }
            public void read()
            {
                Console.WriteLine("read");
            }
        }

        public class Persons
        {
            public void Per()
            {
                Console.WriteLine("Persons");
            }

        }
        public interface ISpeaker
        {
            void Speak();
        }

        public class Employee:Persons
        {
            
            public void  Empl()
            {
                Console.WriteLine("Empl");
            }
        }
        public class Manager:Employee
        {
            public void Speak()
            {
                Console.WriteLine("Speak");
            }
            public void Manage()
            {
                Console.WriteLine("maNAGER");
            }
        }
    }

}
