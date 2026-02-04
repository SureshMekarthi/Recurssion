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
            // Print(n);
           int resul = Fac(n);
            Console.WriteLine(resul);

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
        static void Print1(int n)
        {
            if (n == 0)
            {
                return;
            }

            Print1(n - 1);
            Console.WriteLine(n);
        }

        static int Sum(int n) {
            if (n == 0) 
            { return 0; }
            return n+Sum(n-1);
        }

        static int Fac(int n)
        {
            if (n == 1 || n == 0)
                return 1;

            return n * Fac(n - 1);
        }
    }
}
