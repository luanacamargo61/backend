﻿using Sesi.Model;

class Program
{
    public static void Main()
    {
        var aluno1 = new Aluno();
        aluno1.nome = "Luana";
        aluno1.idade = 16;
        aluno1.turma = "2º EM";

        aluno1.Apresentar();

        Aluno aluno2 = new Aluno();
        aluno2.nome = "julia";
        aluno2.idade = 17;
        aluno2.turma = "2º EM";

        aluno2.Apresentar();
        aluno2.AdicionarFaltas(10);
        aluno2.Apresentar();
        aluno2.Faltas();

    
    }
}
