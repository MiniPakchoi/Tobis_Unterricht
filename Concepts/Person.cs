namespace Concepts
{
    /// <summary>
    /// Eine Klasse ist ein selbst-definierter Datentyp.
    /// Eine Klasse instanziiert ein Objekt vom Typ der Klasse.
    /// Eine Klasse besitzt Eigenschaften und Methoden.
    /// Vor dem Keyword class (oder dem Return-Type einer Funktion/Methode) lässt sich ein Access-Modifier definieren:
    ///   Access-Modifier definieren an welchen Stellen im Code die jeweilige Klasse oder Methode oder Eigenschaft sich aufrufen lässt.
    ///   Valide Access-Modifier in C#: internal, private, public, protected
    ///   
    /// PS: Keine Access-Modifier für Namespaces
    /// </summary>
    internal class Person
    {
        // Eigenschaft => Eine Variable für diese Objekt
        // Auch Eigenschaften haben Access-Modifier
        internal string Vorname = "";
        internal string? Nachname; // Dieser string ist nullable => kann uninitialisiert sein.

        /// <summary>
        /// Konstruktor für die Klasse.
        /// Ein Konstruktor erstellt für uns eine Instant (Objekt) von diesem Klasse (Datentyp)
        /// </summary>
        public Person(string vorname, string nachname)
        {
            // Jetzt wo wir einen Konstruktor haben, müssen unsere Vor- und Nachnamen-Variablen nicht mehr nullable sein.
            //  => Weil der Konstruktor sicherstellt, dass beim Erstellen einer Person der vorname und nachname als Parameter übergeben werden müssen.
            Vorname = vorname;
            Nachname = nachname;
        }

        // Methode => Eine Aktion, welche mein Objekt tätigen kann
        internal void Greet(string greeting)
        {
            Console.WriteLine(Vorname + " " + Nachname + " Begrüßt dich mit: " + greeting);
        }
    }

    
}