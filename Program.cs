using Basics.Math;
using System;

namespace Basics
{
    public enum ShppingMethods
    {
        Regulare = 1,
        Express = 2,
    }
    public class Person
    {
        public string Name { get; set; }

        public void Introduce()
        {
            Console.WriteLine("My Name, {0}", this.Name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();

            person.Name = "Nagy";

            person.Introduce();


            var calculator = new Calculator();

            var result = calculator.Add(4, 4);



            // Arrays
            int[] codes = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.WriteLine(codes[0]);


            // Enums
            var method = ShppingMethods.Express;

            Console.WriteLine((int) method);

            var methodId = 1;

            Console.WriteLine((ShppingMethods) methodId);  
        }
    }
}
