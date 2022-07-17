using System; 
public class Program {
  public static void Main() {
    int n = int.Parse(Console.ReadLine());
    int x = 1;
    int y = 0;
    int z = x;
    int i = 0;
    while (i < n){
      if(i != n-1) Console.Write($"{y} ");
      else Console.WriteLine(y);
      z += y;
      y = x;
      x = z;
      i += 1;
    }
  }
}