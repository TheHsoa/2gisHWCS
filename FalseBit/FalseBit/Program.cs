using System;

namespace FalseBit
{
    class FalseBit
    {
        static int MostSignificantBit(int n)
        {
            int l = 0;
            while (n != 0)
            {
                n >>= 1;
                l++;
            }
            return l;
        }
        static void Main(string[] args)
        {
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(m & ~(1 << (MostSignificantBit(m) - 1)));
            Console.ReadLine();

        }
    }
}