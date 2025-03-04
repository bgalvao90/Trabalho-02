int n = int.Parse(Console.ReadLine());
int[] vetor = new int[n];
int maisVelho = 0;
string nomeMaisVelho = "";

for (int i = 0; i < n; i++)
{
    string[] nomeIdade = Console.ReadLine().Split();
    string nome = nomeIdade[0];
    int idade = int.Parse(nomeIdade[1]);

    if (idade > maisVelho)
    {
        maisVelho = idade;
        nomeMaisVelho = nome;
    }
}
Console.WriteLine($"Pessoa mais velha: {nomeMaisVelho}");