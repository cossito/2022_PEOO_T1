using System; 
public class Program {
  public static void Main() {
    Console.WriteLine("Digite quatro valores inteiros");
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int c = int.Parse(Console.ReadLine());
    int d = int.Parse(Console.ReadLine());
    int media = (a + b + c + d) / 4;
    Console.WriteLine($"Média = {media}");
    
    Console.WriteLine("Números menores que a média");
    if (a < media)
    {
      Console.WriteLine(a);
    }
    if (b < media)
    {
      Console.WriteLine(b);
    }
    if (c < media)
    {
      Console.WriteLine(c);
    }
    if (d < media)
    {
      Console.WriteLine(d);
    }
    
    Console.WriteLine("Números maiores ou iguais a média");
    if (a > media || a == media)
    {
      Console.WriteLine(a);
    }
    if (b > media || b == media)
    {
      Console.WriteLine(b);
    }
    if (c > media || c == media)
    {
      Console.WriteLine(c);
    }
    if (d > media || d == media)
    {
      Console.WriteLine(d);
    }
  }
}