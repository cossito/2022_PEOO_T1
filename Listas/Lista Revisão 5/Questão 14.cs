using System;
public class Program{
  public static void Main(string[] args){
    string s = Console.ReadLine();
    Console.WriteLine(Referencia(s));
  }
  public static string Referencia(string s){
    string[] v = s.Split();
    int p = v.Length;
    int i = 0;
    string refr = $"{v[p - 1]}, ".ToUpper();
    while (i < p - 1) {
      refr += $"{v[i][0]}. ";
      i++;
    }
    return refr;
  }
}