namespace Fahrzeugverwaltungssystem
{
    internal class Car
    {
        internal string Brand;
        internal string Model;
        internal int Year;
        internal int Mileage;

        public Car(string brand,string model, int year, int mileage)
        { 
            Brand = brand;
            Model = model;
            Year = year;
            Mileage = mileage;
        }

        internal void GetDescription(string description)
        {
            Console.WriteLine(Brand + " " + Model + " " + "Jahr:" + Year + " " + "mit" + " " + Mileage + " " + "km gefahren");
        }

        internal void Drive(int gefahren) 
        {
            Console.WriteLine("Wieviel Km bist du gefahren?");
            int userInput = Convert.ToInt32(Console.ReadLine());
            int mileage = Mileage;
            int sumKm = userInput + mileage;
            Console.WriteLine(sumKm); 
        }

        internal void Age(int old,string text) 
        {
            int year = Year;
            int actualYear = 2024;
            int alter = actualYear - year;
            Console.WriteLine("Dein Auto ist"+ " " +alter + " " + "alt");
        }
    }
}
