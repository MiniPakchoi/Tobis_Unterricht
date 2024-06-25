// Menü anzeigen mit Optionen
string user = Environment.UserName;
Console.WriteLine($"Willkommen {user} bei Dontforget");
Console.WriteLine("Was möchtest du tun?");
Console.WriteLine("\t1. Neues Todo erstellen\n\t2. Todos anzeigen"); 

do
{
    var input = Console.ReadLine();

    switch (input)
    {
        case "1":
            //Option 1:Todo erstellen
            //Userinput nehmen
            Console.WriteLine("Todo erstellen");
            var todo = Console.ReadLine();
            break;
        case "2":
            //Liste der Todos anzeigen
            Console.WriteLine("Todo anzeigen");
            break;
    }
} while (false);