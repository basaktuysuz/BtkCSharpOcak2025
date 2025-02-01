using System;

namespace u52_ef_telefon_rehberi;

public class Kisi //Veritabanı tablonun modeli
{
    public int Id { get; set; }
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public string Tel { get; set; }
    public string Adres { get; set; }
}
