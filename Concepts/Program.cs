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
List<string> dontforgets = new ();

dontforgets.Add("Wäsche waschen");
dontforgets.Add("Bügeln");

int myIndex = getIndex("Gebe die Aufgabe ein, die du bearbeiten willst:");
//int mySecondIndex = getIndex("....einen Text eingeben"); // kann beliebt oft aufgerufen werden
Console.WriteLine(dontforgets[index]);