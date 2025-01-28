
Console.WriteLine("Birinci Sayıyı gir");
int s1 = Convert.ToInt32( Console.ReadLine());


Console.WriteLine("İkinci Sayıyı gir");
int s2 = Convert.ToInt32( Console.ReadLine());

if(s1 > s2){
    Console.WriteLine($"{s1} {s2} sayısından büyüktür.");
    Console.WriteLine($"{s1} Büyük olan sayı, {s2} Küçük olan sayıdır.");
}
else if (s1 < s2){
    
    Console.WriteLine($"{s2} {s1} sayısından büyüktür.");
    Console.WriteLine($"{s2} Büyük olan sayı, {s1} Küçük olan sayıdır.");
}
else{
    Console.WriteLine("Sayılar Eşittir");
}