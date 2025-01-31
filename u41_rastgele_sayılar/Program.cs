int[] rastgeleUret()
{
    List<int> sonuc = new();
    Random rnd = new();

    while (sonuc.Count < 6)
    {

        int sayi = rnd.Next(1, 49 + 1);

        if (!sonuc.Contains(sayi))
        {
            sonuc.Add(sayi);
        }

    }
    return sonuc.ToArray();

}
void yazdır(int[] liste)
{
    foreach (int s in liste)
    {
        Console.Write($"{s},");

    }
    Console.WriteLine();
}

for (int i = 0; i < 6; i++)
{

    int[] sayılar = rastgeleUret();
    yazdır(sayılar);
}
