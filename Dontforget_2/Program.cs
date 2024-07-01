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

void DontforgetList()
{
    //Wenn nur eine einzige Anweisung auf ein if-/else Statement folt, kann man die curly-braces {} weglassen
    if (dontforget.Count >= 2)
        Console.WriteLine($"{user}, das sind deine Aufgaben:");
    else if (dontforget.Count == 0)
        Console.WriteLine($"{user}, du hast keine Aufgaben");
    else
        Console.WriteLine($"{user}, das sind deine Aufgabe:");

    for (int i = 0; i < dontforget.Count; i++)
    {
        Console.WriteLine($"\t{i + 1}. {dontforget[i]}");
    }  
}

void showDontforget()
{
    DontforgetList();
    Console.WriteLine("Drücke <ENTER> wenn du ins Menü zurückkehren willst.");
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
            DontforgetList();
            Console.WriteLine("Drücke <ENTER> wenn du ins Menü zurückkehren willst.");
            Console.ReadKey();
            break;
        case "3":
            DontforgetList();
            var dontforgetIndex = GetIndex($"{user}, welches Dontforget soll gelöscht werden?");

            
            dontforget.RemoveAt(dontforgetIndex - 1);
            //Hole dontforgets, vor dem löschen, zum anzeigen
            string dontforgetsToRemove = dontforget[dontforgetIndex - 1];
            //lösche dontforgets
            dontforget.RemoveAt(dontforgetIndex);

            //Zeige gelöschtes dontforgets dem User
            Console.WriteLine($"Dontforget {dontforgetsToRemove} geöscht!");
            showDontforget();
            break;
        case "4":
            DontforgetList();
            var index = GetIndex($"{user}, welches Dontforget soll bearbeitet werden?");
            Console.WriteLine($"{user} was möchtest du stattdessen tun?");

            var newForgets = Console.ReadLine();
            dontforget[index - 1] = newForgets;
            Console.WriteLine("Dontforget bearbeitet" + newForgets);
            showDontforget();
            break;
    }
} while (true);
