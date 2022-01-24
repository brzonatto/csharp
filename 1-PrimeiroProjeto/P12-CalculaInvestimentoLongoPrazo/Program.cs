Console.WriteLine("Executando projeto 12 - Calcula investimento longo prazo");

double valorInvestido = 1000;
double fatorRendimento = 1.0036;

for (int i = 1; i <= 5; i++)
{
    for (int j = 1; j <= 12; j++)
    {
        valorInvestido *= fatorRendimento;
        if (i == 1)
        {
            if (j == 1)
            {
                Console.WriteLine($"Após {i} ano e {j} mês você terá: R${valorInvestido}");
            }
            else
            {
                Console.WriteLine($"Após {i} ano e {j} mêses você terá: R${valorInvestido}");
            }           
        }
        else
        {
            if (j == 1)
            {
                Console.WriteLine($"Após {i} anos e {j} mês você terá: R${valorInvestido}");
            }
            else
            {
                Console.WriteLine($"Após {i} anos e {j} mêses você terá: R${valorInvestido}");
            }
        }
    }

    fatorRendimento += 0.0010;
}