//string userName = Environment.UserName;
//Console.WriteLine($"Hallo {userName} wir spielen eine Runde FizzBuzz");

//for (int i = 1 ; i < 101 ; i++)
//{
//    if (i % 3 == 0 && i % 5 != 0)
//    {
//        Console.WriteLine("Fizz");
//    }
//    else if (i % 3 == 0 && i % 5 == 0)
//    {
//        Console.WriteLine("FizzBuzz!");
//    }
//    else if (i % 5 == 0 && i % 3 != 0)
//    {
//        Console.WriteLine("Buzz");
//    }
//    else
//    {
//    Console.WriteLine(i);
//    }
//}
string userName = Environment.UserName;
Console.WriteLine($"Hallo {userName} wir spielen eine Runde FizzBuzz");
int[] zahlen = new int[101];
for (int i = 1; i < zahlen.LongLength; i++)
{
    zahlen[i] = i;
   
}
foreach (int j in zahlen)
    if (j % 3 == 0 && j % 5 != 0)
    {
        Console.WriteLine("Fizz");
    }
    else if (j % 3 == 0 && j % 5 == 0)
    {
        Console.WriteLine("FizzBuzz!");
    }
    else if (j % 5 == 0 && j % 3 != 0)
    {
        Console.WriteLine("Buzz");
    }
    else
    {
        Console.WriteLine(j);
    }

//string userName = Environment.UserName;
//Console.WriteLine($"Hallo {userName} wir spielen eine Runde FizzBuzz");
//int[] zahlen = new int[101];
//for (int i = 1; i < zahlen.Length; i++)
//{
//    if (i % 3 == 0 && i % 5 != 0)
//    {
//        Console.WriteLine("Fizz");
//    }
//    else if (i % 3 == 0 && i % 5 == 0)
//    {
//        Console.WriteLine("FizzBuzz!");
//    }
//    else if (i % 5 == 0 && i % 3 != 0)
//    {
//        Console.WriteLine("Buzz");
//    }
//    else
//    {
//        Console.WriteLine(i);
//    }
//}