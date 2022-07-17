using System; 
public class Program {
  public static void Main() {
    int i = 0;
    while (i < 30) {
      i += 1;
      if (i % 3 != 0) Console.Write($"{i} ");
      else if (i % 3 == 0) Console.Write($"-{i} ");
    }
  }
}