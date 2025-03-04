double n = double.Parse(Console.ReadLine());
int posicao = 0;
double maior = 0;
for  (int i = 0; i < n; i++)
{
    
    double x = double.Parse(Console.ReadLine());
    
    if (x > maior)
    {
        maior = x;
        posicao = i;

    }
    
   
}
Console.WriteLine(maior.ToString("F1"));
Console.WriteLine(posicao);
