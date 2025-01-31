
List<Ogrenci> ogrencilerListi = new();



int num = 0;
int toplam = 0; //hiç bir sayı girilmesiği için 0

do
{
    Console.WriteLine("Eklenecek numara:");
    num = Convert.ToInt32(Console.ReadLine());

    if (num == 0)
        break;

    Console.WriteLine("Eklenecek İsim:");
    string ad = Console.ReadLine();

    Console.WriteLine("Eklenecek ortalama:");
    double ort = Convert.ToDouble(Console.ReadLine());

    Ogrenci ogrenci = new();
    ogrenci.numara = num;
    ogrenci.isim = ad;
    ogrenci.ortalama = ort;


    ogrencilerListi.Add(ogrenci);


} while (true);

foreach (Ogrenci o in ogrencilerListi)
{
    Console.WriteLine($"Nu: {o.numara} isim:{o.isim} ort:{o.ortalama}");
   // Console.WriteLine(ogrencilerListi[0]);

}


class Ogrenci //Sınıfı tanımladık
{
    public int numara;
    public string isim;
    public double ortalama;
}
