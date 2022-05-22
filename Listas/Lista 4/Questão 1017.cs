using System;
class Program {
  public static void Main() {
    string a = Console.ReadLine();
    string b = Console.ReadLine();
    double t = double.Parse(a);
    double v = double.Parse(b);
    double lit = (t * v) / 12;
    Console.WriteLine($"{lit:0.000}");
  }
}