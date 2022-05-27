using System; 
public class Program {
  public static void Main() {
    Console.WriteLine("Digite dez valores inteiros");
    string s = Console.ReadLine();
    string[] v = s.Split(' ');
    int a = int.Parse(v[0]);
    int b = int.Parse(v[1]);
    int c = int.Parse(v[2]);
    int d = int.Parse(v[3]);
    int e = int.Parse(v[4]);
    int f = int.Parse(v[5]);
    int g = int.Parse(v[6]);
    int h = int.Parse(v[7]);
    int i = int.Parse(v[8]);
    int j = int.Parse(v[9]);
    int maior = 0;
    int menor = 0;
      
    if (a > b && a > c && a > d && a > e && a > f && a > g && a > h && a > i && a > j) maior = maior + a;
    else if (a < b && a < c && a < d && a < e && a < f && a < g && a < h && a < i && a < j) menor = menor + a;
    if (b > a && b > c && b > d && b > e && b > f && b > g && b > h && b > i && b > j)   maior = maior + b;
    else if (b < a && b < c && b < d && b < e && b < f && b < g && b < h && b < i && b < j) menor = menor + b;
    if (c > a && c > b && c > d && c > e && c > f && c > g && c > h && c > i && c > j)   maior = maior + c;
    else if (c < a && c < b && c < d && c < e && c < f && c < g && c < h && c < i && c < j) menor = menor + c;
    if (d > a && d > c && d > b && d > e && d > f && d > g && d > h && d > i && d > j)   maior = maior + d;
    else if (d < a && d < c && d < b && d < e && d < f && d < g && d < h && d < i && d < j) menor = menor + d;
    if (e > a && e > c && e > d && e > b && e > f && e > g && e > h && e > i && e > j)   maior = maior + e;
    else if (e < a && e < c && e < d && e < b && e < f && e < g && e < h && e < i && e < j) menor = menor + e;
    if (f > a && f > c && f > d && f > e && f > b && f > g && f > h && f > i && f > j)   maior = maior + f;
    else if (f < a && f < c && f < d && f < e && f < b && f < g && f < h && f < i && f < j) menor = menor + f;
    if (g > a && g > c && g > d && g > e && g > f && g > b && g > h && g > i && g > j)   maior = maior + g;
    else if (g < a && g < c && g < d && g < e && g < f && g < b && g < h && g < i && g < j) menor = menor + g;
    if (h > a && h > c && h > d && h > e && h > f && h > g && h > b && h > i && h > j)   maior = maior + h;
    else if (h < a && h < c && h < d && h < e && h < f && h < g && h < b && h < i && h < j) menor = menor + h;
    if (i > a && i > c && i > d && i > e && i > f && i > g && i > h && i > b && i > j)   maior = maior + i;
    else if (i < a && i < c && i < d && i < e && i < f && i < g && i < h && i < b && i < j) menor = menor + i;
    if (j > a && j > c && j > d && j > e && j > f && j > g && j > h && j > i && j > b)   maior = maior + j;
    else if (j < a && j < c && j < d && j < e && j < f && j < g && j < h && j < i && j < b) menor = menor + j;

    Console.WriteLine($"O maior valor é {maior} e o menor é {menor}");
  }
}