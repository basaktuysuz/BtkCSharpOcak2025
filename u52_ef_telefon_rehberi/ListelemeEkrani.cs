using System;
using System.IO.Pipes;

namespace u52_ef_telefon_rehberi;

public class ListelemeEkrani
{

public static void Goster(Db baglanti){

Console.WriteLine("Listeleme ekranı");
//READ
List<Kisi> liste= baglanti.Kisiler.ToList();

 //-------------------------------------------
        foreach(Kisi kisi in liste)
        {
            Console.WriteLine($"{kisi.Id} - {kisi.Ad} {kisi.Soyad}"+
            $" - {kisi.Tel} - {kisi.Adres}");
        }
        Console.WriteLine("Kişiler listelendi.");
        Console.WriteLine("Devam etmek için bir tuşa bas...");
        Console.ReadKey();
}
}
