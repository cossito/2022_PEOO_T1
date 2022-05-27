using System; 
public class Program {
  public static void Main() {
    Console.WriteLine("Digite três valores:");
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int c = int.Parse(Console.ReadLine());
    int subA = b - c;
    int subB = a - c;
    int subC = a - b;

    if (subA < 0) subA = subA * (-1);
    if (subB < 0) subB = subB * (-1);
    if (subC < 0) subC = subC * (-1);
    if (a > b + c || b > a + c || c > a + b) Console.WriteLine("Esses valores não formam um triângulo");
    else if (a < subA || b < subB || c < subC) Console.WriteLine("Esses valores não formam um triângulo");
    else if (a == b && b == c) Console.WriteLine("Esses valores formam um triângulo equilátero");
    else if (a == b && a != c || b == c && b != a || a == c && c != b) Console.WriteLine("Esses valores formam um triângulo isóceles");
    else if (a != b && b != c && c != a) Console.WriteLine("Esses valores formam um triângulo escaleno");
  }
}