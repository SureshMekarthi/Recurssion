using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recurssion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //print numbers from 5 to 1
            int n = 5;
            Print(n);
            Console.ReadLine();
        }

        static void Print(int n) 
        { 
            if((n<=0))
            {
                return;
            }
            Console.WriteLine(n);
            Print(n - 1);
        }
    }
}
