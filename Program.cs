using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinaryTree.Calc;

namespace BinaryTree
{
    class Program
    {
        public static void Main()
        {
            bool x = true;
            do
            {

                Console.Write("Enter command =>");
                switch (Console.ReadLine())
                {
                    case "Default":
                    case "default":
                        string ex = "true||((true&&false)||not true)";
                        Console.WriteLine($"{ex}={new Expression(ex).Evaluate()}");
                        break;
                    case "Help":
                    case "help":
                    default:
                        Console.WriteLine("default - Example expression");
                        Console.WriteLine("help - all commands");
                        Console.WriteLine("start - input your expression");
                        Console.WriteLine("exit - close program");
                        break;
                    case "Start":
                    case "start":
                        Console.Write("Enter your expression =>");
                        string solve = Console.ReadLine();
                        Console.WriteLine($"{solve}={new Expression(solve).Evaluate()}");
                        break;
                    case "Exit":
                    case "exit":
                        x = !x;
                        break;
                }
                Console.Write("Press any key..");
                Console.ReadKey();
                Console.Clear();
            } while (x);
        }

    }
}
