using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz9._3
{
    internal class Program
    {
        delegate int RandomNumberDelegate();
            static void Main(string[] args)
            {
                RandomNumberDelegate[] delegates = new RandomNumberDelegate[5];
                delegates[0] = () => new Random().Next(1, 100);
                delegates[1] = () => new Random().Next(1, 100);
                delegates[2] = () => new Random().Next(1, 100);
                delegates[3] = () => new Random().Next(1, 100);
                delegates[4] = () => new Random().Next(1, 100);
                int average = CalculateAverage(delegates);
                Console.WriteLine($"Average: {average}");
                Console.ReadLine();
            }

            static int CalculateAverage(RandomNumberDelegate[] delegates)
            {
                int sum = 0;
                foreach (var del in delegates)
                {
                    int result = del();
                    sum += result;
                }
                int average = sum / delegates.Length;
                return average;
            }
        }
}
