using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
namespace ArithmeticDemo
{
    class Program
    {
        [DllImport(@"NativeOps.dll")]
        //static extern int MyProc1(int a, int b, int c, int d, int e);
        //static extern long MyProc1(long a, long b); // for the OV flag
        //static extern ulong MyProc1(ulong a, ulong b); // for the CY flag
        static extern int MyProc1(int a, int b); // PL, ZR, PE flags


        static void Main(string[] args)
        {
            // adding more than 4 variables
            //int a = 2, b = 1, c = 3, d = 7, e = 10;
            //int retVal = MyProc1(a,b,c,d,e);

            //long a = long.MaxValue, b = 1; // OV flag
            //long retVal = MyProc1(a, b);

            //ulong a = ulong.MaxValue, b = 1; // CY flag
            //ulong retVal = MyProc1(a, b);

            //int a = 2, b = -4; // PL flag
            //int a = 3, b = -3; // ZR flag
            int a = 3, b = 3; // PE flag
            int retVal = MyProc1(a, b); // PL, ZR, PE flags


            Console.Write("My first value calculated in assembly is:");
            Console.WriteLine(retVal);
        }
    }
}