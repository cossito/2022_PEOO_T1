using System; 
public class Program {
  public static void Main() {
    Console.WriteLine("Digite quatro valores inteiros");
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int c = int.Parse(Console.ReadLine());
    int d = int.Parse(Console.ReadLine());
    int soma = 0;
    
    if (a > b && a > c && a > d) Console.WriteLine($"Maior valor = {a}");
    if (b > c && b > d && b > a) Console.WriteLine($"Maior valor = {b}");
    if (c > b && c > a && c > d) Console.WriteLine($"Maior valor = {c}");
    if (d > b && d > c && d > a) Console.WriteLine($"Maior valor = {d}");
    
    if (a < b && a < c && a < d) Console.WriteLine($"Menor valor = {a}");
    if (b < c && b < d && b < a) Console.WriteLine($"Menor valor = {b}");
    if (c < b && c < a && c < d) Console.WriteLine($"Menor valor = {c}");
    if (d < b && d < c && d < a) Console.WriteLine($"Menor valor = {d}");

    //a + c
    if (b > a && a > d && b > c && c > d || d > a && a > b && d > c && c > b)
    {
      soma = a + c;
      Console.WriteLine($"A soma do segundo maior valor com o segundo menor = {soma}");
    }
    
    //a + b
    if (c > a && a > d && c > b && b > d || d > a && a > c && d > b && b > c)
    {
      soma = a + b;
      Console.WriteLine($"A soma do segundo maior valor com o segundo menor = {soma}");
    }

    //a + d
    if (c > a && a > b && c > d && d > b || b > a && a > c && b > d && d > c)
    {
      soma = a + d;
      Console.WriteLine($"A soma do segundo maior valor com o segundo menor = {soma}");
    }

    //c + b
    if (a > c && c > d && a > b && b > d || d > c && c > a && d > b && b > a)
    {
      soma = c + b;
      Console.WriteLine($"A soma do segundo maior valor com o segundo menor = {soma}");
    }

    //c + d
    if (a > c && c > b && a > d && d > b || b > c && c > a && b > d && d > a)
    {
      soma = c + d;
      Console.WriteLine($"A soma do segundo maior valor com o segundo menor = {soma}");
    }

    //b + d
    if (a > b && b > c && a > d && d > c || c > b && b > a && c > d && d > a)
    {
      soma = c + d;
      Console.WriteLine($"A soma do segundo maior valor com o segundo menor = {soma}");
    }
  }
}