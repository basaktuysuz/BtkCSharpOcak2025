Console.WriteLine("Gün giriniz 1-7 ");
int day =Convert.ToInt32(Console.ReadLine());

switch (day) 
{
  case 1:
    Console.WriteLine("Monday");
    break;
  case 2:
    Console.WriteLine("Tuesday");
    break;
  case 3:
    Console.WriteLine("Wednesday");
    break;
  case 4:
    Console.WriteLine("Thursday");
    break;
  case 5:
    Console.WriteLine("Friday");
    break;
  case 6:
    Console.WriteLine("Saturday");
    break;
  case 7:
   Console.WriteLine("Sunday");
    break;
  default:
  Console.WriteLine("Hatalı Giriş");
  break;
}
// Outputs "Thursday" (day 4)

switch (day) 
{
  case 1: case 2: case 3: case 4: +case 5:
    Console.WriteLine("Week days");
    break;
  case 6:
  case 7:
   Console.WriteLine("Weekend");
    break;
}