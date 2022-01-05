﻿using System;

namespace FruitArrayy
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fruit = new string[5] { "an apple", "a banana", "a lemon", "an orange", "some grapes" };
            Random rnd = new Random();
            int userNumber = rnd.Next(0, fruit.Length);

            Console.WriteLine($"Today you will have {fruit[userNumber]}.");

        }
    }
}
