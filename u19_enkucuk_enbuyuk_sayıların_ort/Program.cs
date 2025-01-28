int büyük = int.MinValue ;
int küçük = int.MaxValue  ;
for(int i = 0; i<5 ; i++){

    Console.WriteLine($"{i+1}. sayıyı girin:");
    int sayi = Convert.ToInt32( Console.ReadLine());
    

    if(sayi>büyük)
        büyük= sayi;
        
    if(sayi<küçük)
        küçük= sayi;
    
    
}

Console.WriteLine($"En Büyük {büyük}, en küçük { küçük}");
