int[] sayilar = [4,8,2,1,-3];
Console.WriteLine("dizideki eleman sayısı: "+ sayilar.Length);
Console.Write("dizideki sayılar: ");
for(int i =0 ; i<sayilar.Length;i++){

Console.Write($"{sayilar[i]},");
}
int toplam=0;

foreach(int sayi in sayilar){
    toplam+=sayi;

}
Console.WriteLine("\nDizideki satıların toplamı: "+ toplam);