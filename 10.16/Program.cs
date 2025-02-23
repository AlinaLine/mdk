﻿using System;

namespace _10._16
{
    class Program
    {
        class ProstyeChisla
        {
            // массив простых чисел
            public long[] prost = new long[10000000];
            public long n_min; // нижняя граница
            public long n_max; // верхняя граница
                               // время старта и финиша поиска
            public DateTime tstart, tfinish;
            // поиск простых чисел 
            public long poisk()
            {
                prost[0] = 2;
                prost[1] = 3;
                prost[2] = 5;
                prost[3] = 7;
                prost[4] = 11;
                long x = 13;
                long k = 5;
                while (x <= n_max)
                {
                    if (yes_pr(x))
                    {
                        prost[k] = x;
                        k++;
                    }
                    x = x + 2;
                }
                return k;
            }
            // является ли очередное число x простым?
            bool yes_pr(long x)
            {
                bool b = true;
                double y = Math.Sqrt(x);
                long z = Convert.ToInt64(y + 0.5);
                long k = 1;
                while (prost[k] < z)
                {
                    if (x % prost[k] == 0)
                    {
                        b = false;
                        break;
                    }
                    k++;
                }
                return b;
            }
            static void Main(string[] args)
            {
                ProstyeChisla pch = new ProstyeChisla();
                Console.Write("Введите нижнюю границу простых чисел: ");
                pch.n_min = Convert.ToInt64(Console.ReadLine());
                Console.Write("Введите верхнюю границу простых чисел: ");
                pch.n_max = Convert.ToInt64(Console.ReadLine());
                long k = pch.poisk();
                long j = 0;
                for (int i = 0; i < k; i++)
                    if (pch.prost[i] > pch.n_min)
                    {
                        Console.Write(pch.prost[i].ToString() + "\t");
                        j++;
                    }
                Console.WriteLine("\nВсего: {0}, в диапазоне: {1}", k, j);
                Console.ReadKey();
            }
        }

    }
}
