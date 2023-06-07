using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz9._5
{
    delegate int Average(int x,int y,int z);
    internal class Program
    {
        static void Main(string[] args)
        {
            Average Aver = (x,y,z) => {return (x + y + z)/3; };
            Console.WriteLine("введи перше число");
            int.TryParse(Console.ReadLine(), out int firstNumb);
            Console.WriteLine("введи друге число");
            int.TryParse(Console.ReadLine(), out int SecoNumb);
            Console.WriteLine("введи третє число");
            int.TryParse(Console.ReadLine(), out int ThirdNumb);
            Console.WriteLine($"середнє арифметичне {Aver(firstNumb,SecoNumb,ThirdNumb)}");
            Console.ReadLine();
        }
    }
}
