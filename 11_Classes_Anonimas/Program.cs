public class Program
{
    public static void Main()
    {
        var pessoa1 = new{
            nome = "jao", 
            idade = 20
            };
        var pessoa2 = new{
            nome = "ze", 
            idade = 19
            };
            Console.WriteLine($"A pessoa 1 se chama {pessoa1.nome} e a pessoa 2 {pessoa2.nome}");

             
Console.WriteLine("Digite a marca do veículo: ");
        string marca = Console.ReadLine();

        Console.WriteLine("Digite o modelo do veículo: ");
        string modelo = Console.ReadLine();

        Console.WriteLine("Digite o ano do veículo: ");
        string ano = Console.ReadLine();

        var possante = new
        {
            marca,
            modelo,
            Ano = ano
        };

        Console.WriteLine($"O carro {modelo} é da marca {marca} e do ano {ano}");
    }
}
