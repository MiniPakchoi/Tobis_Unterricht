using ExpensesTracker;
do
{
    Console.WriteLine("-_-_-_-_-Expenses Tracker-_-_-_-_-");
    Console.WriteLine("Was willst du tun?");
    Console.WriteLine("\t1. Neue Ausgabe angeben");
    Console.WriteLine("\t2. Eine Ausgabe löschen");
    var input = Console.ReadLine(); 
    switch (input)
    {
        case "1":
            Console.WriteLine("neu");
            Console.WriteLine("Wofür hast du Geld ausgegben?");
            var  name = Console.ReadLine();
            Console.WriteLine("Wieviel hast du ausgegeben?");
            var price = Console.ReadLine();
            var decimalPrice = decimal.Parse(price);
            Console.WriteLine("In welche Kategorie willst du dieses Expense einordnen?");
            var category = Console.ReadLine();
            var newExpense = new Expense(name, decimalPrice, category);
            Console.WriteLine("Du hast folgendes Expense erstellt"); 
            Console.WriteLine($"\tname: {newExpense.Name}");
            Console.WriteLine($"\tname: {newExpense.Price}");
            Console.WriteLine($"\tname: {newExpense.Category}");
            break;
        case "2":
            Console.WriteLine("entfernen");
            break;
    }
    Thread.Sleep(2000);
    Console.Clear();
} while (true);