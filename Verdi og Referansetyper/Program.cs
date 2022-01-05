using System;
using System.Collections.Generic;

namespace Verdi_og_Referansetyper
{
    internal class Program
    {


        static void Main(string[] args)
        {
            var a = 5;
            var b = 3.0;
            var sum = a + b;
            Console.WriteLine($"A + B = SUM {a} + {b} = {sum}");
            //bruker ${} i tekst string for variabler(var {a}).
        }
    }
}


//int tall = 1;

//float desimalTall = 1.01f; //Nøyaktig
//double desimalTall2 = 1.01;
//decimal desimalTall3 = 1.01M; // Veldig nøyaktig

//char bokstav = 'a';
//string tekst = "hei";

//bool santUsant = true; // Eller false

//int[] tallArray = { 1, 2, 3 };
//string[] tekstArray = { "hei", "på", "deg" };
//List<int> liste = new List<int>();