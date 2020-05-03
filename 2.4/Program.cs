using System;

namespace _2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            for (int i = 0; i <= 5; i++, Console.WriteLine())
            {
                for (int j = 0; j <= 5 - n; j++)
                    Console.Write(" " + j);
                n++;
            }
        }
    }
}
