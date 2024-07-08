using Concepts;

var stringtest = "HudeBuxte";
var person1 =  new Person("Michael","Lutz");

//Erstellen eines neuen Obejkts durch aufrufen einer Konstruktor-Methode
// var person2 = new Person ("Michael","Lutz");

stringtest.ToLower();
person1.Vorname = "Michael";
person1.Nachname = "Lutz";

person1.Greet("Hallo");

Console.WriteLine($"{person1}"); // druckt namespace.klasse
//Console.WriteLine(person1);

//example namespace datatype
//System.Collections.Generic[Concepts.Person]
/*
List<Person> people = new List<Person>();
List<int> ints;
List<DateTime> times;
Console.WriteLine(people);
*/