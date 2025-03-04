int n = int.Parse(Console.ReadLine());
double LucroAbaixo = 0;
double LucroEntre = 0;
double LucroAcima = 0;
double ValorTotalCompra = 0;
double ValorTotalVenda = 0;
double LucroTotal = 0;
 for (int i = 0; i < n; i++)
{
    string[] compraVenda = Console.ReadLine().Split();
    string produto = compraVenda[0];
    double compra = double.Parse(compraVenda[1]);
    double venda = double.Parse(compraVenda[2]);
    
    double lucro = venda - compra;
    double percentualLucro = (lucro / compra) * 100;

    ValorTotalCompra += compra;
    ValorTotalVenda += venda;
    LucroTotal += lucro;

    if (percentualLucro < 10)
    {
        LucroAbaixo++;
    }
    else if (percentualLucro >= 10 && percentualLucro <= 20 )
    {
        LucroEntre++;
    }
    else
    {
        LucroAcima++;
    }

    
}
Console.WriteLine($"Lucro abaixo de 10%: {LucroAbaixo}");
Console.WriteLine($"Lucro entre 10% e 20%: {LucroEntre}");
Console.WriteLine($"Lucro acima 20%: {LucroAcima}");
Console.WriteLine($"Valor total de compra: {(ValorTotalCompra):F2}");
Console.WriteLine($"Valor total de Venda: {(ValorTotalVenda):F2}");
Console.WriteLine($"Lucro total: {(LucroTotal):F2}");