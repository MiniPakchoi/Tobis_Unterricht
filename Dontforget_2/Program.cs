string user = Environment.UserName;
List<string> dontforget = new List<string>();
int getIndex(string prompt)  //Funktionssignatur
{
    Console.WriteLine(prompt);
    var input = Console.ReadLine();
    var number = int.Parse(input);
    return number;
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
            Console.WriteLine("Dontforget erstellt!");
            //Lässt den aktuellen Prozess schlafen.
            Thread.Sleep(2000);
            // Console.ReadLine(); // Der User entscheider länger Pause
            break;
        case "2":
            Console.WriteLine($"{user}, das sind deine Aufgaben:");
            for (int i = 0; i < dontforget.Count; i++)
            {
                Console.WriteLine($"\t{i + 1}. {dontforget[i]}");
            }
            Console.WriteLine("Drücke <ENTER> wenn du ins Menü zurückkehren willst.");
            Console.ReadKey();
            break;
        case "3":
            for (int i = 0; i < dontforget.Count; i++)
            {
                Console.WriteLine($"\t{i + 1}. {dontforget[i]}");
            }
            var dontforgetIndex = getIndex($"{user}, welches Todo möchtest du löschen?");
            dontforget.RemoveAt(dontforgetIndex - 1);
            break;
        case "4":
            for (int i = 0; i < dontforget.Count; i++)
            {
                Console.WriteLine($"\t{i + 1}. {dontforget[i]}");
            }
            var index = getIndex($"{user}, welches Dontforget möchtest du bearbeiten?");
            Console.WriteLine($"{user} was möchtest du stattdessen tun?");

            var newForgets = Console.ReadLine();
            dontforget[index - 1] = newForgets;
            Console.WriteLine("Dontforget bearbeitet", newForgets);
            break;
    }
} while (true);
