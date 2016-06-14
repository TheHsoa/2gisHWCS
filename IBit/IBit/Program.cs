using System;

namespace IBit
{
    class IBit
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((n | 1 << (i - 1)) == n ? 1 : 0);
            Console.ReadLine();
        }
    }
}
