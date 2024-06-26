string userName = Environment.UserName;
Console.WriteLine($"Hallo {userName} wir spielen eine Runde FizzBuzz");
int[] zahlen = new int[100];
for (int i = 0 ; i < zahlen.Length; i++)
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