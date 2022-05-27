using System; 
public class Program {
  public static void Main() {
    Console.WriteLine("Digite o primeiro horário no formato hh:mm");
    string x = Console.ReadLine();
    Console.WriteLine("Digite o segundo horário no formato hh:mm");
    string y = Console.ReadLine();
    string[] v = x.Split(':');
    string[] s = y.Split(':');
    int hora1 = int.Parse(v[0]);
    int min1 = int.Parse(v[1]);
    int hora2 = int.Parse(s[0]);
    int min2 = int.Parse(s[1]);
    int horaT = hora1 + hora2;
    int minT = min1 + min2;
    if (minT > 60)
    {
      horaT = horaT + 1;
      minT = minT - 60;
    }
    else if (minT == 60)
    {
      horaT = horaT + 1;
      minT = 0;
    }
    Console.WriteLine($"Total de horas = {horaT:00.}:{minT:00.}");
  }
}