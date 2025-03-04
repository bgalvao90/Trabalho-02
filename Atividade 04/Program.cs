int n = int.Parse(Console.ReadLine());
double[] vetor = new double[n];
double media = 0;

for (int i = 0; i < n; i++)
{
    vetor[i] = double.Parse(Console.ReadLine());
    media = vetor.Sum() / n;
}
var abaixoMedia = vetor.Where(x => x < media).OrderBy(x => x);
Console.WriteLine(media);
if (abaixoMedia.Count() != 0)
{
    foreach (var item in abaixoMedia)
    {
        Console.WriteLine(item.ToString("F1"));
    }
}

