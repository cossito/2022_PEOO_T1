using System; 
public class Program {
  public static void Main() {
    int maior = int.Parse(Console.ReadLine());
    int posic = 0;
      for (int i = 1; i < 100; i++){
        int n = int.Parse(Console.ReadLine());
        if (n > maior){
          maior = n;
          posic = i + 1;
        } 
      }
    Console.WriteLine(maior);
    Console.WriteLine(posic);
  }
}