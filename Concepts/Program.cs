using Concepts;

var stringtest = "HudeBuxte";
var person1 =  new Person();

stringtest.ToLower();

person1.Vorname = "Michael";
person1.Nachname = "Lutz";
person1.Greet("Hallo");

Console.WriteLine($"{person1}"); // druckt namespace.klasse
//Console.WriteLine(person1);

//example namespace datatype
//System.Collections.Generic[Concepts.Person]
List<Person> people = new List<Person>();
Console.WriteLine(people);