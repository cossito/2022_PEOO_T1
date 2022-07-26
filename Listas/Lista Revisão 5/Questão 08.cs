using System; 
public class Program {
  public static void Main() {
    double x = double.Parse(Console.ReadLine());
    Console.WriteLine(MenorInteiro(x));
  }
  public static int MenorInteiro(double x) {
    int v = Convert.ToInt32(Math.Floor(x));
    return v;
  }
}