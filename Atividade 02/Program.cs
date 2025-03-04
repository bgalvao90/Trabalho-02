int n = int.Parse(Console.ReadLine());
int [] vetor = new int[n];

for (int i = 0; i < n; i++)
{
    vetor[i] = int.Parse(Console.ReadLine());
}
int quantidade = 0;

for (int i = 0; i < n; i++)
{
    if (vetor[i] % 2 == 0)
    {
        Console.WriteLine(vetor[i]);
        quantidade++;
    }
}
Console.WriteLine(quantidade);