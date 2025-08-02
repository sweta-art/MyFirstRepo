using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace threeemonthCsharp
{
    public class InputOutputFile
    {
        public void InputOutputFiles()
        {
            try
            {
                Console.WriteLine("Enter name:");
                string name = Console.ReadLine();
                string msg = $"Hello, {name}! Welcome to File I/O";
                string filepath = "D:\\C_sharp\\threeemonthCsharp\\threeemonthCsharp\\Log\\greeting.txt";
                File.WriteAllText(filepath, msg);
                Console.WriteLine("Msg written");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception:{ex.Message}");
            }
        }
        public void ReadFile()
        {
            try
            {
                string filepath = "D:\\C_sharp\\threeemonthCsharp\\threeemonthCsharp\\Log\\greeting.txt";
                if (File.Exists(filepath))
                {
                    string msg = File.ReadAllText(filepath);
                    Console.WriteLine($"message is:{msg}");
                }
                else
                {
                    Console.WriteLine($"file not found");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception:{ex.Message}");

            }
        }
        public void CommentReadWrite()
        {
            try
            {
                Console.WriteLine("Enter message");
                string msg = "";
                string filepath = "D:\\C_sharp\\threeemonthCsharp\\threeemonthCsharp\\Log\\greeting.txt";
                while (true)
                {
                    msg=Console.ReadLine();
                    if (msg.Equals("Exit",StringComparison.OrdinalIgnoreCase))
                    {
                        break;
                    }
                    File.AppendAllText(filepath, msg+Environment.NewLine);                 
                }
                string message = File.ReadAllText(filepath);
                Console.WriteLine($"Message:{message}");
            }
            catch (Exception ex) { Console.WriteLine($"Exception:{ex.Message}"); }
        }
    }
}
