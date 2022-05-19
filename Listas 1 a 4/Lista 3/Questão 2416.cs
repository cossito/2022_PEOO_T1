using System;
class Program {
  public static void Main() {
    string a = Console.ReadLine();
    string[] v = a.Split(' ');
    string b = v[0];
    string c = v[1];
    int d = int.Parse(b);
    int e = int.Parse(c);
    int resto = d % e;
    Console.WriteLine(resto);
  }
}