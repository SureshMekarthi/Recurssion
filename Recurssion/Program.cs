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
           
            int n = 1824;
            Console.WriteLine(ReverseNum(n));


            Console.ReadLine();
        }

       

        static int ReverseNum(int n)
        {
             int result = 0;
            while (n > 0)
            {
                result = result * 10;
                result = (n % 10) + result;
              
                n = n / 10;
            }
            return result;
        }

       

        
    }
}

       