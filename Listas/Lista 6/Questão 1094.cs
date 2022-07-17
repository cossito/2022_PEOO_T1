using System; 
public class Program {
  public static void Main() {
    int i = int.Parse(Console.ReadLine());
    double c = 0;
    double r = 0;
    double s = 0;
    int x = 0;
    while (x < i){
      string y = Console.ReadLine();
      string[] v = y.Split(' ');
      int num = int.Parse(v[0]);
      string tipo = v[1];
      
      if (tipo == "C"){
        c += num;
      }
      else if (tipo == "R"){
        r += num;
      }
      else if (tipo == "S"){
        s += num;
      }
      
      x += 1;
    }
    
    Console.WriteLine($"Total: {c + r + s} cobaias");
    Console.WriteLine($"Total de coelhos: {c}");
    Console.WriteLine($"Total de ratos: {r}");
    Console.WriteLine($"Total de sapos: {s}");
    Console.WriteLine($"Percentual de coelhos: {100 * (c / (c + r + s)):00.00} %");
    Console.WriteLine($"Percentual de ratos: {100 * (r / (c + r + s)):00.00} %");
    Console.WriteLine($"Percentual de sapos: {100 * (s / (c + r + s)):00.00} %");
  }
}