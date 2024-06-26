using System.Threading.Channels;

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