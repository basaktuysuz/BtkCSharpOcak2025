//Main************************************************

Ogrenci ogrenci =new();
ogrenci.ad="Başak";
ogrenci.numara=123;

Ogrenci ogrenci2 =new();
ogrenci2.ad="Erem";
ogrenci2.numara=456;

Console.WriteLine($"Yeni Öğrenci Numara:{ogrenci.numara} ad:{ogrenci.ad}");
Console.WriteLine($"Diğer Öğrenci Numara:{ogrenci2.numara} ad:{ogrenci2.ad}");


///***************************************************
class Ogrenci //Sınıfı tanımladık
{
    public int numara;
    public string ad;
}
