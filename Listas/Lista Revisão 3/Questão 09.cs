using System; 
public class Program {
  public static void Main() {
    Console.WriteLine("Digite uma frase:");
    string s = Console.ReadLine(); 
    char[] c = s.ToCharArray();
    int n = c.Length;
    int i = 1;
    while (i <= n) {
      Console.WriteLine($"{i} - {s}");
      i++;
    }
  }
}