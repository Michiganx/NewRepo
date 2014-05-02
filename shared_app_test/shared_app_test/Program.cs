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
        }

        static int Fact(int n)
        {
            if (n > 1)
                return Fact(n - 1);
            else
                return 1;
        }
    }
}
