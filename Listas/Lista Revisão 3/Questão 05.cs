using System; 
public class Program {
  public static void Main() {
    int i = 1;
    int n = 1;
    while (n < 11) {
      Console.Write($"{i} ");
      i += n;
      n += 1;
    }
  }
}