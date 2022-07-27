using System;
public class Program{
  public static void Main(){
    string hj = Console.ReadLine();
    string nasc = Console.ReadLine();
    int a;
    int b;
    Idade(hj, nasc, out x, out y);
    Console.WriteLine($"{x} anos e {y} meses");
  }
  public static void Idade(string hoje, string nascimento, out int anos, out int meses){
    string[] hoje1 = hoje.Split('/');
    int diaH = int.Parse(hoje1[0]);
    int mesH = int.Parse(hoje1[1]);
    int anoH = int.Parse(hoje1[2]);
    string[] nasc1 = nascimento.Split('/');
    int diaN = int.Parse(nasc1[0]);
    int mesN = int.Parse(nasc1[1]);
    int anoN = int.Parse(nasc1[2]);
    anos = anoH - anoN;
    meses = mesH - mesN;
  }
}
