using System; 
public class Program {
  
  public static void Main() {
    string s = Console.ReadLine();
    string[] v = s.Split(' ');
    int x = int.Parse(v[0]);
    int y = int.Parse(v[1]);
    if (x < 433 && y < 469 && x > -1 && y > -1)
    {
      Console.WriteLine("dentro");
    }
    else
    {
      Console.WriteLine("fora");
    }
  }
}