using System; 
public class Program {
  public static void Main() {
    string s = Console.ReadLine();
    Console.WriteLine(Senha(s));
  }
  public static string Senha(string s) {
    string[] v = s.Split();
    int i = 0;
    int p = v.Length;
    string x = "";
    while (i < p) {
      int c = v[i].Length;
      x += c.ToString();
      i++;
    }
    return x;
  }
}