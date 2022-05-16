using System;
class Program {
  public static void Main() {
    Console.WriteLine("Digite a nota do primeiro bimestre da disciplina:");
    string s = Console.ReadLine();
    Console.WriteLine("Digite a nota do segundo bimestre da disciplina:");
    string v = Console.ReadLine();
    int a = int.Parse(s);
    int b = int.Parse(v);
    int media = (a * 2 + b * 3) / 5;
    Console.WriteLine("Média Parcial = " + media);
  }
}
