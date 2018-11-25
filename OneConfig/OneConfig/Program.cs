using System;
using System.IO;
using System.Collections.Generic;

namespace OneConfig
{
    class Program
    {
        static void Main(string[] args)
        {
            Consolidator cons = new Consolidator();
            List<int> consList = new List<int>();

            Console.WriteLine("Input the corresponding numbers of 3 of your most played games in order of most played to least:");
            Console.WriteLine("1. Black Ops 4");
            Console.WriteLine("2. Battlefield 1");
            Console.WriteLine("3. Battlefield V");
            Console.WriteLine("4. Overwatch");
            Console.WriteLine("5. CS:GO");
            for (int i = 0; i < 3; i++){consList.Add(int.Parse(Console.ReadLine()));}
            cons.SetMainGames(consList);
        }
    }
}
