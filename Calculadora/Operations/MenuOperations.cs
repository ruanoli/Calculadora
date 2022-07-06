using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operations {
    public class MenuOperations {
        public void Menu() {
            Console.Clear();
            Console.WriteLine("Choose the option you want:");
            Console.WriteLine("1 - Sum");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Multiplication");
            Console.WriteLine("4 - Division");
            Console.WriteLine("0 - Exit");

            Console.WriteLine();
            Console.WriteLine("----------");
            Console.WriteLine("Select an option:");
            Console.WriteLine();

            short result = short.Parse(Console.ReadLine());

            var sum = new Sum();
            var sub = new Subtraction();
            var mult = new Multiplication();
            var div = new Division();

            switch (result) {
                case 1:
                    sum.SumValue();
                    break;
                case 2:
                    sub.SubValue();
                    break;
                case 3:
                    mult.MultiplicationValue();
                    break;
                case 4:
                    div.DivisionValue();
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
                default:
                    Menu();
                    break;
            }
        }
    }
}
