// Menü anzeigen mit Optionen
string user = Environment.UserName;
string[] todos = new string[10];
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
            //Option 1:Todo erstellen
            //Userinput nehmen
            Console.WriteLine($"{user}was hast du zu tun?");
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
                    Console.WriteLine($"\t{i+1}.{todos[i]}");
                }
                Console.WriteLine("Drücke <ENTER> wenn du ins Menü zurückkehren willst.");
                Console.ReadKey();
                break;
            }
        case "3":
            // Löschen
            Console.WriteLine($"{user} welches Todo möchtest du löschen?");
            for (int i = 0; i < todos.Length; i++)
            {
                Console.WriteLine($"\t{i+1}. {todos[i]}");
            }
            var todoIndexString = Console.ReadLine();
            int todoIndex = int.Parse(todoIndexString);
            // float todoIndex = float.Parse(todoIndexString);
            // int todoIndex1 = Convert.ToInt32(todoIndexString);
            todos[todoIndex-1] = null;
            break;
        case "4":
            // Updaten/Verändern eines Todos (verändern des strings)
            //
            Console.WriteLine($"{user} welches Todo möchtest du bearbeiten?");
            for (int i = 0; i < todos.Length; i++)
            {
                Console.WriteLine($"\t{i + 1}. {todos[i]}");
            }
            
            var indexString = Console.ReadLine();
            int index = int.Parse(indexString);
            Console.WriteLine($"{user} gib deine Änderung ein.");
            var newTodo = Console.ReadLine();
            todos[index-1] = newTodo;
            break;
    }
} while (true);