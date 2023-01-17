﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter index: ");
            int index = Convert.ToInt32(Console.ReadLine());
            int[] fibonacci = new int[index + 1];
            fibonacci[0] = 0;
            fibonacci[1] = 1;
            for (int i = 2; i <= index; i++)
            {
                fibonacci[i] = fibonacci[i - 2] + fibonacci[i - 1];
            }
            Console.WriteLine(fibonacci[index]);
            //Console.Write("Enter index: ");
            //int index = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < index; i++)
            //{
            //    Console.WriteLine(Fibonacci(index));
            //}
        }
        //static int Fibonacci(int i)
        //{
        //    if (i == 0) return 0;
        //    if (i == 1) return 1;
        //    return Fibonacci(i - 2) + Fibonacci(i - 1);
        //}
    }
}