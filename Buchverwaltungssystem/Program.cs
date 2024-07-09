using Buchverwaltungssystem;

var book1 = new Book("Sie nannten micht >Es<", "David Pelzer", 2000, "9783442150557");

book1.Title = "Sie nannten mich >Es<";
book1.Author = "David Pelzer";
book1.Publicationyear = 2000;
book1.Isbn = "9783442150557";

book1.GetDescription("test");

