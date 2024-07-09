using Fahrzeugverwaltungssystem;
using System.Net.Mail;

var car1 = new Car("KIA", "Niro", 2019, 62000);
var car2 = new Car("VW", "Tiguan", 2018, 70000);

car1.GetDescription("Test");
car1.Drive(12);
car1.Age(12, " ");

car2.GetDescription("Test");
car2.Drive(12);
car2.Age(12, " ");