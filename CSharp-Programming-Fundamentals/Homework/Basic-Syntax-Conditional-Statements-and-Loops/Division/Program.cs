﻿using System;

namespace Division
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            var result = string.Empty;

            if (number % 10 == 0)
            {
                result = "The number is divisible by 10";
            }
            else if (number % 7 == 0)
            {
                result = "The number is divisible by 7";
            }
            else if (number % 6 == 0)
            {
                result = "The number is divisible by 6";
            }
            else if (number % 3 == 0)
            {
                result = "The number is divisible by 3";
            }
            else if (number % 2 == 0)
            {
                result = "The number is divisible by 2";
            }
            else
            {
                Console.WriteLine("Not divisible");
            }

            Console.WriteLine(result);
        }
    }
}