Console.WriteLine("informe o nome do aluno:");
string aluno = Console.ReadLine();
Console.WriteLine("Digite a nota 1:";);
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a segunda nota;");
int y = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor da terceira nota;");
int z = int.Parse(Console.ReadLine());

int soma = x + y + z;
int media = soma / 3;

Console.WriteLine($"A nota foi de {aluno} foi {media}");

if (media < 7){
    Console.WriteLine($"{media} foi abaixo da media");
} else {
    Console.WriteLine($"{media} foi acima da media");
}