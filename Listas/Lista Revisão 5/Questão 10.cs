using System; 
public class Program {
  public static void Main() {
    string s = Console.ReadLine();
    Console.WriteLine(Vogais(s));
  }
  public static string Vogais(string s) {
    int i = 0;
    int v = s.Length;
    string c = "";
    while (i < v) {
      if (s[i] == 'A' || s[i] == 'a' || s[i] == 'E' || s[i] == 'e' || s[i] == 'I' || s[i] == 'i' || s[i] == 'O' || s[i] == 'o' || s[i] == 'U' || s[i] == 'u' || s[i] == ' ') c += s[i];
      i++;
    }
    return c;
  }
}