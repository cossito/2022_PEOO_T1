using System;
public class Program{
  public static void Main(){
    int x = int.Parse(Console.ReadLine());
    int y = int.Parse(Console.ReadLine());
    Console.WriteLine(UltimoDia(x, y));
  }
  public static string UltimoDia(int mes, int ano){
    if(mes % 2 != 0 && mes <= 7 || mes % 2 == 0 && mes >= 8) return $"31/{mes:00.}/{ano}";
    if(mes % 2 == 0 && mes <= 6 && mes != 2 || mes % 2 != 0 && mes >= 9) return $"30/{mes:00.}/{ano}";
    if(mes == 2 && ano % 4 == 0) return $"29/{mes:00.}/{ano}";
    else return $"28/{mes:00.}/{ano}";
  }
}
