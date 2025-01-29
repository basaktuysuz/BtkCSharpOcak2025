
// using Dictionary<TKey,TValue> class
Dictionary<int, string> ogrenciler =
               new Dictionary<int, string>();

// Adding key/value pairs 
// in the Dictionary
// Using Add() method
ogrenciler.Add(1123, "Welcome");
ogrenciler.Add(1124, "to");
ogrenciler.Add(1125, "GeeksforGeeks");


int num = 0;
string ad = " ";

do
{
    if (num != 0)
    {
        Console.WriteLine("Eklenecek öğrenci numarası");
        num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Eklenecek öğrenci Adı");
        ad = Console.ReadLine();

        ogrenciler.Add(num, ad);
    }
}
while (num != 0);
Console.WriteLine("Tüm Öğrenciler");
foreach(var ogr in ogrenciler)
{
    Console.WriteLine ($"{ogr.Key} - {ogr.Value}");
}