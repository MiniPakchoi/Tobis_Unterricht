List<string> dontforget = new List<string>();
string user = Environment.UserName;
Console.BackgroundColor = ConsoleColor.Gray;
Console.ForegroundColor = ConsoleColor.Black;
int GetIndex(string prompt)  //Funktionssignatur
{
    Console.WriteLine(prompt);
    var input = Console.ReadLine();
    var number = int.Parse(input);
    return number;
}
void Listandforgets()
{
    Console.WriteLine($"{user}, das sind deine Aufgaben:");
    DontforgetList();
}

void DontforgetList()
{
    for (int i = 0; i < dontforget.Count; i++)
    {
        Console.WriteLine($"\t{i + 1}. {dontforget[i]}");
    }
    
}

do
{
    Console.Clear();
    Console.WriteLine($"Willkommen {user} bei Dontforget!");
    Console.WriteLine("Was möchtest du tun?");
    Console.WriteLine("\t1. Neues Todo erstellen\n\t2. Todos anzeigen\n\t3. Todo abhaken\n\t4. Todo bearbeiten");
    var input = Console.ReadLine();

    switch (input)
    {
        case "1":
            Console.WriteLine($"{user}, was hast du zu tun?");
            var dontforgets = Console.ReadLine();
            dontforget.Add(dontforgets);
            Console.WriteLine($"Dontforget {dontforgets} erstellt!");
            Thread.Sleep(2000);   //Lässt den aktuellen Prozess schlafen.
            // Console.ReadLine(); // Der User entscheider länger Pause
            break;
        case "2":
            //Console.WriteLine($"{user}, das sind deine Aufgaben:");
            Listandforgets();
            Console.WriteLine("Drücke <ENTER> wenn du ins Menü zurückkehren willst.");
            Console.ReadKey();
            break;
        case "3":
            Listandforgets();
            var dontforgetIndex = GetIndex($"{user}, welches Dontforget soll gelöscht werden?");
            dontforget.RemoveAt(dontforgetIndex - 1);
            break;
        case "4":
            Listandforgets();
            var index = GetIndex($"{user}, welches Dontforget soll bearbeitet werden?");
            Console.WriteLine($"{user} was möchtest du stattdessen tun?");

            var newForgets = Console.ReadLine();
            dontforget[index - 1] = newForgets;
            Console.WriteLine("Dontforget bearbeitet", newForgets);
            break;
    }
} while (true);
