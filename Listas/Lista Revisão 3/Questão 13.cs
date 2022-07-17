using System; 
public class Program {
  public static void Main() {
    Console.WriteLine("Digite uma frase:");
    string s =  Console.ReadLine();
    char[] c = s.ToCharArray();
    int i = c.Length - 1;
    while (i > -1) {
      Console.Write(c[i]);
      i -= 1;
    }
  }
}