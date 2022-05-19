using System;
class Program {
  public static void Main() {
    string s = Console.ReadLine();
    string[] v = s.Split(' ');
    double a = double.Parse(v[0]);
    double b = double.Parse(v[1]);
    double c = double.Parse(v[2]);
    double areatri = (a * c) / 2;
    double areacir = 3.14159 * (c * c);
    double areatrap = ((a + b) * c) / 2;
    double areaquad = b * b;
    double arearet = a * b;
    Console.WriteLine($"TRIANGULO: {areatri:0.000}");
    Console.WriteLine($"CIRCULO: {areacir:0.000}");
    Console.WriteLine($"TRAPEZIO: {areatrap:0.000}");
    Console.WriteLine($"QUADRADO: {areaquad:0.000}");
    Console.WriteLine($"RETANGULO: {arearet:0.000}");
  }
}