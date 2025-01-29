// See https://aka.ms/new-console-template for more information
Console.WriteLine("Faktöryelini bulmak istediğiniz sayıyı girin:");
int sayi = Convert.ToInt32(Console.ReadLine());


if(sayi>=0){
    ulong sonuc =1;

    for (int i =sayi; i>=1 ;i--){
        sonuc=sonuc* (ulong)i;

    }
    
    if(sayi ==0){
    sonuc = 1;
    }
    Console.WriteLine($"{sonuc}");

}
else
    Console.WriteLine("Negatif sayıların faktöryeli Yoktur.");

while(sayi>=0){

}
