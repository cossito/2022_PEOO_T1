using System; 
public class Program {
  public static void Main() {
    int x = int.Parse(Console.ReadLine());
    int y = int.Parse(Console.ReadLine());
    Console.WriteLine(Soma(x, y));
  }
  public static int Soma(int inicio, int fim) {
    int soma = 0;
    if (inicio > fim) {
      while (inicio >= fim) {
        soma += inicio;
        inicio -= 1;
      }
    }
    else if (inicio < fim) {
      while (inicio <= fim) {
        soma += inicio;
        inicio++;
      }
    }
    return soma;
  }
}