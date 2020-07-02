using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    class Program
    {
        static void Main(string[] args)
        {
            Print(4);
        }

        static void Print(int height)
        {
            for (int i = 1; i <= height; i++)
            {
                Console.WriteLine(new string('*', i));
            }
        }
    }
}
