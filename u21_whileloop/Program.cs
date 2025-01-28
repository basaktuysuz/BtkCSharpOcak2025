//klavyeden 0 girilmiş olana kadar sayıları toplayan bir örnek

int sayi = 0;
int toplam = 0;
do 
{
    Console.WriteLine("Bir sayı girin ");
    sayi = Convert.ToInt32( Console.ReadLine());
    toplam += sayi;
   
}
while (sayi != 0);
Console.WriteLine($"Toplam: {toplam} ");