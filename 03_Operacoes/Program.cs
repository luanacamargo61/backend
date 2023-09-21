Console.WriteLine("Digite o valor de x:");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor de y:");
int y = int.Parse(Console.ReadLine());

int soma = x + y;
int subtracao = x - y;
int multiplicacao = x * y;
int divisao = x / y;
int resto = x % y;
int restoDiv2 = x % 2;

Console.WriteLine("Soma: " + soma);
Console.WriteLine("Subtracao: " + subtracao);
Console.WriteLine("Multiplicação: " + multiplicacao);
Console.WriteLine("Divisão: " + divisao);
Console.WriteLine("Resto: " + resto);

if (restoDiv2 ==0)
{
    Console.WriteLine($"{x} é par");
}
else{
    Console.WriteLine($"{x} é impar";)
}