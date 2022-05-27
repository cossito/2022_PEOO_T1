using System; 
public class Program {
  
  public static void Main() {
    string a = Console.ReadLine();
    string b = Console.ReadLine();
    string c = Console.ReadLine();

    if (c == "carnivoro")
    {
      Console.WriteLine("aguia");
    }
    
    else if (c == "onivoro" && b == "ave")
    {
      Console.WriteLine("pomba");
    }
    else if (c == "onivoro" && b == "mamifero")
    {
      Console.WriteLine("homem");
    }
    else if (c == "onivoro" && b == "anelideo")
    {
      Console.WriteLine("minhoca");
    }

    else if (c == "herbivoro" && b == "mamifero")
    {
      Console.WriteLine("vaca");
    }
    else if (c == "herbivoro" && b == "inseto")
    {
      Console.WriteLine("lagarta");
    }

    else if (c == "hematofago" && b == "inseto")
    {
      Console.WriteLine("pulga");
    }
    else if (c == "hematofago" && b == "anelideo")
    {
      Console.WriteLine("sanguessuga");
    }
  }
}
