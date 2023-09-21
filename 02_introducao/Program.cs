
int idade = 16;
string nome = "Luana";
Console.WriteLine($"Meu nome é {nome} e tenho {idade}");

Console.WriteLine("Em que cidade voce nasceu?");
string cidade = Console.ReadLine();
Console.WriteLine($"Voce nasceu em {cidade}");

int novaIdade = idade + 5;
int anoNascimento = 2023 - idade;
Console.WriteLine($"Voce nasceu em {anoNascimento} e daqui 5 anos terá {novaIdade}");

