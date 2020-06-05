using System;

namespace StrongholdFinder
{
    class Program
    {
        static void GetData(out double x, out double z, out double angle)
        {
            while (true)
            {
                string[] input = Console.ReadLine().Split(' ');

                if (input.Length < 3)
                {
                    Console.WriteLine("invalid input");
                    continue;
                }

                try
                {
                    x = double.Parse(input[0]);
                    z = double.Parse(input[1]);
                    angle = double.Parse(input[2]);
                }
                catch (FormatException)
                {
                    Console.WriteLine("invalid input");
                    continue;
                }
                    
                break;
            }
        }

        static void Main()
        {
            GetData(out double ax, out double az, out double alpha);
            GetData(out double bx, out double bz, out double beta);

            // convert to radians
            alpha *= Math.PI / 180;
            beta *= Math.PI / 180;

            Line l = new Line(ax, az, alpha);
            Line m = new Line(bx, bz, beta);

            l.Intercept(m, out double x, out double z);

            int blockX = (int)x;
            int blockZ = (int)z;

            Console.WriteLine($"stronghold at {blockX} {blockZ}");
        }
    }
}
