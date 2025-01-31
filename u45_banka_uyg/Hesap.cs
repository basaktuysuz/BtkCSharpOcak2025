using System;

using u45_banka_uyg;

public class Hesap
{

    public int HesapNo { get; set; }
    
    public string HesapTürü { get; set; }
    public double Bakiye { get; set; }


public void yazdır(){
    Console.WriteLine($"Müsteri numarası : {HesapNo} Hesap Türü:{HesapTürü} Bakiye: {Bakiye}");
    }
}
