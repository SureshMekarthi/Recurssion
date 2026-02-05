using System;
using System.Collections.Generic;
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
           
            int n = 5;

           int result = Feb2(n);
            Console.WriteLine(result);
            int a = 0; int  b =1;
            Console.WriteLine(a+" " +b);

            for (int i =2; i<=n; i++)
            {
                int c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
            }

            Feb(a, b, n);

            Console.ReadLine();
        }

        static int Sum(int n)
        {
            if(n == 0) return 0;

            return n + Sum(n - 1);
        }

        static int Sum1(int n, int i)
        {
            if (i > n)
                return 0;

            return i + Sum1(n, i + 1);
        }

        static void Sum2(int n, int i, int sum)
        {
            if (i == n)
            {
                sum = sum + i;
                Console.WriteLine(sum);
                return;
            }
            sum = sum + i;
            Sum2(n, i + 1, sum);
            Console.WriteLine(i);
        }

        static int Fac(int n)
        {
            if(n==1||n==0) return 1;

            return n * Fac(n - 1);
        }

        static void Feb(int a, int b, int n)
        {
            if (n==1||n==0) return; 

            int c = a + b;
            Console.WriteLine(c);
            Feb(b, c, n - 1);
        }

        static int Feb2(int n)
        {
            if(n==0||n==1)
                return n;

            return Feb2(n - 1) + Feb2(n - 2);
        }


        
    }
}

       