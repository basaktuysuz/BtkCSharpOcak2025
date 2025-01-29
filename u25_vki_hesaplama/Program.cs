Console.WriteLine("Kilonuzu girin (kg)");
double kilo= Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Boyunuzu girin (cm)");
double boy= Convert.ToDouble(Console.ReadLine());

double boyMetre = boy/100;

double vki = kilo/(boyMetre*boyMetre);

Console.WriteLine($"Vki :  {vki:f2}");

if(vki <18.5){
    Console.WriteLine("Zayıf.....");
}
else if(vki >= 18.5 && vki<25){
    Console.WriteLine("Normal....."); 
}
else if(vki >= 25 && vki<30){
    Console.WriteLine("Kilolu....."); 
}
else
    Console.WriteLine("Aşırı Kilolu....."); 
