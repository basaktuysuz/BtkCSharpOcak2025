using System;

namespace u42_sınıf_methodu;

public class Konsol
{
    public void temizle()
    {//parametresi yok
        Console.BackgroundColor = ConsoleColor.Black;
        Console.Clear();
    }
    public void temizle(ConsoleColor consoleColor)
    {//parameteresi var overloaded 

        Console.BackgroundColor = consoleColor;
        Console.Clear();
    }
    public void yazSatir(string metin)
    {
        Console.WriteLine(metin);
    }
    public string metinOku()
    {
        return Console.ReadLine();
    }
    public int sayiOku()
    {
        return Convert.ToInt32(Console.ReadLine());
    }

    public int sayiOku(string mesaj)
    {
        yazSatir(mesaj);
        return Convert.ToInt32(Console.ReadLine());
    }
}
