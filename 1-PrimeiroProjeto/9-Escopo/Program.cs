Console.WriteLine("Executando projeto 9 - Escopo");

int idadeJoao = 18;
int quantidade = 2;

string msgAdicional;

bool acompanhado = quantidade > 1;

// && - todos verdadeiros
// || - pelo menos 1 verdadeiro

if (acompanhado)
{
    msgAdicional = "João está acompanhado";
}
else
{
    msgAdicional = "João não está acompanhado";
}

if (idadeJoao >= 18 || acompanhado)
{
    Console.WriteLine("João pode entrar");
    Console.WriteLine(msgAdicional);
}
else
{
    Console.WriteLine("João não pode entrar");
    Console.WriteLine(msgAdicional);
}
