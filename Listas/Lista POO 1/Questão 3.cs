using System;
class Program{
  public static void Main(){
    Viagem a = new Viagem();
    Console.WriteLine("Digite a distância em km:");
    a.dist = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite a o tempo no formato hh:mm:");
    a.tempo = Console.ReadLine();
    Console.WriteLine($"A velocidade média foi de {a.VelMedia()} km/h");
  }
}
class Viagem{
  public double dist;
  public string tempo;
  public double VelMedia() {
    string[] v = tempo.Split(':');
    double hora = double.Parse(v[0]);
    double min = double.Parse(v[1]);
    double media = dist / (hora + min/60);
    return media;
  }
}