using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operations {
    public class Multiplication {
        public void MultiplicationValue() { 
            Console.Clear();
            Console.WriteLine("Hello! Let's work with the multiplication operator.");

            Console.WriteLine("Insert the first value:");
            float firstValue = float.Parse(Console.ReadLine());

            Console.WriteLine("Insert the second value:");
            float secondValue = float.Parse(Console.ReadLine());

            float result = firstValue * secondValue;
            Console.WriteLine();
            Console.WriteLine($"The result of multiplyng between {firstValue} and {secondValue} is: {result}");
            Console.ReadLine();

            var menu = new MenuOperations();
            menu.Menu();
        }
    }
}
