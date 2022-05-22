using System;
class Program {
  public static void Main() {
    Console.WriteLine("Digite seu primeiro nome:");
    string s = Console.ReadLine();
    string[] v = s.Split(' ');
    Console.WriteLine("Bem-vindo ao C#, " + v[0]);
  }
}
