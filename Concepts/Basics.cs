using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concepts
{
    internal class Basics
    {
        internal void Run()
        {
            
            string name = "Jade";

            /*
             * PascalCase  => WorttrennungenWerdenGrossGeschrieben
             * camelCase   => worttrennungenWerdenKleingeschrieben
             * snake_case  => worttrennungen_werden_kleingeschrieben
             * kebab-case  => worttrennungen-werden-kleingeschrieben
             */

            /*
             * DateTime ist einer von vielen komplexen Datentypen in C#
             * Date Time ist ein Strukturtyp, der Datum und Uhrzeit darstellt
             * Komplexe Datentypen sind Objekte, die aus meheren Werten bestehen, welche
             * ebenfalls komplext oder auch primiti sein können.
             * Objekte können nur in der Konsole ausgegeben werden, wenn sie eine Methode
             * ToString() haben.
             */
            DateTime date = DateTime.Now;

            bool is_true = false;
            //Funktionen
            // x = 5y
            Console.WriteLine("bighig");
            var y = Console.ReadLine();

            var trimmed_name = name.Trim();

            //Console.WriteLine(x);

            var test = 5.5;


            //implicit conversion
            Console.WriteLine((int)test + (int)test);

            // explicit conversion
            // int num = int.Parse(test);

            void PrintName()
            {
                Console.WriteLine("Hallo User!");
            }

            PrintName();
            PrintName();

            string GetGreeting()
            {
                return "Herzlich Willkommen!";
            }

            var greeting = GetGreeting();

            Console.WriteLine(greeting);
        }

    }
}
