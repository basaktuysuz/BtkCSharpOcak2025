using System;

namespace Web_App.Models;
public class Kisi //Veritabanı tablonun modeli
{
    public int Id { get; set; }
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public string Tel { get; set; }
    public string Adres { get; set; }
}
