using System; 
public class Program {
  public static void Main() {
    Console.WriteLine("Digite dois valores inteiros separados por um operador +, -, * ou /");
    string s = Console.ReadLine();
    string[] v = s.Split('+', '-', '*', '/');
    int a = int.Parse(v[0]);
    int b = int.Parse(v[1]);
    int p = s.IndexOf('+');
    if (p == -1) p = s.IndexOf('-');
    if (p == -1) p = s.IndexOf('*');
    if (p == -1) p = s.IndexOf('/');

    switch(s[p]) {
      case '+': Console.WriteLine("O resultado da operação é " + (a + b)); break;
      case '-': Console.WriteLine("O resultado da operação é " + (a - b)); break;
      case '*': Console.WriteLine("O resultado da operação é " + (a * b)); break;
      case '/': Console.WriteLine("O resultado da operação é " + (a / b)); break;
    }
  }
}