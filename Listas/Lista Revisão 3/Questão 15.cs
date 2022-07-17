using System; 
public class Program {
  public static void Main() {
    Console.WriteLine("Digite uma frase:");
    string s = Console.ReadLine(); 
    string[] v = s.Split();
    int n = v.Length;
    int i = 0;
    while (i < n) {
      int x = v[i].Length;
      Console.Write(x);
      i++;
    }
  }
}