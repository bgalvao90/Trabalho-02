int n = int.Parse(Console.ReadLine());
double menorAltura = 3;
double maiorAltura = 0;
double mediaMulher = 0;
double quntdHomem = 0;
double quntdMulher = 0;
double somaAlturaMulher = 0;

for (int i = 0; i < n; i++)
{ 
    string [] sexoAltura = Console.ReadLine().Split();
    double altura = double.Parse(sexoAltura[0]);
    string sexo = (sexoAltura[1]);

    if (altura <= menorAltura)
    {
        menorAltura = altura;
    }
    if (altura >= maiorAltura)
    {
        maiorAltura = altura;
    }
    if (sexo == "M")
    {
        quntdHomem++;
    }
    else
    {
        quntdMulher++;
        somaAlturaMulher += altura;
    }
    if (sexo == "F")
    {
        mediaMulher = somaAlturaMulher/ quntdMulher;
    }
}
Console.WriteLine($"Menor Altura: {(menorAltura):F2}");
Console.WriteLine($"Maior Altura: {(maiorAltura):F2}");
Console.WriteLine($"MediaMulher: {(mediaMulher):F2}");
Console.WriteLine($"Numero homens: {quntdHomem}");