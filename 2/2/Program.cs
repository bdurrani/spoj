using System;
using System.Collections.Generic;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            primes.Add(2, 2);
            primes.Add(3, 3);
            primes.Add(5, 5);
            PrintPrimes(100, 200);
            Console.ReadLine();
            int num = int.Parse(Console.ReadLine());
            List<string> setList = new List<string>();
            for (int x = 0; x < num; x++)
            {
                setList.Add(Console.ReadLine());
            }
            foreach (string item in setList)
            {
                string[] stringset = item.Split(new[] { ' ' });
                int min = int.Parse(stringset[0]);
                int max = int.Parse(stringset[1]);
            }

        }
        private static SortedList<int, int> primes = new SortedList<int, int>();
        public static int MaxPrimeFound = -1;
        public static void PrintPrimes(int min, int max)
        {
            bool[] isNotPrimeArray = new bool[max - min + 1];
            for (int check = min; check <= max; check++)
            {
                if (check == 1)
                {
                    isNotPrimeArray[check - min] = true;
                    continue;
                }
                int index = 3;
                bool isPrime = true;
                if (!primes.ContainsKey(check))
                {
                    if (isNotPrimeArray[check - min])
                    {
                        continue;
                    }
                    if (check % 2 == 0)
                    {
                        isPrime = false;
                    }
                    else
                    {
                        for (int i = index; i <= Math.Floor(Math.Sqrt(check)); i += 2)
                        {
                            if (check % i == 0)
                            {
                                isPrime = false;
                                break;
                            }
                        }
                    }
                }
                if (isPrime)
                {
                    if (!primes.ContainsKey(check))
                    {
                        primes.Add(check, check);
                    }
                    if (check > MaxPrimeFound)
                    {
                        MaxPrimeFound = check;
                    }
                }
                else
                {
                    isNotPrimeArray[check - min] = true;
                }
                for (int i = 2 * check; i <= max; i += check)
                {
                    isNotPrimeArray[i - min] = true;
                }
            }
            int counter = 0;
            int primecounter = 0;
            foreach (bool item in isNotPrimeArray)
            {
                if (!item)
                {
                    Console.WriteLine(min + counter);
                    primecounter++;
                }
                counter++;
            }
            primecounter = 0;
        }
    }
}
