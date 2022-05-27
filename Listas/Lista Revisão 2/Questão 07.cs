using System; 
public class Program {
  public static void Main() {
    Console.WriteLine("Digite os coeficientes a, b e c de uma equação do II grau");
    double a = double.Parse(Console.ReadLine());
    double b = double.Parse(Console.ReadLine());
    double c = double.Parse(Console.ReadLine());
    double delta = Math.Pow(b, 2) - (4 * a * c);
    double r1 = (-b + Math.Sqrt(delta)) / (2 * a);
    double r2 = (-b - Math.Sqrt(delta)) / (2 * a);
      if (a != 0 && delta > 0) Console.WriteLine($"As raízes são {r1} e {r2}");
      else Console.WriteLine("impossivel calcular");
  }
}