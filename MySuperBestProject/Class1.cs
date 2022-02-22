using System;

namespace MySuperBestProject
{
    public static class Poww
    {
        public static void Powy(double x, double N)
        {
            x = Convert.ToDouble(Console.ReadLine());
            N = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Math.Pow(x, N));
        }
    }
}
