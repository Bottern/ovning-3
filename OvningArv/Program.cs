using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Övning_3;

namespace OvningArv
{
    class Program
    {
        static void Main(string[] args)
        {
            // Uppgift 1

            object myObject = new Object();
            object myObject2 = (string)"5"; 
            string myString = "5.5";
            var myString2 = double.Parse (myString);
            int myInt = 5;
            var douuble = 5.8;
            int myInt2 = (int)douuble;
            double myDouble = 5.5;
            char B = default(char); // just dont do it
            bool myBool; if(bool.Parse("true"))

            Console.WriteLine(myString2);
        }
    }
}
