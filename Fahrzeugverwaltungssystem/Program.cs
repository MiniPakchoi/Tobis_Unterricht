using Fahrzeugverwaltungssystem;
using System.Diagnostics.Metrics;

var car1 = new Car("KIA", "Niro", 2019, 62000); // Instanzierung der Klasse
var car2 = new Car("VW", "Tiguan", 2018, 70000); // Instanzierung der Klasse

// Erstes Auto
Console.WriteLine(car1.GetDescription());
Console.WriteLine("Wieviel Km bist du gefahren?");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Du bist"+ " " + x + "km gefahren, dein neuer Kilometerstand beträgt"+ " " + car1.Drive(x) + " " + "km.");
Console.WriteLine("Dein Auto ist"+ " " + car1.Age() + "  " + "Jahre alt.");

//Zweites Auto
Console.WriteLine(car2.GetDescription());
Console.WriteLine("Wieviel Km bist du gefahren?");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Du bist" + " " + y + "km gefahren, dein neuer Kilometerstand beträgt" + " " + car1.Drive(y) +" " + "km.");
Console.WriteLine("Dein Auto ist" + " " + car1.Age() + "  " + "Jahre alt.");
