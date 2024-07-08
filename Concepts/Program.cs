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

List<string> dontforgets = new ();

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
    index1++;
}