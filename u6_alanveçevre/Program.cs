
Console.Write("Dörtgenin a kenarını girin : ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Dörtgenin b kenarını girin : ");
int b = Convert.ToInt32(Console.ReadLine());

var cevre = (a+b)*2;
var alan = (a*b);

Console.Write("Dikdörtgenin kenarları ");
//Console.WriteLine(string.Format("{0}cm  ve {1}cm  ", a, b));

Console.WriteLine($"Kenarları {a}cm  ve {b}cm  olan Dörtgenin alanı {a} * {b} = {alan}'cmdir");//string interpolation

Console.WriteLine($"Kenarları {a}cm  ve {b}cm  olan Dörtgenin Çevresi {cevre}'cmdir");//string interpolation