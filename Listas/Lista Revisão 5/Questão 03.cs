using System; 
public class Program {
  public static void Main() {
    double a = double.Parse(Console.ReadLine());
    double b = double.Parse(Console.ReadLine());
    Console.WriteLine(Diagonal(a, b));
  }
  public static double Diagonal(double b, double h) {
    return Math.Sqrt(b * b + h * h);
  }
}