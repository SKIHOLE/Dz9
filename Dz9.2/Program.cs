using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz9._2
{
    internal class Program
    {
        
        delegate int MyDelegate(int x,int y);
        static void Main(string[] args)
        {

            MyDelegate Add = (x, y) => x + y;
            MyDelegate Sub = (x, y) => x - y;
            MyDelegate Mul = (x, y) => x * y;
            MyDelegate Div = (x, y) => x / y;
            Console.WriteLine("Введіть перше число:");
            int input1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть друге число:");
            int input2 = int.Parse(Console.ReadLine());
            int addResult = Add(input1, input2);
            Console.WriteLine($"Результат додавання: {addResult}");
            int subResult = Sub(input1, input2);
            Console.WriteLine($"Результат віднімання: {subResult}");
            int mulResult = Mul(input1, input2);
            Console.WriteLine($"Результат множення: {mulResult}");
            int divResult = Div(input1, input2);
            Console.WriteLine($"Результат ділення: {divResult}");
            Console.ReadKey();
        }
    }
}
