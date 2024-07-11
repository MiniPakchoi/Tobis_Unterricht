
using System.Threading.Channels;

List<int> onlyEven = new() { 1, 2, 3, 4, 5, 6, 7};
List<int> even = new List<int>();
for (int i = 1; i < onlyEven.Count; i++)
{
        if (i % 2 == 0 )
        {
        even.Add(i);
        Console.WriteLine(i);
        }

    return;
}

