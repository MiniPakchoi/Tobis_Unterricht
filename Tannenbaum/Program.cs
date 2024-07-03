
/// Eine Funktion, welche einen Weihnachtsbaum in der Konsole druckt.
/// Input: Wie gewünscht
/// Output: 
///    #
///   ###
///  #####
/// #######
///    #
/// </summary>
Console.WriteLine("Wie hoch soll der Baum werden?");
int h = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < h; i++)
{
    for (int j = h; j > i; j--)
    {
        Console.Write(" ");
    }
    for (int k = 0; k < i; k++)
    {
        Console.Write("#");
    }
    for (int m = 0; m < i; m++)
    {
        Console.Write("#");
    }
    Console.Write("\n");
}