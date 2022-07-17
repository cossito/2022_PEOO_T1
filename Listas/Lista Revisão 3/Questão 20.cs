using System; 
public class Program {
  public static void Main() {
    int i = 1;
    int i2 = 2;
    while (i <= 10) {
      Console.Write($"{i} ");
      while(i2 <= i) {
        Console.Write($"{i2} ");
        i2 = i2 + 2;
      }
      Console.WriteLine();
      i++;
      i2 = 2;
    }
  }
}