using System;
using System.Runtime.InteropServices;

namespace SimdDemo
{
    class Program
    {
        const string DLL = @"NativeOps.dll";

        [DllImport(DLL)] static extern int CheckMMX();
        [DllImport(DLL)] static extern int CheckSSE();
        [DllImport(DLL)] static extern int CheckSSE2();
        [DllImport(DLL)] static extern int CheckSSE3();
        [DllImport(DLL)] static extern void my_SUB(byte[] a, byte[] b, byte[] c);
        [DllImport(DLL)] static extern void my_AND(byte[] a, byte[] b, byte[] c);
        [DllImport(DLL)] static extern void my_OR(byte[] a, byte[] b, byte[] c);
        [DllImport(DLL)] static extern void my_XOR(byte[] a, byte[] b, byte[] c);
        [DllImport(DLL)] static extern void my_MAX(byte[] a, byte[] b, byte[] c);
        [DllImport(DLL)] static extern void my_AVG(byte[] a, byte[] b, byte[] c);

        static void Main(string[] args)
        {
            //if (CheckMMX() == 1)
            //    Console.WriteLine("MMX is supported");
            //else
            //    Console.WriteLine("MMX is not supported");

            //if (CheckSSE() == 1)
            //    Console.WriteLine("SSE is supported");
            //else
            //    Console.WriteLine("SSE is not supported");

            //if (CheckSSE2() == 1)
            //    Console.WriteLine("SSE2 is supported");
            //else
            //    Console.WriteLine("SSE2 is not supported");

            //if (CheckSSE3() == 1)
            //    Console.WriteLine("SSE3 is supported");
            //else
            //    Console.WriteLine("SSE3 is not supported");


            byte[] A = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            byte[] B = { 15, 14, 13, 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            byte[] C = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            Console.Write("A: ");
            for (int i = 0; i < 16; i++) Console.Write(A[i] + ", ");
            Console.WriteLine();

            Console.Write("B: ");
            for (int i = 0; i < 16; i++) Console.Write(B[i] + ", ");
            Console.WriteLine();

            Console.WriteLine();

            my_SUB(A, B, C);
            Console.Write("SUB: ");
            for (int i = 0; i < 16; i++) Console.Write(C[i] + ", ");
            Console.WriteLine();

            my_AND(A, B, C);
            Console.Write("AND: ");
            for (int i = 0; i < 16; i++) Console.Write(C[i] + ", ");
            Console.WriteLine();

            my_OR(A, B, C);
            Console.Write("OR:  ");
            for (int i = 0; i < 16; i++) Console.Write(C[i] + ", ");
            Console.WriteLine();

            my_XOR(A, B, C);
            Console.Write("XOR: ");
            for (int i = 0; i < 16; i++) Console.Write(C[i] + ", ");
            Console.WriteLine();

            my_MAX(A, B, C);
            Console.Write("MAX: ");
            for (int i = 0; i < 16; i++) Console.Write(C[i] + ", ");
            Console.WriteLine();

            my_AVG(A, B, C);
            Console.Write("AVG: ");
            for (int i = 0; i < 16; i++) Console.Write(C[i] + ", ");
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}