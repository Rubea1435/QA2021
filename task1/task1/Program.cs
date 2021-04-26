using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            exeTask Run = new exeTask();
            Run.task1();
            Console.ResetColor();
            Run.task2();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Run.task3();
            Console.ResetColor();
        }
    }
}
