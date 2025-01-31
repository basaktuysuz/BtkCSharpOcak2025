int Topla(int a, int b)
{
    int sonuc = a + b;
    return sonuc;
}

void ekranıTemizle()
{
    Console.Clear();
}

void bekle()
{
    Console.WriteLine("Çıkmak için bir tuşa basın....");
    Console.ReadKey();
}

int toplamDeğer = Topla(9, 21);
int toplamDeğer2 = Topla(15, 89);
ekranıTemizle();

Console.WriteLine($"toplam değer : {toplamDeğer}.");
Console.WriteLine($"toplam değer2 : {toplamDeğer2}.");
bekle();
