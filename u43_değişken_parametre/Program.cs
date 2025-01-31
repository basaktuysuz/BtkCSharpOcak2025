//varsayılan değişken parametre
double ücretHesapla(double fiyat, double miktar = 1, double indirim = 0)
{
    double tutar = fiyat * miktar;
    if (indirim > 0)
    {
        tutar = tutar - tutar * (indirim / 100);

    }

    return tutar;
}

void altaltayaz(params string[] liste)
{
    foreach (string str in liste)
        Console.WriteLine(str);
}

Console.WriteLine($"Ücret: {ücretHesapla(16)}");
Console.WriteLine($"Ücret: {ücretHesapla(16, 10)}");
Console.WriteLine($"Ücret: {ücretHesapla(16, 10, 20)}");

altaltayaz("İzmir", "Ankara", "İstanbul", "Aydın");