using System; 
public class Program {
  public static void Main() {
    Console.WriteLine("Digite o horário no formato hh:mm");
    string x = Console.ReadLine();
    string[] v = x.Split(':');
    int horaT = int.Parse(v[0]);
    int minT = int.Parse(v[1]);
    int ang = Math.Abs((horaT * 30 + minT / 2) - (minT * 6));
      if (ang > 180) ang = Math.Abs(360 - ang);
      if (minT > 60 || minT < 0 || horaT > 24 || horaT < 0) Console.WriteLine("Hora inválida");
      else Console.WriteLine($"Menor ângulo entre os ponteiros = {ang} graus");
  }
}