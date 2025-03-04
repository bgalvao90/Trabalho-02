
int media = 0;
int n = int.Parse(Console.ReadLine());
int[] vetor = new int[n];

for (int i = 0; i < n; i++)
{
    vetor[i] = int.Parse(Console.ReadLine());

    if (vetor[i] % 2 == 0)
    {
        media = vetor.Sum() / n;
    }
}
Console.WriteLine(media.ToString("F1"));