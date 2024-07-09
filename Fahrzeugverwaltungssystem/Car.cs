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

        internal string GetDescription()
        {
            return Brand + " " + Model + " " + "Jahr:" + Year + " " + "mit" + " " + Mileage + " " + "km gefahren";
        }

        internal int Drive(int mileage) 
        { 
            int sumKm = Mileage + mileage;
            return sumKm;
        }

        internal int Age() 
        {
            int year = Year;
            int actualYear = 2024;
            int alter = actualYear - year;
            return alter;
        }
    }
}
