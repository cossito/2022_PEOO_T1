using System; 
public class Program {
  
  public static void Main() {
    string s = Console.ReadLine();
    string[] v = s.Split(' ');
    double a = double.Parse(v[0]);
    double b = double.Parse(v[1]);
    double c = double.Parse(v[2]);
    double delta = Math.Pow(b, 2) - (4 * a * c);
    double r1 = (-b + Math.Sqrt(delta)) / (2 * a);
    double r2 = (-b - Math.Sqrt(delta)) / (2 * a);
      if (a != 0 && b != 0 && c != 0 && delta > 0){
        Console.WriteLine($"R1 = {r1:0.00000}");
        Console.WriteLine($"R2 = {r2:0.00000}");
      }
      else
      {
      Console.WriteLine("Impossivel calcular");
      }
  }
}