using System; 
public class Program {
  public static void Main() {
    Console.WriteLine("Digite uma sequência de números separados por vírgula:");
    string s = Console.ReadLine(); 
    string[] v = s.Split(',');
    int n = v.Length;
    int i = 0;
    int x = 0;
    while (i < n) {
      x += int.Parse(v[i]);
      i++;
    }
    Console.WriteLine($"Soma = {x}");
  }
}