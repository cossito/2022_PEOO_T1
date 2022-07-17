using System; 
public class Program {
  public static void Main() {
    Console.WriteLine("Digite uma frase:");
    string s = Console.ReadLine(); 
    string[] v = s.Split(' '); 
    int p = v.Length;
    int n = 0;
    int i = 0;
    while (i < p) {
      while (n < p) {
        Console.Write($"{v[n]} ");
        n += 1;
      }
      Console.WriteLine();
      i += 1;
      n = i;
    }
  }
}