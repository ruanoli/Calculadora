using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operations {
    public class Sum {
        public void SumValue() {
            Console.Clear(); 
            Console.WriteLine("Hello! Let's work with the sum operator.");
            Console.WriteLine();

            Console.WriteLine("Insert a first value:");
            float firstValue = float.Parse(Console.ReadLine());

            Console.WriteLine("Insert a second value:");
            float secondValue = float.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Clear();
            float sumValue = firstValue + secondValue;

            Console.WriteLine($"The sum of the values is: {sumValue}");
            Console.WriteLine();
            Console.ReadKey();

            var menu = new MenuOperations();
            menu.Menu();
        }
    }
}
