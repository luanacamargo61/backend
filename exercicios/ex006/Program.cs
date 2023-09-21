class Ex005 {
    public static void Main()
    {
      ListaDoChurrasco();
    }
    public static void ListaDoChurrasco(){
        string[]listaProdutos = new string[6];

        listaProdutos[0] = "Carne 3kg";
        for (int i = 0; i < listaProdutos.Length; i++)
       {
        Console.WriteLine("Informe o produto:");
        string produto = Console.ReadLine();
        listaProdutos[1] = produto;
       }
       Array.Sort(listaProdutos);

       foreach (string item in listaProdutos){
        Console.WriteLine($"Item{item}");
       }
    }
}