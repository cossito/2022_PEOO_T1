using System; 
public class Program {
  public static void Main() {
    Console.WriteLine("Digite três valores:");
    double a = double.Parse(Console.ReadLine());
    double b = double.Parse(Console.ReadLine());
    double c = double.Parse(Console.ReadLine());
    double maior = 0;
    double medio = 0;
    double menor = 0;
    
    if (a > b && a > c) maior = maior + a;
    else if (a > b && a < c || a > c && a < b) medio = medio + a;
    else if (a < b && a < c) menor = menor + a;
    
    if (b > a && b > c) maior = maior + b;
    else if (b > a && b < c || b > c && b < a) medio = medio + b;
    else if (b < a && b < c) menor = menor + b;
    
    if (c > a && c > b) maior = maior + c;
    else if (c > a && c < b || c > b && c < a) medio = medio + c;
    else if (c < a && c < b) menor = menor + c;

    Console.WriteLine($"{menor}, {medio}, {maior}");
  }
}