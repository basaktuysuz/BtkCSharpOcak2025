using System;
using System.Security.Cryptography.X509Certificates;

namespace u52_ef_telefon_rehberi;

public class SilmeEkranı
{
    public static void Goster(Db baglanti)
    {
        Console.WriteLine("Silme Ekranı");//****

        Console.WriteLine("Silinecek kişinin Id:");//****
        int id = Convert.ToInt32(Console.ReadLine());//****

        //READ--------------
        Kisi kisi = baglanti.Kisiler.Find(id);//*****
        //Kisi kisi = new();
        if (kisi == null)//****
        {
            Console.WriteLine("Kişi bulunamadı!");//****
            return;//****
        }
        //Delete
        baglanti.Kisiler.Remove(kisi);
        baglanti.SaveChanges();

        Console.WriteLine("Kişi Silindi!");
        Console.WriteLine("Devam etmek için bir tuşa bas...");
        Console.ReadKey();

    }

}
