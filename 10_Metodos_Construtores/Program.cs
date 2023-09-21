using Models;

public class Program{
    public static void Main(){
        /*Pessoa pessoa1 = new Pessoa();
        pessoa1.nome = "Laura Caixão";
        pessoa1.idade = 45;*/

        Pessoa pessoa1 = new Pessoa("Nina Caliente", 30);
        pessoa1 pessoa2 = new Pessoa("Eliza Pancakes", 43);

        pessoa1.Cantar();

    }
}