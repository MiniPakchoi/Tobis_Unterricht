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

int getIndex()
{
    Console.WriteLine("Gebe die Aufgabe ein, die du bearbeiten willst:");
    var input = Console.ReadLine();
    var number = int.Parse(input);
    return number;
}

string[] my_dontforgets = ["Wäsche waschen", "Bügeln"];

int myIndex = getIndex();
//int mySecondIndex = getIndex();
//Console.WriteLine(my_dontforgets[getIndex()]);