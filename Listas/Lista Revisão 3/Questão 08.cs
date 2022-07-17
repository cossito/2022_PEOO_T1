using System; 
public class Program {
  public static void Main() {
    Console.WriteLine("Digite uma frase:");
    string s = Console.ReadLine(); 
    string[] v = s.Split();
    int p = v.Length;
    int i = 0;
    while (i < p) {
      int i2 = 0;
      char[] c = v[i].ToCharArray();
      int n = c.Length;
      while (i2 < n) {
        i2++;
        if (i2 + 1 == n) Console.Write(c[i2]);
      }
      i++;
    }
  }
}