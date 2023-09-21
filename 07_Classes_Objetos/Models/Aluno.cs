namespace Sesi.Model
{
    public class Aluno
    {
        public string nome { get; set; }
        public int idade { get; set; }
        public string turma { get; set;}
        private int nrFaltas { get; set;}


        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {nome}, eu tenho {idade} anos e estudo na turma {turma} e tenho {nrFaltas} faltas");
        }

        public void AdicionarFaltas(int nr)
        {
            Console.WriteLine($"O aluno {nome} faltou hoje e somou {nr}");
            nrFaltas = nrFaltas + nr;
        }
            public void Faltas(){
                Console.WriteLine($"O aluno {nome} tem {nrFaltas} faltas");
            }
        }
    }
