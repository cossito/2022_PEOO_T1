using System; 
public class Program {
  public static void Main() {
    int x = int.Parse(Console.ReadLine());
    int a;
    int b;
    AntecessorSucessor(x, out a, out b);
    Console.WriteLine(a);
    Console.WriteLine(b);
  }
  public static void AntecessorSucessor(int x, out int antecessor, out int sucessor) {
    antecessor = x - 1;
    sucessor = x + 1;
  }
}