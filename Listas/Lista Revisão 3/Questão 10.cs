using System; 
public class Program {
  public static void Main() {
    Console.WriteLine("Digite uma frase:");
    string s = Console.ReadLine(); 
    int n = s.Length;
    int i = 1;
    while (i <= n) {
      string l1 = s.Substring(0, 1);
      string l2 = s.Substring(1);
      s = l2 + l1;
      Console.WriteLine(s);
      i++;
    }
  }
}