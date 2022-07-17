using System; 
public class Program {
  public static void Main() {
    int i = int.Parse(Console.ReadLine());
    while (i != 2002){
      Console.WriteLine("Senha invalida");
      i = int.Parse(Console.ReadLine());
    }
    if (i == 2002){
      Console.WriteLine("Acesso permitido");
    }
  }
}