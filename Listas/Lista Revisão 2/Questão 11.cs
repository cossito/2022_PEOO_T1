using System; 
public class Program {
  public static void Main() {
    Console.WriteLine("Digite uma data no formato dd/mm/aaaa");
    string s = Console.ReadLine();
    string[] v = s.Split('/');
    int dia = int.Parse(v[0]);
    int mes = int.Parse(v[1]);
    int ano = int.Parse(v[2]);

    if (dia < 1 || mes > 12 || mes < 0 || ano > 2100 || ano < 1900) Console.WriteLine("A data informada não é valida");
    else if (mes == 1 && dia > 31 || mes == 3 && dia > 31 || mes == 5 && dia > 31 || mes == 7 && dia > 31 || mes == 8 && dia > 31 || mes == 10 && dia > 31 || mes == 12 && dia > 31) Console.WriteLine("A data informada não é valida"); 
    else if (mes == 4 && dia > 30 || mes == 6 && dia > 30 || mes == 9 && dia > 30 || mes == 11 && dia > 30) Console.WriteLine("A data informada não é valida");
    else if(mes == 2 && dia > 28 && ano % 4 != 0 || mes == 2 && dia > 29 && ano % 4 == 0) Console.WriteLine("A data informada não é valida");
    else if (mes == 1) Console.WriteLine($"A data é {dia} de janeiro de {ano}");
    else if (mes == 2) Console.WriteLine($"A data é {dia} de fevereiro de {ano}");
    else if (mes == 3) Console.WriteLine($"A data é {dia} de março de {ano}");
    else if (mes == 4) Console.WriteLine($"A data é {dia} de abril de {ano}");
    else if (mes == 5) Console.WriteLine($"A data é {dia} de maio de {ano}");
    else if (mes == 6) Console.WriteLine($"A data é {dia} de junho de {ano}");
    else if (mes == 7) Console.WriteLine($"A data é {dia} de julho de {ano}");
    else if (mes == 8) Console.WriteLine($"A data é {dia} de agosto de {ano}");
    else if (mes == 9) Console.WriteLine($"A data é {dia} de setembro de {ano}");
    else if (mes == 10) Console.WriteLine($"A data é {dia} de outubro de {ano}");
    else if (mes == 11) Console.WriteLine($"A data é {dia} de novembro de {ano}");
    else if (mes == 12) Console.WriteLine($"A data é {dia} de dezembro de {ano}");
  }
}