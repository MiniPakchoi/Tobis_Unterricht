// Menü anzeigen mit Optionen
string user = Environment.UserName;
Console.WriteLine($"Willkommen {user} bei Dontforget");
string[] todos = new string[10];
do
{
    Console.Clear();
    Console.WriteLine("Was möchtest du tun?");
    Console.WriteLine("\t1. Neues Todo erstellen\n\t2. Todos anzeigen");
    var input = Console.ReadLine();

    switch (input)
    {
        case "1":
            //Option 1:Todo erstellen
            //Userinput nehmen
            var todo = Console.ReadLine();
            //Iterieren durch alle Todos (auch die leeren)
            for (int i = 0; i < todos.Length; i++)
            {
                if (todos[i] == null)
                {
                    //Fügen wir das Todo hinzu
                    todos[i] = todo;
                    Console.WriteLine("Todo erstellt");
                    break;
                }
            }         
            break;
        case "2":
            //Liste der Todos anzeigen
            Console.WriteLine($"{user} das sind deine Aufgaben:");
            {
                for (int i = 0; i < todos.Length; i++)
                {
                    Console.WriteLine($"\t{i}.{todos[i]}");
                }
                Console.WriteLine("Drücke <ENTER> wenn du ins Menü zurückkehren willst.");
                Console.ReadKey();
                break;
            }
        case "3":
            // Löschen
            Console.WriteLine("Welches Todo möchtest du löschen?");
            for (int i = 0; i < todos.Length; i++)
            {
                Console.WriteLine($"\t{i}. {todos[i]}");
            }
            var todoIndexString = Console.ReadLine();
            int todoIndex = int.Parse(todoIndexString);
            // float todoIndex = float.Parse(todoIndexString);
            // int todoIndex1 = Convert.ToInt32(todoIndexString);
            todos[todoIndex] = null;
            break;
        case "4":
            // Updaten/Verändern eines Todos (verändern des strings)
            // 
            break;

    }
} while (true);