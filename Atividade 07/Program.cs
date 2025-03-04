int n = int.Parse(Console.ReadLine());
double media = 0;
List<string> alunosAprovados = new List<string>();
for (int i = 0; i < n; i++)
{
    string [] nomeNota = Console.ReadLine().Split();

    string nome = nomeNota[0];
    double nota1 = double.Parse(nomeNota[1]);
    double nota2 = double.Parse(nomeNota[2]);

    media = (nota1 + nota2) / 2;

    
    if (media >= 6)
    {
        alunosAprovados.Add(nome);
    }
    
}
Console.WriteLine($"Alunos aprovados:");
foreach (var aluno in alunosAprovados)
{
    Console.WriteLine(aluno);
}