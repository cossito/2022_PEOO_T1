using System; 
public class Program {
  public static void Main() {
    int x = 1;
    int y = 2;
    int z = 3;
    while (z <= 30) {
      Console.Write($"{x} {y} {z} {x + y + z} ");
      x += 3;
      y += 3;
      z += 3;
    }
  }
}