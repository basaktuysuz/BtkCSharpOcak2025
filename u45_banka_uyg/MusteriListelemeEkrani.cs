using System;

using u45_banka_uyg;

public class MusteriListelemeEkrani
{
    public static void goster(List<Musteri> liste)
    {
        Console.Clear();
        Console.WriteLine("Müşteri Listesi");

        foreach (Musteri m in liste)
        {
            m.Yazdir();
        }

        Console.WriteLine("Müsteriler listelendi.Devam etmek için tuşa bas");
        Console.ReadKey();
    }
}
