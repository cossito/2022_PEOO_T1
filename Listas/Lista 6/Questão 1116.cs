using System; 
public class Program {
  public static void Main() {
    int n = int.Parse(Console.ReadLine());
    int i = 0;
    while (i < n){
      string s = Console.ReadLine();
      string[] v = s.Split(' ');
      double x = double.Parse(v[0]);
      double y = double.Parse(v[1]);
      double div = x / y;
      if (y == 0) Console.WriteLine("divisao impossivel");
      else Console.WriteLine($"{div:0.0}");
      i += 1;
    }
  }
}