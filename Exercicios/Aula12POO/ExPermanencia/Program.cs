using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.Json;

namespace ExPermanencia;

public class Program
{
    static string arquivo = "alunos.json";

    static void Main()
    {
        List<Aluno> alunos = new List<Aluno>();
        //LEITURA - carrega os alunos do arquivo JSON

        if (File.Exists(arquivo))
        {
            string json = File.ReadAllText(arquivo);

            //converte o texto JSON em uma lista de objetos
            //se a conversão retornar null 
            alunos = JsonSerializer.Deserialize<List<Aluno>>(json) ??
                     new List<Aluno>();
            Console.WriteLine("Alunos Carregados do arquivo¹");
        }

        //Cadastro de um novo aluno 
        Console.WriteLine("Digite o ID");
        int id = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Digite o nome");
        string Nome = Console.ReadLine();

        Console.WriteLine("Digite a nota:");
        double nota = double.Parse(Console.ReadLine());

        string nome = "";
        Aluno novoAluno = new Aluno{Id = id, Nome = nome, Nota = nota};
        alunos.Add(novoAluno);
        
        //escrita - converter pra JSON
        var opcoes = new JsonSerializerOptions { WriteIndented = true };
        string novoJson = JsonSerializer.Serialize(alunos, opcoes);
        File.WriteAllText(arquivo, novoJson);

        Console.WriteLine("\nAluno salvo");
        
        //exibe todos os alunos
        Console.WriteLine("\nLista de Alunos");
        foreach (Aluno aluno in alunos)
        {
            Console.WriteLine($"Id: {aluno.Id} Nome: {aluno.Nome} Nota: {aluno.Nota}");
        }
    }
}