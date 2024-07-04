//string zeichenkette = "Lagerregal";
//char[] charArray = zeichenkette.ToCharArray();
//Array.Reverse(charArray);
//Console.WriteLine(charArray);


string zeichenkette = "Lagerregal";

int j = zeichenkette.Length - 1;
while(j >= 0)
{
    Console.Write(zeichenkette[j]);
    Console.Write(' ');
    j--;
}