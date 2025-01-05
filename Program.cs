using System;
using System.Linq;

namespace Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fname = "nagy";
            string lname = "yasser";

            var fullName = $"{fname} {lname}";

            Console.WriteLine(fullName);


            var txtTest = "one,two,three";

            var septxtTest = txtTest.Split(',');

            foreach(var sept in septxtTest)
            {
                Console.WriteLine(sept);
            }

            char[] ac = new char[] {  'a', 'b', 'c', 'd', 'e' };

          var lss =  string.Join(" - ", ac);

            Console.WriteLine(lss);
        }
    }   
}
