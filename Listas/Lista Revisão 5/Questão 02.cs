using System; 
public class Program {
  public static void Main() {
    double a = double.Parse(Console.ReadLine());
    Console.WriteLine(AreaCirculo(a));
  }
  public static double AreaCirculo(double raio) {
    return (raio * raio) * 3.14;
  }
}