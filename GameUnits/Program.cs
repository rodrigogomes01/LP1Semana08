﻿using System;

namespace GameUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            MilitaryUnit mu = new MilitaryUnit(2, 10, 5);
            mu.Move();

            // Print health and cost
            Console.WriteLine("Health: " + mu.Health);
            Console.WriteLine("Cost: " + mu.Cost);
        }
    }
}
