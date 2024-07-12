using StaticVSInstance;

int numberInput1 = 0;
int numberInput2 = 0;
int numberInput3 = 0;
int numberInput4 = 0;
int numberInputRadius = 0;
int result = 0;
/*

Calculator c = new Calculator();
c.GetNumberInput("test");

Calculator c2 = new Calculator();
c2.GetNumberInput("dksfj");
c2.Count
*/
/*
Calculator mixed = new Calculator();
mixed.Title = "Hexenwerk!";
*/
// Wenn wir die Methoden des Taschenrechners statisch machen, müssen wir keine Instanz (Objekt) der Klasse Calculator (eg. var calc = new Calculator()) erstellen.
/*
Calculator calculator = new Calculator();
calculator.Title = "Mein cooler Taschenrechner";
Calculator.Title = "Geht nicht, weil keine Instanz.";
calculator.Count = "Gibt es nicht auf der Instanz...";
Calculator.Count = 10;

calculator.Add(10,20);

Calculator calculator1 = new Calculator();
calculator1.Add(20, 30);

Calculator calc1 = new Calculator();
Calculator calcSubtract = new Calculator();

*/

/*
 Beispiel für einen Datentyp (Klasse) mit statischen- und Instanzmembern. Member => Property, Methods, private Fields
 */
int x = 0;
x.ToString();
var parsed = int.Parse("1");

do
{
    Console.Clear();
    Console.WriteLine("Was willst du rechnen?");
    Console.WriteLine("\t1.Add\n\t2.Subtract\n\t3.Multiply\n\t4.Divide\n\t5.TriangleArea\n\t6.TriangleCircumference\n\t7.CircleArea\n\t8.CircleCircumference\n\t9.RectangleArea\n\t10.RectangleCircumference\n\t11.TrapezoidArea\n\t12.TrapezoidCircumference");
    var menuInput = Console.ReadLine(); 
    int menuInputIndex = int.Parse(menuInput);
    if (menuInputIndex == 1 || menuInputIndex == 2 || menuInputIndex == 3|| menuInputIndex == 4 ||  menuInputIndex == 9 || menuInputIndex == 10)
    {
        numberInput1 = Calculator.GetNumberInput("Gebe die erste Zahl ein: ");
        numberInput2 = Calculator.GetNumberInput("Gebe die zweite Zahl ein: ");   
    }  
    else if (menuInputIndex == 5)
    {
        numberInput1 = Calculator.GetNumberInput("Gib die Höhe deines Dreiecks an ");
        numberInput2 = Calculator.GetNumberInput("Gib die Länge der Hypothenuse ein: ");
    }
    else if (menuInputIndex == 6)
    {
        numberInput1 = Calculator.GetNumberInput("Gebe die erste Zahl ein: ");
        numberInput2 = Calculator.GetNumberInput("Gebe die zweite Zahl ein: ");
        numberInput3 = Calculator.GetNumberInput("Gebe die dritte Zahl ein: ");
    }
    else if (menuInputIndex == 7 || menuInputIndex == 8)
    {
        numberInputRadius = Calculator.GetNumberInput("Gebe  den Radius ein: ");
    }
    else if(menuInputIndex == 11)
    {
        numberInput1 = Calculator.GetNumberInput("Gebe die Seite a ein: ");
        numberInput2 = Calculator.GetNumberInput("Gebe die Seite c ein: ");
        numberInput3 = Calculator.GetNumberInput("Gebe die Höhe ein: ");
    }
    else if (menuInputIndex == 12)
    {
        numberInput1 = Calculator.GetNumberInput("Gebe die Seite a ein: ");
        numberInput2 = Calculator.GetNumberInput("Gebe die Seite b ein: ");
        numberInput3 = Calculator.GetNumberInput("Gebe die Seite c ein: ");
        numberInput4 = Calculator.GetNumberInput("Gebe die Seite d ein: ");
    }

    Operator op = (Operator)menuInputIndex;
    switch (op)
    {
        case Operator.Add:
            //Calculator.
            // var numberInput1 = Calculator.GetInput();
            Calculator.Calculate(numberInput1, numberInput2,numberInput3, numberInput4, numberInputRadius, Operator.Add);
            break;
        case Operator.Subtract:
            Calculator.Calculate(numberInput1, numberInput2, numberInput3, numberInput4, numberInputRadius, Operator.Subtract);
            break;
        case Operator.Multiply:
            Calculator.Calculate(numberInput1, numberInput2, numberInput3, numberInput4, numberInputRadius, Operator.Multiply);
            break;
        case Operator.Divide:
            Calculator.Calculate(numberInput1, numberInput2, numberInput3, numberInput4, numberInputRadius, Operator.Divide);
            break;
        case Operator.TriangleArea:
            Calculator.Calculate(numberInput1, numberInput2, numberInput3, numberInput4, numberInputRadius, Operator.TriangleArea);
            break;
        case Operator.TriangleCircumference:
            Calculator.Calculate(numberInput1, numberInput2, numberInput3, numberInput4, numberInputRadius, Operator.TriangleCircumference);
            break;
        case Operator.CircleArea:
            Calculator.Calculate(numberInput1, numberInput2, numberInput3, numberInput4, numberInputRadius, Operator.CircleArea);
            break;
        case Operator.CircleCircumference:
            Calculator.Calculate(numberInput1, numberInput2, numberInput3, numberInput4, numberInputRadius, Operator.CircleCircumference);
            break;
        case Operator.RectangleArea:
            Calculator.Calculate(numberInput1, numberInput2, numberInput3, numberInput4, numberInputRadius, Operator.RectangleArea);
            break;
        case Operator.RectangleCircumference:
            Calculator.Calculate(numberInput1, numberInput2, numberInput3, numberInput4, numberInputRadius, Operator.RectangleCircumference);
            break;
        case Operator.TrapezoidArea:
            Calculator.Calculate(numberInput1, numberInput2, numberInput3, numberInput4, numberInputRadius, Operator.TrapezoidArea);
            break;
        case Operator.TrapezoidCircumference:
            Calculator.Calculate(numberInput1, numberInput2, numberInput3, numberInput4, numberInputRadius, Operator.TrapezoidCircumference);
            break;

    }

} while (true);

// void test() { } // Program.test() // auch eine Methode, weil gehört zur Program-Klasse