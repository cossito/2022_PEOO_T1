using System;
public class Program{
  public static void Main(){
    int x = int.Parse(Console.ReadLine());
    Console.WriteLine(Primo(x));
  }
  public static bool Primo(int n){
    int i = n - 1;
    while (i > 1) {
      if(n % i == 0) return false;
      i -= 1;
    }
    return true;
  }
}
