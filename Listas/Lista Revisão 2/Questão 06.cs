using System; 
public class Program {
  public static void Main() {
    Console.WriteLine("Digite três valores inteiros");
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int c = int.Parse(Console.ReadLine());
    int res = 0;
      if (a > b && b > c) res = a + c;
      if (a > b && c > b) res = a + b;
      if (b > a && a > c) res = b + c;
      if (b > a && c > a) res = b + a;
      if (c > a && a > b) res = c + b;
      if (c > a && b > a) res = c + a;
    Console.WriteLine($"A soma do maior com o menor número é {res}.");
  }
}