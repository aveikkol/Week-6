﻿using System;

namespace StringAndArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //progtamm küsib kasutajal sisestada eesnime
            //programm kuvab kasutaja eesnime pikkust

            Console.WriteLine("sisesta eesnimi: ");
            string firstName = Console.ReadLine();

            int firstNameLength = firstName.Length;
            Console.WriteLine($"Sinu eesnimes on {firstNameLength} sümbolit.");

        }
    }
}
