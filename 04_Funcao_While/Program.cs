class Sesi
{
  public static void Main()
  {
    Console.WriteLine("Estou no metodo Main");
    Metodo();
    ImprimeDataHora();
    ContagemRegressiva(5);
    int resultadoSoma = Somar (3,4);
    Console.WriteLine(resultadoSoma);
    JogoQueNrSouEu();
  }

  public static void Metodo(){
    Console.WriteLine("Estou no metodo Metodo / funçao");
  }

  public static void ImprimeDataHora()
  {
    Console.WriteLine(DateTime.Now.ToShortDateString());
    Console.WriteLine(DateTime.Now.Hour.ToString());
    Console.WriteLine(DateTime.Now.ToString());
  }

  public static int Somar(int n1, int n2)
  {
    int soma = n1 + n2;
    return n1 + n2;
  }
  public static void ContagemRegressiva(int n)
{
    while (n >= 0){
        Console.WriteLine(n);
        n--;
        System.Threading.Thread.Sleep(1000);
    }
    Console.WriteLine("BOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOM!!!!!!!!!!!!");
}
public static void JogoQueNrSouEu(){
    Console.WriteLine("****************************************");
    Console.WriteLine("            Bem-vindo ao jogo           ");
    Console.WriteLine("Sorteei um n* de 1 a 20, tente advinha-lo");
    Console.WriteLine("****************************************");
    Console.WriteLine("");

    Random random = new Random();
    int nrSorteado = random.Next(20);
    int nrDigitado = -1;

    do {
        Console.WriteLine("Digite um n*");
        nrDigitado = int.Parse(Console.ReadLine());
        if (nrDigitado > nrSorteado)
        Console.WriteLine("o numero digitado é maior que o serteado");
        else if (nrDigitado < nrSorteado)
        Console.WriteLine("O numero digitado é menor q o sorteado");
    } while (nrDigitado != nrSorteado);
    Console.WriteLine("parabens");
}
}
