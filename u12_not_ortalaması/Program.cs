Console.WriteLine("Birinci Notu gir");
int not1 = Convert.ToInt32( Console.ReadLine());


Console.WriteLine("İkinci Notu gir");
int not2 = Convert.ToInt32( Console.ReadLine());


Console.WriteLine("Üçüncü Notu gir");
int not3 = Convert.ToInt32( Console.ReadLine());

double ort=(double) (not1+not2+not3)/3 ;

Console.WriteLine($"Ortalama :{ort:c1} ");

if(ort >= 49.5 ){
    Console.WriteLine("Başarılı");
}
else {
    Console.WriteLine("Başarısız");
}