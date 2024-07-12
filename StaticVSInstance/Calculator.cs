namespace StaticVSInstance
{
    public static class Calculator
    {
        /* Properties
        public string Title { get; set; }
        public int InstanceCount { get; set; }
        public string Title { get; set; }
        */
        public static int Count { get; set; }

        // Methoden
        public static int GetNumberInput(string inputPrompt) // Funktionssignatur -> Methodensignatur
        { // Function-Body -> Funktionskörper
            Console.Write(inputPrompt);
            return int.Parse(Console.ReadLine());
        }

        /* Calculate()
        Refactoring -> Umschreiben vom Code zum Verbessern der Performance, Lesbarkeit oder auch Wartbarkeit */
        public static double Calculate(double numberInput1, double numberInput2,double numberInput3,double numberInput4, double numberInputRadius, Operator op)
        {
            double result = 0;
            Count++;
            Console.ForegroundColor = ConsoleColor.Magenta;
            switch (op)
            {
                case Operator.Add: // 1
                    result = numberInput1 + numberInput2;
                    Console.WriteLine($"Das Ergebnis von {numberInput1} + {numberInput2} = {result}");
                    break;
                case Operator.Subtract: //2
                    result = numberInput1 - numberInput2;
                    Console.WriteLine($"Das Ergebnis von {numberInput1} - {numberInput2} = {result}");
                    break;
                case Operator.Multiply: //3
                    result = numberInput1 * numberInput2;
                    Console.WriteLine($"Das Ergebnis von {numberInput1} * {numberInput2} = {result}");
                    break;
                case Operator.Divide: // 4
                    result = numberInput1 / numberInput2;
                    Console.WriteLine($"Das Ergebnis von {numberInput1} / {numberInput2} = {result}");
                    break;
                case Operator.TriangleArea: //5
                    result = (numberInput1 * numberInput2) / 2;
                    Console.WriteLine($"Das Ergebnis von ({numberInput1} * {numberInput2}) / 2 = {result}");
                    break;
                case Operator.TriangleCircumference: // 6 hier noch 3ter Input hinzufügen, done
                    result = (numberInput1 + numberInput2 + numberInput3);
                    Console.WriteLine($"Das Ergebnis von {numberInput1} + {numberInput2} + {numberInput3} = {result}");
                    break;
                case Operator.CircleArea: // 7 hier nur 1 zahl verlangen
                    result = numberInputRadius * 3.14159265359;
                    Console.WriteLine($"Das Ergebnis von {numberInput1} * 3.14159265359 = {result}");
                    break;
                case Operator.CircleCircumference: // 8 Hier auch nur 1 zahl verlangen
                    result = numberInputRadius * 3.14159265359 * 2;
                    Console.WriteLine($"Das Ergebnis von 2 * 3.14159265359 * {numberInput1} = {result}");
                    break;
                case Operator.RectangleArea: // 9
                    result = (numberInput1) * (numberInput2);
                    Console.WriteLine($"Das Ergebnis von {numberInput1} * {numberInput2} = {result}");
                    break;
                case Operator.RectangleCircumference: // 10
                    result = (2 * numberInput1) + (2 * numberInput2);
                    Console.WriteLine($"Das Ergebnis von (2 * {numberInput1}) + (2 * {numberInput2}) = {result}");
                    break;
                case Operator.TrapezoidArea: // 11
                    result = ((numberInput1 + numberInput2) * numberInput3) / 2;
                    Console.WriteLine($"Das Ergebnis von (({numberInput1} * {numberInput2}) * {numberInput3}) / 2 = {result}");
                    break;
                case Operator.TrapezoidCircumference: // 12
                    result = numberInput1 + numberInput2 + numberInput3 + numberInput4;
                    Console.WriteLine($"Das Ergebnis von {numberInput1} + {numberInput2} +{numberInput3} + {numberInput4} = {result}");
                    break;
            }
            Console.ResetColor();
            Console.WriteLine($"Du hast {Count} Berechnungen getätigt.");
            Console.WriteLine("Drücke irgendwas für eine neue Berechnung");
            Console.ReadKey();
            return result;
        }

        public static int Add(int numberInput1, int numberInput2)
        {
            Count++;
            var result = numberInput1 + numberInput2;
            Console.WriteLine($"Das Ergebnis von {numberInput1} + {numberInput2} = {result}");
            Console.WriteLine($"Du hast {Count} Berechnungen getätigt.");
            Console.WriteLine("Drücke irgendwas für eine neue Berechnung");
            Console.ReadKey();
            return result;
        }

        public static int Subtract(int numberInput1, int numberInput2)
        {
            Count++;
            var result = numberInput1 - numberInput2;
            Console.WriteLine($"Das Ergebnis von {numberInput1} - {numberInput2} = {result}");
            Console.WriteLine($"Du hast {Count} Berechnungen getätigt.");
            Console.WriteLine("Drücke irgendwas für eine neue Berechnung");
            Console.ReadKey();
            return result;
        }

        public static int Multiply(int numberInput1, int numberInput2)
        {
            Count++;
            var result = numberInput1 * numberInput2;
            Console.WriteLine($"Das Ergebnis von {numberInput1} * {numberInput2} = {result}");
            Console.WriteLine($"Du hast {Count} Berechnungen getätigt.");
            Console.WriteLine("Drücke irgendwas für eine neue Berechnung");
            Console.ReadKey();
            return result;
        }

        public static int Divide(int numberInput1, int numberInput2)
        {
            Count++;
            var result = numberInput1 / numberInput2;
            Console.WriteLine($"Das Ergebnis von {numberInput1} / {numberInput2} = {result}");
            Console.WriteLine($"Du hast {Count} Berechnungen getätigt.");
            Console.WriteLine("Drücke irgendwas für eine neue Berechnung");
            Console.ReadKey();
            return result;
        }

 
        /// <summary>
        /// Das hier ist wie Add(), aber wird über die Instanz der Klasse (konkretes Objekt eg. "calc1.AddInstance") aufgerufen. Der InstanceCount ist für jede Instanz (Objekt) unterschiedlich (eg. calc1.InstanceCount != calc2.InstanceCount)
        /// </summary>
        /// <param name="numberInput1"></param>
        /// <param name="numberInput2"></param>
        /// <returns></returns>
        /*
        public int AddInstance(int numberInput1, int numberInput2)
        {
          InstanceCount++;
          var result = numberInput1 + numberInput2;
          Console.WriteLine($"Das Ergebnis von {numberInput1} + {numberInput2} = {result}");
          return result;
        }
        */


    }
    public enum Operator
    {
        Add = 1,
        Subtract = 2,
        Multiply = 3,
        Divide = 4,
        TriangleArea = 5,
        TriangleCircumference = 6,
        CircleArea = 7,
        CircleCircumference = 8,
        RectangleArea = 9,
        RectangleCircumference = 10,
        TrapezoidArea = 11,
        TrapezoidCircumference = 12,
    }
}