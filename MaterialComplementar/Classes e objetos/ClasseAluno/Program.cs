namespace ClasseAluno;

public class Program
{
    static void Main()
    {

        List<Aluno> listadealunos = new();
        Aluno um = new();
        um.nome = "Luis";
        um.notaUm = 8;
        um.notaDois = 10;

        Aluno dois = new() { nome = "felipe", notaUm = 5, notaDois = 6 };
        Aluno tres = new() { nome = "felipe", notaUm = 4, notaDois = 8 };

        listadealunos.Add(um);
        listadealunos.Add(dois);
        listadealunos.Add(tres);

        foreach (Aluno apresentado in listadealunos)
        {
            Console.WriteLine($"Nota do aluno {apresentado.nome}: " + apresentado.CalcularMedia());
            Console.WriteLine(apresentado.VerificarSituacao());
        }
    }
}