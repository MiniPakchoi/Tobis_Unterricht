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