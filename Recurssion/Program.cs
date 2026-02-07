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

            int n = 3;
            TowerOfHanoiSolve(n, "src", "hlp", "dest");


            Console.ReadLine();
        }

        static int xpowern(int x, int n)
        {
            if (n == 0) return 1;
            if (x == 0) return 0;

            return x * xpowern(x, n - 1);
        }

        static int xpowern2(int x, int n)
        {
            if (n == 0)
            {
                return 1;
            }
            if (x == 0) return 0;
            if (n % 2 == 0)
            {

                return xpowern2(x, n / 2) * xpowern2(x, n / 2);
            }
            else
            {
                return x * xpowern2(x, n / 2) * xpowern2(x, n / 2);
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





        public static void TowerOfHanoiSolve(int n, string src, string helper, string dest)
        {
            // Base case: only one disk
            if (n == 1)
            {
                Console.WriteLine($"transfer disk {n} from {src} to {dest}");
                return;
            }

            // Step 1: Move top n-1 disks from src to helper using dest
            TowerOfHanoiSolve(n - 1, src, dest, helper);

            // Step 2: Move nth (largest) disk from src to dest
            Console.WriteLine($"transfer disk {n} from {src} to {dest}");

            // Step 3: Move n-1 disks from helper to dest using src
            TowerOfHanoiSolve(n - 1, helper, src, dest);
        }
    }
}










       