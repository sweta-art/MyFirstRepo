using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace threeemonthCsharp
{
    internal class Arrays
    {
        public void OneDArray()
        {
            Console.WriteLine("Enter 3 names");
            string[] array = new string[3];
            for (int i = 0; i < array.Length; i++)
            {
                array[i]=Console.ReadLine();
            }
            foreach (string name in array)
            {
                Console.WriteLine($"Names:{name}");
            }
        }

        public void Eyenlist()
        {
            Console.WriteLine("Enter dgits");
            List<int> names = new List<int>();
            int counts = int.Parse(Console.ReadLine());
            for (int i = 0; i < counts; i++)
            {
                Console.WriteLine($"Enter counts:{i+1}:");
                int j = int.Parse(Console.ReadLine());
                names.Add(j);
            }

            foreach (int digit in names)
            {
                if (digit%2==0)
                    Console.WriteLine($"Even digit:{digit}");
            }
        }
        public void Average()
        {
            Console.WriteLine("Enter digit");
            List<int> average = new List<int>();
            int count = int.Parse(Console.ReadLine());
            int aver = 0; int sum = 0;
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"number are:{i+1}:");
                int j = int.Parse(Console.ReadLine());
                average.Add(j);
            }
            foreach (int digit in average)
            {
                sum = digit+sum;
            }
            aver=sum/count;
            Console.WriteLine($"Average:{aver}");
        }

        public void ReplaceElement()
        {
            Console.WriteLine("Enter 4 digit:");
            int[] arrays = new int[4];
            for (int i = 0; i < arrays.Length; i++)
            {
                arrays[i]=int.Parse(Console.ReadLine());
            }
            Console.Write("Old Array:");
            foreach (int array in arrays)
            {
                Console.Write($"{array},");
            }
            Console.WriteLine();
            Console.WriteLine("Choose replacement index(0 to 3):");
            int index = int.Parse(Console.ReadLine());
            if (index < 0 || index >= arrays.Length)
            {
                Console.WriteLine("Invalid index! Please choose between 0 and 3.");
                return;
            }
            Console.WriteLine("Enter new value:");
            int newvalue = int.Parse(Console.ReadLine());
            arrays[index]=newvalue;
            Console.WriteLine($"new values are:");
            foreach (int array in arrays)
            {
                Console.Write($"{array},");
            }
        }
        public void Student()
        {
            int[,] matrix = new int[3, 4];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Enter the marks of students:{i+1}:");
                for (int j = 0; j < 4; j++)
                {
                    Console.Write($"Subject;{j+1}: ");
                    matrix[i, j]=int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < 3; i++)
            {
                double marks = 0;
                for (int j = 0; j < 4; j++)
                {
                    marks=marks+matrix[i, j];
                }
                Console.WriteLine($"Marks of student:{i+1}=total:{marks}");
            }

        }
        public void JaggedMonths()
        {
            int[][] months = new int[4][];
            months[0]=new int[28];
            months[1]=new int[29];
            months[2]=new int[30];
            months[3]=new int[31];
            for (int i = 0; i<months.Length; i++)
            {
                for (int j = 0; j<months[i].Length; j++)
                {
                    months[i][j]=j+1;
                }
            }
            Console.WriteLine("Jagged array from (28 to 31):");
            for (int i = 0; i<months.Length; i++)
            {
                Console.Write($"\nMonth type with {months[i].Length} days:");
                foreach (int days in months[i])
                {
                    Console.Write(days);
                }
            }
        }
        public void Transpose()
        {
            int[,] matrix = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"3*3 matrix:");
                    matrix[i, j]=int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("matrix are");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrix[i, j] + "\t");

                }
                Console.ReadLine();
            }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("transpose matrix are");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrix[j, i] + "\t");

                }
                Console.ReadLine();
            }
        }


        public void SumItem()
        {
            List<int> lists = new List<int>();
            Console.WriteLine("Enter the count of list:");
            int counts = int.Parse(Console.ReadLine());
            for (int i = 0; i<counts; i++)
            {
                Console.WriteLine($"Enter List items of :{i+1}:");
                int item = int.Parse(Console.ReadLine());
                lists.Add(item);
            }
            int sum = 0;
            foreach (int i in lists)
            {
                sum=sum+i;
            }
            Console.WriteLine($"Sum of items:{sum}");
        }
        public void countryname()
        {
            List<string> countryname= new List<string>();
            Console.WriteLine("Eneter the 5 country names");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Country name of :{i+1}:");
                string name= Console.ReadLine();
                countryname.Add(name);
            }
            var sortedcountry = countryname.OrderBy(x =>x);
            foreach (string name in sortedcountry)
            {
                Console.WriteLine($"Country name:{name}");
            }
        }
        public void Studentlist()
        {
            List<Student> students = new List<Student>();
            Console.WriteLine("Enter the students counts:");
            int counts=int.Parse(Console.ReadLine());
            for (int i = 0; i < counts; i++)
            {
                Console.WriteLine($"\nEnter details for Student {i + 1}:");

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Age: ");
                int age = int.Parse(Console.ReadLine());

                students.Add(new Student { Name = name, Age = age });
            }
            var studentlist= students.Where(s => s.Age >18).ToList();
            foreach (var student in studentlist)
            {
                Console.WriteLine($"name of student which age is greater then 18:{student.Name} and age:{student.Age}");
            }
        }
        public void Students()
        {
            List<string> studnelist= new List<string>();
            string input;
            while(true)
            {
                Console.WriteLine("Enter name:");
                input= Console.ReadLine();
                if (input.ToLower()=="stop")
                {
                    break;
                    
                }
                studnelist.Add(input);
            }
            foreach (var item in studnelist)
            {
                Console.WriteLine(item);
            }
        }
        public void DisplayInfo(string name)
        {
            Console.WriteLine($"Name:{name}");
        }

        public void ShowCarInfo(string brand,string model,string year)
        {
            Console.WriteLine($"Brand:{brand},model:{model},year:{year}");
        }

    }
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
    }
}
