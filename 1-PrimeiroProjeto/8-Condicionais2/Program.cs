Console.WriteLine("Executando projeto 8 - Condicionais 2");


int idadeJoao = 18;
int quantidade = 2;

bool acompanhado = quantidade > 1;

// && - todos verdadeiros
// || - pelo menos 1 verdadeiro

if (idadeJoao >= 18 && acompanhado)
{
    Console.WriteLine("João pode entrar");
}
else
{
    Console.WriteLine("João não pode entrar");
}
