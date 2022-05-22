using System; 
public class Program {
  
  public static void Main() {
    string s = Console.ReadLine();
    string[] v = s.Split(' ');
    int a = int.Parse(v[0]);
    int b = int.Parse(v[1]);
    int rest = b % a;
    int rest2 = a % b;
    if (rest == 0 || rest2 == 0)
    {
    Console.WriteLine("Sao Multiplos");
    }
    else{
    Console.WriteLine("Nao sao Multiplos");
    }
  }
}