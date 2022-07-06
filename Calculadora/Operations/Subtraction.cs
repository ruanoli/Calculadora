using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operations {
    public class Subtraction {
        public void SubValue() {
            Console.Clear();
            Console.WriteLine("Hello! Let's work with the subtraction operator.");

            Console.WriteLine("Insert a first value:");
            float firstValue = float.Parse(Console.ReadLine());

            Console.WriteLine("Insert a second value:");
            float secondValue = float.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Clear();
            float subValue = firstValue - secondValue;

            Console.WriteLine($"The subtraction of the values is: {subValue}");
            Console.ReadKey();

            var menu = new MenuOperations();
            menu.Menu();
        }
    }
}
