using System;

namespace shared_app_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eric - dniwe");
            Console.WriteLine("how about NO?");
            Console.WriteLine("how about suck my dick?");
            Console.WriteLine(Fact(10));
        }

        static int Fact(int n)
        {
            //switched from recursive
            int acc =1;
            for (int i = 1; i <= n; i++)
            {
                acc*=i;
            }
            return acc;
            //fuch the iterations!!! recursion is our life!!!!
        }
    }
}
