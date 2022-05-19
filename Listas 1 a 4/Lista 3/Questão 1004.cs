using System;
class Program {
  public static void Main() {
    string a = Console.ReadLine();
    string b = Console.ReadLine();
    int c = int.Parse(a);
    int d = int.Parse(b);
    int prod = c * d;
    Console.WriteLine("PROD = " + prod);
  }
}