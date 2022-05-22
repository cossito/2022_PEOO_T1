using System; 
class Program {
  public static void Main() {
    string a = Console.ReadLine();
    string a2 = Console.ReadLine();
    string[] v = a.Split(' ');
    string[] v2 = a2.Split(' ');
    double x1 = double.Parse(v[0]);
    double y1 = double.Parse(v[1]);
    double x2 = double.Parse(v2[0]);
    double y2 = double.Parse(v2[1]);
    double dist = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    Console.WriteLine($"{dist:0.0000}");
  }
}