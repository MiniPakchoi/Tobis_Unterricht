using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concepts
{
    internal class Collections
    {
        internal void ArrayRun()
        {
            // Chararrays
            var my_array = "Feierabend!";
            var my_letter = my_array[0];

            // Collections-Basics
            // Array
            string[] namen = new string[5];
            string[] alternative_namen = ["Tobi", "Popstar", "Lehrer"]; // max 3 items
            string[] alternative_namen1 = { "Ab", "Bc", "Cd" };
            namen[0] = "Tobi";
            namen[1] = "Melanie";
            namen[2] = "Torben";
            namen[99999999999999998] = "Buxtehude!";
            Console.WriteLine(namen[0][0]);


            // Array ist eine Liste an Werten
            // Eine kontinuirliche Speicherregion, für mehrere Daten eines gewissen Types
            int[] nums = new int[5];
        }
        internal void ListRun()
        {
            //Deklaration & Initialisierung
            //string[] namen = new string[1];
            //Deklaration
            string[] namen = new string[2];

            namen[0] = "Thomas";
            namen[1] = "Susi";
            //namen[2] = "Markus"

            namen = namen.Append("Makrus").ToArray();
            //weil voll geht nicht ->passiert was, aber nicht das was wir denken was passieren sollte...

            for (int i = 0; i < namen.Length; i++)
            {
                Console.WriteLine(namen[i]);
            }
            string[] testArray = { "test", "me" };
            Console.WriteLine(testArray); //String[]

            //Listen
            Console.WriteLine("-----Listen----");

            //List<string> hamster = new List<string>();
            //var hamster = new List<string>();
            List<string> hamster = new();
            Console.WriteLine(hamster);

            //Hinzufügen am Ende
            hamster.Add("Maxi"); //Index 0
            hamster.Add("Mini"); //Index 1

            //Hinzufügen an gewissen Index
            hamster.Insert(1, "Mogli");

            Console.WriteLine(hamster[0]);

            //Löschen eines Elements => Angabe des Elements (nicht der Index)

            Console.WriteLine(hamster[1]);

            //Löschen des letzten Elements
            //hamster.RemoveAT(hamser.Count - 1)

            hamster.Add("Meli");

            if (hamster.Contains("Maxi"))
            {
                //mach was cooles!
            }

            //Anders als bei Array
            //Liste hat Count, statt Länge!
            //Count ist die aktuelle Größe der Liste
            //Length ist die Gesamtkapazität des Arrays
            //ps:Liste hat eine Kapazität, aber für uns nicht relevant -> hamster.Capacity

            Console.WriteLine(hamster.Count());

            for (int i = 0; i < hamster.Count; i++)
            {
                Console.WriteLine(hamster[i]);
            }







        }

        /*internal void ListForeach()
         {
             Console.WriteLine("Her mit einer Zahl!");
             var input = Console.ReadLine();
             //int index = int.Parse(input);
             //int index = Convert.ToInt32(input);
             var error = int.TryParse(input, out var index);

             if (!error)
             {
                 Console.WriteLine(error);
             }
             else
             {
                 Console.WriteLine(index);
             }

             //Beispiel Funktion/Methode mit Parameter
             //Eine Fuktion kann keinen, einen oder belieb viele Parameter bekommen
             //Die parameter k önnen die Funktionsweise einer Methode dynamisch ändern
             int getIndex(string prompt)  //Funktionssignatur
             {
                 Console.WriteLine(prompt);
                 var input = Console.ReadLine();
                 var number = int.Parse(input);
                 return number;
             }

             //Erstelle eine Funktion , für die Ausgabelogik der Liste. Extrahieren in eine eigene Funktion

             int dontforgetList()
             {
                 for (int i = 0; i < dontforget.Count; i++)
                 {
                     Console.WriteLine($"\t{i + 1}. {dontforget[i]}");
                 }
             }

             List<string> dontforgets = new();

             dontforgets.Add("Wäsche waschen");
             dontforgets.Add("Bügeln");

             int myIndex = getIndex("Gebe die Aufgabe ein, die du bearbeiten willst:");
             //int mySecondIndex = getIndex("....einen Text eingeben"); // kann beliebt oft aufgerufen werden
             Console.WriteLine(dontforgets[index]);

             var contact = Console.ReadLine();

             var contact2 = Console.ReadLine();

             var contact3 = Console.ReadLine();


             List<string> names = new List<string>();
             names.Add("Markus");
             names.Add("Jane");
             names.Add("Silvio");

             for (int index = 0; index < 3; index++)
             {
                 string name = names[index];
                 Console.WriteLine(name);
             }

             var test = "hello";

             foreach (string name in names)
             {
                 Console.WriteLine(name);
             }

             foreach (char character in test)
             {
                 Console.WriteLine(character);
             }

             int index1 = 0; // Originale Speicheraddresse des Arrays (ohne offset)
             while (index1 < names.Count)
             {
                 Console.WriteLine(names[index1]);
                 index1++; */
    }
}
    