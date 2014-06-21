using System;
using System.Collections.Generic;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            List<string> setList = new List<string>();
            for (int x = 0; x < num; x++)
            {
                setList.Add(Console.ReadLine());
            }
            foreach (string item in setList)
            {
                string[] stringset = item.Split(new[] {' '});
                int min = int.Parse(stringset[0]);
                int max = int.Parse(stringset[1]);
                Console.WriteLine(item);
            }
        }
    }
}
