////Der ganze Code in dieser Datei ist in der Program.Main Funktion
//using Aufgaben;

////Kommt aus Example.Test -> Example.cs file
////Example.Test();

//List<int> numbers = new() { 1, 2, 3, 4, 5, 6, 7};
//int query = 6;

////Aufgabe: Find Index
//var index = Sammlungen.FindIndex( numbers, query);
//Console.WriteLine(index);

using Aufgaben;

List<int> temperaturen = new() { 20, 22, 19, 24, 21, 18, 25 };
int schwellenwert = 21;

List<int> ergebnisliste = new();

var index = Sammlungen.TempList(temperaturen, schwellenwert);
Console.WriteLine(index);