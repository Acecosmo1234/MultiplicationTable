using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 0;
            int table = 2;

            for(int i = 0; length <= 100; length++)
            {
                i = length * 2;
                Console.WriteLine("{0} x {1} = {2}", length, table, i);
            }
        }
    }
}
