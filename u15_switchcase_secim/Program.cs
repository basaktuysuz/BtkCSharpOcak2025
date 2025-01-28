Console.WriteLine("Dönem sonu ortalamayı girin");
int ort =Convert.ToInt32(Console.ReadLine());

string durum = ort switch{
    >= 85 => "Takdir",
    >= 70 => "Teşekkür", 
    >= 50 => "Sınıfı Geçti",
    _ => "Sınıfta kaldı"
 };

//durum = ort >= 85 ? "TAKDİR": ort>=70 ? "TEŞEKKÜR" : ort >=50 ? "SINIFI GEÇTİ":"SINIFTA KALDI";

Console.WriteLine($"{durum}");
