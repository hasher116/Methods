using System;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(sum(y:2, x:3)) ;
        }

        static int sum(int x, int y, int z = 5, int u = 3)
        {
            return x + y + z + u;
        }
    }
}
