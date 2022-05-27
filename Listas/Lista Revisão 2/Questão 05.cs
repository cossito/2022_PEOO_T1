using System; 
public class Program {
  public static void Main() {
    Console.WriteLine("Informe o número do mês");
    string s = Console.ReadLine();
    int n = int.Parse(s);
    if (n == 1) Console.WriteLine("O mês de janeiro é do primeiro trimestre do ano");
    if (n == 2) Console.WriteLine("O mês de fevereiro é do primeiro trimestre do ano");
    if (n == 3) Console.WriteLine("O mês de março é do primeiro trimestre do ano");
    if (n == 4) Console.WriteLine("O mês de abril é do segundo trimestre do ano");
    if (n == 5) Console.WriteLine("O mês de maio é do segundo trimestre do ano");
    if (n == 6) Console.WriteLine("O mês de junho é do segundo trimestre do ano");
    if (n == 7) Console.WriteLine("O mês de julho é do terceiro trimestre do ano");
    if (n == 8) Console.WriteLine("O mês de agosto é do terceiro trimestre do ano");
    if (n == 9) Console.WriteLine("O mês de setembro é do terceiro trimestre do ano");
    if (n == 10) Console.WriteLine("O mês de outubro é do quarto trimestre do ano");
    if (n == 11) Console.WriteLine("O mês de novembro é do quarto trimestre do ano");
    if (n == 12) Console.WriteLine("O mês de dezembro é do quarto trimestre do ano");
  }
}