using System;

namespace ChocolateFeast
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                string[] input = Console.ReadLine().TrimEnd().Split(' ');

                int n = int.Parse(input[0]);
                int c = int.Parse(input[1]);
                int m = int.Parse(input[2]);

                int res = chocolateFeast(n, c, m);

                Console.WriteLine(res);
            }
        }

        private static int chocolateFeast(int n, int c, int m)
        {
            var sum = 0;
            var aCount = n / c;
            if (aCount < m)
            {
                return aCount;
            }
            while (aCount >= m)
            {
                var turnCount = aCount / m;

                var remCount = aCount % m;

                sum += turnCount;

                aCount = turnCount + remCount;
                

            }
            return sum;
        }
    }
}
