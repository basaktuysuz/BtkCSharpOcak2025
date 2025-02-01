// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using u52_ef_telefon_rehberi;
using u52_ef_telrehberi;

Console.WriteLine("************Rehber uygulaması************");


Db db = new();
if (db.Database.GetPendingMigrations().Count() > 0)// uygulanmamış değişiklikler varsa
{

    /* string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
     string dbFolder = desktop + "\\rehber veritabanı";
     if (!Directory.Exists(dbFolder))
     {
         Directory.CreateDirectory(dbFolder);

     }
     */

    db.Database.Migrate();
    Console.WriteLine("Veritabanı Oluşturuldu/Güncellendi.....");
}

//CRUD 
do
{

    Console.WriteLine("1- Yeni kayıt");
    Console.WriteLine("2- Listele");
    Console.WriteLine("3- Güncelle");
    Console.WriteLine("4- Sil");
    Console.WriteLine("0- Çıkış");
    Console.WriteLine("Lütfen Seçiminizi giriniz");
    int secim = Convert.ToInt32(Console.ReadLine());


    if (secim == 1)
    {
        YeniKayitEkrani.Goster(db);
    }
    else if (secim == 2)
    {
        ListelemeEkrani.Goster(db);
    }
    else if (secim == 3)
    {
        GüncelleEkrani.Goster(db);
    }
    else if (secim == 4)
    {
        SilmeEkranı.Goster(db);
    }
    else if (secim == 0)
    {
        Console.WriteLine("Uygulamadan çıkış yapılıyor....");
        break;
    }
    else
    {
        Console.WriteLine("!!!! Hatalı seçim !!!!");
    }
}
while (true);



///Tüm kayıtları silmek için
/*
List<Kisi> liste = baglanti.Kisiler.ToList();
baglanti.Kisiler.RemoveRange(liste);
baglanti.SaveChanges();
*/