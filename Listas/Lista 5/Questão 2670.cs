using System; 
public class Program {
  
  public static void Main() {
    string x = Console.ReadLine();
    string y = Console.ReadLine();
    string z = Console.ReadLine();
    int a = int.Parse(x);
    int b = int.Parse(y);
    int c = int.Parse(z);
    
    if(b >= c && b >= a)
    {
      int n = (c + a) * 2;
      Console.WriteLine(n);
    }
    else if(c >= a && (a + b) <= c)
    {
      int n = a * 4 + b * 2;
      Console.WriteLine(n);
    }
    else if(a >= c && (c + b) <= a)
    {
      int n = c * 4 + b * 2;
      Console.WriteLine(n);
    }
    else
    {
      int n = (c + a) * 2;
      Console.WriteLine(n);
    }
  }
}