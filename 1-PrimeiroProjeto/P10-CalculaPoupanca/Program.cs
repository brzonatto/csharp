Console.WriteLine("Executando projeto 10 - Calcula poupança");

double valorInvestido = 1000;

int mes = 1;

while (mes <= 12)
{
    valorInvestido += valorInvestido * 0.0036;

    if (mes == 1)
    {
        Console.WriteLine($"Após {mes++} mês você terá: R${valorInvestido}");
    }
    else
    {
        Console.WriteLine($"Após {mes++} mêses você terá: R${valorInvestido}");
    }    
}

