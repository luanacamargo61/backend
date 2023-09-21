public class Program
{
    public static void Main()
    {
        try{ 
        Console.WriteLine($"digite um numero inteiro");
        int numero = int.Parse(Console.ReadLine());
        Console.WriteLine($"Vc digitou o nº {numero}");
        }
        catch (FormaException){
            Console.WriteLine("Digite um número inteiro");
        }
        catch (Exception erro)
        {
            Console.WriteLine($"Ocorreu um erro: {erro.Message}");
        }
        finally{
            Console.WriteLine($"No bloco finally o programa entra independentemente de execeção");
        }
    }
}