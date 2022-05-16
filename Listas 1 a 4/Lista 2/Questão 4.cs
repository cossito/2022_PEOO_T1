using System;
class Program {
  public static void Main() {
    Console.WriteLine("Digite a base e a altura do retângulo");
    string b = Console.ReadLine();
    string h = Console.ReadLine();
    double a = double.Parse(b);
    double c = double.Parse(h);
    double area = a * c;
    double perim = 2 * a + 2 * c;
    double diag = Math.Sqrt(a * a + c * c);
    Console.WriteLine($"Área = {area:0.00} - Perímetro = {perim:0.00} - Diagonal = {diag:0.00}");
  }
}
