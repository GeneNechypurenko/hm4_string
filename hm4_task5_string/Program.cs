using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm4_task5_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExpressionCalculator eCalc = new ExpressionCalculator();
            InputManager iManage = new InputManager();

            Console.WriteLine("Enter expression to calculate: ");
            string exp = Console.ReadLine();

            iManage.Convert(ref exp);

            Console.WriteLine($"\nYour expression after convertation:\n{exp}");

            eCalc.Calculate(exp);

            Console.WriteLine($"\nThe result of calculation is:\n{eCalc.Result}\n");
        }
    }
}
