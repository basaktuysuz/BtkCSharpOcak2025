//kullanıcının girdiği yükseklik  üçgen çiz
// yükseklik i oluyor

Console.WriteLine("Yükseklik girin:");
int yükseklik  = Convert.ToInt32( Console.ReadLine());
    

for(int i =0;i<yükseklik; i++){
    for(int j=0;j<i+1;j++ ){
        Console.Write("*");
    }
    Console.WriteLine("");
}