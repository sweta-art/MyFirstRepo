using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace threeemonthCsharp
{
    //internal class Polymorphism
    //{
    //}
    public class Shape
    {
        public void area(int side)
        {
            int square = side*side;
            Console.WriteLine($"square:{square}");
        }
        public void area(int l,int b)
        {
            int rec = l*b;
            Console.WriteLine($"Rectangle:{rec}");

        }
        public void area(float a)
        {
            float radius = a*3.14f;
            Console.WriteLine($"Radus:{radius}");


        }
        
    }
    public class Vehicle
    {
        public virtual void drive()
        {
            Console.WriteLine("Virtual base class");
        }
        
    }
    public  class Bus: Vehicle
    {
        public override void drive()
        {
            Console.WriteLine("Bus");
        }
    }
    public class Truck : Vehicle {
        public override void drive()
        {
            Console.WriteLine("Truck");
        }

    }

}
