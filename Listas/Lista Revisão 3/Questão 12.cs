using System; 
public class Program {
  public static void Main() {
    Console.WriteLine("Digite uma frase:");
    string s = Console.ReadLine();
    string[] v = s.Split();
    int n = v.Length;
    Console.WriteLine(n);
  }
}