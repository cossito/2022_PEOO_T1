using System;
class Program {
  public static void Main() {
    string a = Console.ReadLine();
    string b = Console.ReadLine();
    double c = double.Parse(a);
    double d = double.Parse(b);
    double media = (c * 3.5 + d * 7.5) / 11;
    Console.WriteLine($"MEDIA = {media:0.00000}");
  }
}