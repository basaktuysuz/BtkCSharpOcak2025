Console.WriteLine("Metin girin");
string metin = Console.ReadLine();
Stack<char> yigin = new();
foreach (char m in metin)
{
    yigin.Push(m);
}
Console.WriteLine($"\ntersi ({yigin.Count})");
while (yigin.Count > 0)
{
    char eleman = yigin.Pop();//yığından çıkar
    Console.Write($"{eleman}");
}