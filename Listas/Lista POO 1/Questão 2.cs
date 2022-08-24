using System;
class Program{
  public static void Main(){
    Disciplina a = new Disciplina();
    Console.WriteLine("Digite o nome da disciplina:");
    a.nome = Console.ReadLine();
    Console.WriteLine("Digite a primeira nota:");
    a.nota1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite a segunda nota:");
    a.nota2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite a terceira nota:");
    a.nota3 = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite a quarta nota:");
    a.nota4 = int.Parse(Console.ReadLine());
    Console.WriteLine($"Sua média parcial em {a.nome} é {a.MediaP()}");
    if (a.MediaP() < 60) {
      Console.WriteLine("Digite a nota final:");
      a.notafinal = int.Parse(Console.ReadLine());
    }
    Console.WriteLine($"Sua média final em {a.nome} é {a.MediaF()}");
  }
}
class Disciplina{
  public string nome;
  public int nota1;
  public int nota2;
  public int nota3;
  public int nota4;
  public int MediaP() {
    return (2 * nota1 + 2 * nota2 + 3 * nota3 + 3 * nota4) / 10;
  }
  public int notafinal;
  public int MediaF() {
    if (MediaP() >= 60) return MediaP();
    else return (nota1 + nota2 + nota3 + nota4 + notafinal) / 5;
  }
}