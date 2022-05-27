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
    else Console.WriteLine("A data informada é valida");
  }
}