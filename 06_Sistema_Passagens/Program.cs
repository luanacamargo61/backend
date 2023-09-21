class Program
{
    public static string[] poltronas = new string[51];
    public static void Main()
    {
        Console.Clear();
        Console.WriteLine("|--------------------------------|");
        Console.WriteLine("|-> Bem vindo ao Bus Lightyear <-|");
        Console.WriteLine("|--------------------------------|");
        Console.WriteLine("Contamos com 50 lugares disponiveis!");

        Menu();

    }

    public static void Menu()
    {
        string opcao = "";

        do
        {
            Console.WriteLine(">>>>>>>>>>>>> M E N U <<<<<<<<<<<<<<");
            Console.WriteLine("1 -> Para Comprar passagem");
            Console.WriteLine("2 -> Para Poltronas disponiveis");
            Console.WriteLine("3 -> Para quantidade de poltronas");
            Console.WriteLine("4 -> Para Lista de passageiros");
            Console.WriteLine("0 -> Fechar Menu");
            opcao = Console.ReadLine();
            Console.Clear();

            switch (opcao)
            {
                case "0":
                    Console.WriteLine("Obrigado volte sempre!");
                    System.Threading.Thread.Sleep(2000);
                    break;
                case "1":
                    ComprarPassagem();
                    break;
                case "2":
                    PoltronasDisponiveis();
                    break;
                case "3":
                    QuantidadePoltronas();
                    break;
                case "4":
                    Passageiros();
                    break;
                default:
                    Console.WriteLine("Opção invalida :( )");
                    break;
            }
        } while (opcao != "0");
    }

    public static void ComprarPassagem()
    {
        Console.WriteLine("Quantas passagens deseja comprar?");
        int nrPassagens = int.Parse(Console.ReadLine());

        for (int i = 1; i <= nrPassagens; i++)
        {
            Console.WriteLine($"Digite a poltrona da {i}ª passagem:");
            int nrPoltrona = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o nome do passageiro");
            string nome = Console.ReadLine();
            MarcarPoltrona(nrPoltrona, nome);
        }
    }

    public static void MarcarPoltrona(int nrPoltrona, string nome)
    {
        poltronas[nrPoltrona] = nome;
    }

    public static void PoltronasDisponiveis()
    {
        Console.WriteLine("Lista de Poltronas Disponiveis");
        for (int i = 1; i <= 50; i++)
        {
            if (poltronas[i] == null)
            {
                Console.WriteLine($"Nº {i}");
            }
        }
    }

    public static void QuantidadePoltronas()
    {
    int total = 0;
    for (int i=1; i <= 50; i++){
        if (poltronas[i]== null){
            total = total + 1;
        }
    }
    } Console.WriteLine("Atualmente temos" + total + "poltronas disponiveis");

    public static void Passageiros(){
       Console.WriteLine("Lista de Passageiros");
        for (int i = 1; i <= 50; i++)
        {
            if (poltronas[i] != null)
            {
                Console.WriteLine($"Nº {i} - nome: {poltronas[i]}");
            }
        }
    }
}