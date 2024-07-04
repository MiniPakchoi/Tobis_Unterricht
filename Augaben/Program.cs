////Der ganze Code in dieser Datei ist in der Program.Main Funktion
using Aufgaben;

////Kommt aus Example.Test -> Example.cs file
Example.Test();

// Was wenn diese Liste hier einen Count von 1.000.000+ hat?
List<int> numbers = new() { 1, 2, 3, 4, 5, 6, 7 };
int query = 6;

////Aufgabe: Find Index
//var index = Sammlungen.FindIndex(numbers, query); // wenn query 6, sollte index = 5
//Console.WriteLine($"FindIndex Test1; Sollte 5; Ist {index}"); // sollte 5 sein
//// Find Index mit 1.000.000 Elementen in Liste
//var manyNumbers = Sammlungen.GenerateNumbers(1_000_000_000);
//var manyNumbersQuery = 999_999_999;
//Console.WriteLine(manyNumbers.Count);
//var manyNumbersIndex = Sammlungen.FindIndexAlt(manyNumbers, manyNumbersQuery);
//Console.WriteLine($"FindIndex ManyNumbers SLOW; Sollte 999_999_999; Ist {manyNumbersIndex}");

//var manyNumbersFastIndex = Sammlungen.FindIndexOpimized(manyNumbers, manyNumbersQuery);
//Console.WriteLine($"FindIndex ManyNumbers FAST; Sollte 999_999_999; Ist {manyNumbersFastIndex}");



List<int> temperatures = new() { 20, 22, 19, 24, 21, 18, 25 };
var schwellenwert = 21;
List<int> ergebnisliste = Temperatures.TempList(temperatures, schwellenwert);

ergebnisliste.ForEach(Console.WriteLine); // sollte index [1, 3, 6]


// Temperature Average

var averageTemp = Temperatures.Average(temperatures);
Console.WriteLine($"Average: {averageTemp}"); // sollte 21.285714285714285 sein


// Aufgabe Haeufigkeit

//List<int> number = new() { 1, 2, 3, 3, 5, 2, -10, -10 };
//Sammlungen.Haeufigkeit(number);

// Aufgabe BaumBauer
Sammlungen.BaumBauer();


// Aufgabe Diamond Builder
//Sammlungen.DiamondBuilder();

// Aufgabe FindSmallestValue
Console.WriteLine("Ab hier werden kleinste Zahlen gesucht!");
int[] findSmallestValue = { 101, 45, 31, 13, 500, 61, 79, 88, 55, 99, 350, 700, 22, 35 };
Array.Sort(findSmallestValue);
int min = findSmallestValue[0];
Console.WriteLine($"\n" + min);

// Aufgabe Only Even

List<int> onlyEvenNumber = new() { 1, 2, 3, 4, 5, 6 };
List<int> onlyEvenNumbers = Sammlungen.OnlyEven(numbers);
onlyEvenNumbers.ForEach(Console.WriteLine);