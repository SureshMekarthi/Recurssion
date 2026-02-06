using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Recurssion
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int n = 9;
            Console.WriteLine(Power(2,n));


            Console.ReadLine();
        }

       static int xpowern(int x, int n)
        {
            if(n==0) return 1;
            if(x==0) return 0;

            return x * xpowern(x, n - 1);
        }

        static int xpowern2(int x, int n)
        {
            if (n==0)
            {
                return 1;
            }
            if(x==0) return 0;
            if (n % 2 == 0)
            {

                return xpowern2(x, n / 2) * xpowern2(x, n / 2);
            }
            else
            {
                return x* xpowern2(x, n / 2) * xpowern2(x, n / 2);
            }

        }

        static int Power(int x, int n)
        {
            if (n == 0) return 1;
            if (x == 0) return 0;

            int half = Power(x, n / 2);

            if (n % 2 == 0)
                return half * half;
            else
                return x * half * half;
        }










    }
}

       