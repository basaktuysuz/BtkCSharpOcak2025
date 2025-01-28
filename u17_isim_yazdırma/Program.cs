
Console.WriteLine("Adınız:  ");
string isim =  Console.ReadLine();

Console.WriteLine("Yaşınız:");
int yas = Convert.ToInt32( Console.ReadLine());


for(int i = 1;i<=yas ;i++){
Console.WriteLine($"{i}. {isim}");
}