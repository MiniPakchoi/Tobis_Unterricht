namespace Buchverwaltungssystem
{
    internal class Book
    {
        internal string Title { get; set; }
        internal string Author { get; set; }
        internal int Publicationyear { get; set; }
        internal string Isbn { get; set; }

        public Book(string title, string author, int pulicationYear, string isbn)
        {
            Title = title;
            Author = author;
            Publicationyear = pulicationYear;
            Isbn = isbn;

        }

        internal void GetDescription(string description)
        {
            Console.WriteLine(Title + " " + Author + "veröffentlicht im Jahr: " + Publicationyear + " " + "ISBN:" + Isbn);
        }
    }
}
