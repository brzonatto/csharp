Console.WriteLine("Executando projeto 11 - Calcula poupança 2");

double valorInvestido = 1000;

for (int i = 1; i <= 12; i++)
{
    valorInvestido *= 1.0036;

    if (i == 1)
    {
        Console.WriteLine($"Após {i} mês você terá: R${valorInvestido}");
    }
    else
    {
        Console.WriteLine($"Após {i} mêses você terá: R${valorInvestido}");
    }
}
