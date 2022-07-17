using System; 
public class Program {
  public static void Main() {
    Console.WriteLine("Digite uma frase:");
    string s = Console.ReadLine().ToLower();
    int n = s.Length;
    int somA = 0;
    int somE = 0;
    int somI = 0;
    int somO = 0;
    int somU = 0;
    int i = 0;
    while (i < n){
      if (s[i] == 'a') somA++;
      if (s[i] == 'e') somE++;
      if (s[i] == 'i') somI++;
      if (s[i] == 'o') somO++;
      if (s[i] == 'u') somU++;
      i++;
    }
    Console.WriteLine($"A - {somA}");
    Console.WriteLine($"E - {somE}");
    Console.WriteLine($"I - {somI}");
    Console.WriteLine($"O - {somO}");
    Console.WriteLine($"U - {somU}");
  }
}