﻿using System;
using System.Threading;

namespace Fighting_Game_v1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            string classs = "";
            Console.WriteLine("Hello Warrior!");
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("Please pick a class: Bow, Sword, Spear, Mage (case senestive)");
            classs = Console.ReadLine();

            if (classs == "Bow")
            {
                Console.WriteLine("I wish you good luck on your journey!");
                string bowmove = "";
                int a = 32;
                int b = 20;
                int c = 5;
                Console.WriteLine("Oh no! A wild slime has appeared. Get rid of it!");
                slime();
                Console.WriteLine("You can choose from a range of moves: Long shot({0}), Rapid fire({1}), Flamming arrow({2})", a, b, c);
                bowmove = Console.ReadLine();

                if (bowmove == "Long shot")
                {
                    a = a - 1;
                    Console.WriteLine("Well done you took the slime down!");
                }
                else if (bowmove == "Rapid fire")
                {
                    b = b - 1;
                    Console.WriteLine("Well done you took the slime down!");
                }
                else if (bowmove == "Flamming arrow")
                {
                    c = c - 1;
                    Console.WriteLine("Well done you took the slime down!");
                }
            }
            else if (classs == "Sword")
            {
                Console.WriteLine("I wish you good luck on your journey!");
            }
            else if (classs == "Spear")
            {
                Console.WriteLine("I wish you good luck on your journey!");
            }
            else if (classs == "Mage")
            {
                Console.WriteLine("I wish you good luck on your journey!");
            }
        }

        static void slime()
        {
            Console.WriteLine(" |||||||||||| ");
            Console.WriteLine("|            |");
            Console.WriteLine("|  *      *  |");
            Console.WriteLine("|    ____    |");
            Console.WriteLine("|            |");
            Console.WriteLine(" |||||||||||| ");
        }
    }
}
