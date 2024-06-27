string user = Environment.UserName;
List<string> dontforget = new List<string>();

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
            Console.WriteLine($"{user}, welches Todo möchtest du löschen?");
            for (int i = 0; i < dontforget.Count; i++)
            {
                Console.WriteLine($"\t{i + 1}. {dontforget[i]}");
            }
                var dontfogetIndexString = Console.ReadLine();
                int dontforgetIndex = int.Parse(dontfogetIndexString);
                dontforget.RemoveAt(dontforgetIndex - 1);
            break;
        case "4":
            Console.WriteLine($"{user}, welches Dontforget möchtest du bearbeiten?");
            for (int i = 0; i < dontforget.Count; i++)
            {
                Console.WriteLine($"\t{i + 1}. {dontforget[i]}");
            }
                Console.WriteLine($"{user}, gib deine Änderung ein.");
                var indexString = Console.ReadLine();
                int index = int.Parse(indexString);

                var newForgets = Console.ReadLine();
                dontforget[index - 1] = newForgets;
                Console.WriteLine("Dontforget bearbeitet");
            break;
    }
} while (true);
