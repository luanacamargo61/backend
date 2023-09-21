class Animal
{
    public string cor { get; set;}
    public virtual void EmitirSom()
    {
        Console.WriteLine($"Animal da cor {cor} fazendo algum som");
    }
}

class Cachorro : Animal
{
    public override void EmitirSom()
    {
        Console.WriteLine($"Cachorro da cor {cor} esta latindo! au au au");
    }
}

class Gato : Animal
{
    public override void EmitirSom()
    {
        Console.WriteLine($"Gato da cor {cor} esta miando! miau miau");
    }
    public void Ronronar()
    {
        Console.WriteLine("O gato está ronronando");
    }

}

class Program
{
    static void Main()
    {
        Animal animalGenerico = new Animal();
        animalGenerico.cor = "preto";
        animalGenerico.EmitirSom();
        Cachorro meuCachorro = new Cachorro();
        meuCachorro.cor = "caramelo";
        meuCachorro.EmitirSom();
        Gato meuGato = new Gato();
        meuGato.cor = "cinza";
        meuGato.EmitirSom();
        meuGato.Ronronar();
    }
}