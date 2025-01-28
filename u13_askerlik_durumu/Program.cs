Console.WriteLine("Yaşınız:");
int yas = Convert.ToInt32( Console.ReadLine());

Console.WriteLine("Cinsiyetiniz [E/K]: ");
char cinsiyet = Convert.ToChar( Console.ReadLine());

if((cinsiyet == 'E' || cinsiyet == 'e') && yas>= 20){
    Console.WriteLine("Askere gidebilir...");
}
else
{
      Console.WriteLine("Askere gidemez...");

      if(yas < 20 && cinsiyet !='E' && cinsiyet !='e'){
        Console.WriteLine("Yaşınız ve Cinsiyetiniz  Uygun Değil...");
      }
      else if (yas < 20){
        Console.WriteLine("Yaşınız Uygun Değil...");
      }
      else{
        Console.WriteLine("Cinsiyetiniz  Uygun Değil...");
      }
      
}


/*
if(cinsiyet=='K' || yas < 20)
{
    Console.WriteLine("ASKERE GİDEMEZ......");
}
else
{
    Console.WriteLine("ASKERE GİDEBİLİR......");
}
*/