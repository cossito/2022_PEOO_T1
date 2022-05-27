using System; 
public class Program {
  public static void Main() {
    Console.WriteLine("Digite dois valores inteiros");
    string x = Console.ReadLine();
    string y = Console.ReadLine();
    int a = int.Parse(x);
    int b = int.Parse(y);
    if (a > b) Console.WriteLine("Maior = " + a);
    else if (b > a) Console.WriteLine("Maior = " + b);
    else Console.WriteLine("Números iguais");
  }
}