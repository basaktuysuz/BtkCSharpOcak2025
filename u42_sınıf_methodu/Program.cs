using u42_sınıf_methodu;

Konsol kon = new();

kon.temizle(ConsoleColor.DarkMagenta);

int sayı =kon.sayiOku("Bir sayı girin....");
int sayı2 =kon.sayiOku("Başka bir sayı girin....");

kon.yazSatir($"Toplam = {sayı+sayı2}");