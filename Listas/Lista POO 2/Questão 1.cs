using System;
class Program{
  public static void Main(){
    Circulo a = new Circulo();
    Console.WriteLine("Digite o raio do círculo:");
    a.SetRaio(double.Parse(Console.ReadLine()));
    Console.WriteLine($"A área do círculo de raio {a.GetRaio()} é {a.CalcArea()}");
    Console.WriteLine($"A circunferência do círculo de raio {a.GetRaio()} é {a.CalcCircunferencia()}");
  }
}
class Circulo{
  private double raio;
  public void SetRaio(double v){
    if (v > 0) raio = v;
  }
  public double GetRaio(){
    return raio;
  }
  public double CalcArea(){
    return Math.PI * Math.Pow(raio, 2);
  }
  public double CalcCircunferencia(){
    return 2 * Math.PI * raio;
  }
}