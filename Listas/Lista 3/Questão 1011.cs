using System;
class Program {
  public static void Main() {
    string a = Console.ReadLine();
    double r = double.Parse(a);
    double vol = (4.0/3) * 3.14159 * Math.Pow(r, 3);
    Console.WriteLine($"VOLUME = {vol:0.000}");
  }
}