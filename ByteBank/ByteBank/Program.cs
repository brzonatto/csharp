using ByteBank;
using ByteBank.Funcionarios;
using ByteBank.Sistemas;

//Cliente gabriela = new Cliente("Gabriela", "12345678901", "Médica");
//ContaCorrente contaGabriela = new ContaCorrente(123456, 123);
//contaGabriela.Cliente = gabriela;
//contaGabriela.Saldo = 5000;

//Cliente brunno = new Cliente("Brunno", "10987654321", "Programador");
//ContaCorrente contaBrunno = new ContaCorrente(654321, 123);
//contaBrunno.Cliente = brunno;
//contaBrunno.Saldo = 3000;

//contaBrunno.ImprimeConta();

//contaGabriela.Sacar(100.55);
//Console.WriteLine(contaGabriela.ImprimeConta());

//contaGabriela.Depositar(300);
//Console.WriteLine(contaGabriela.ImprimeConta());

//contaBrunno.Transferir(1200, contaGabriela);
//Console.WriteLine(contaBrunno.ImprimeConta());

//Console.WriteLine(contaGabriela.ImprimeConta());

//Console.WriteLine($"Contas criadas: {ContaCorrente.QuantidadeDeContas}");

//GerenciadorBonificacao gb = new GerenciadorBonificacao();

//Funcionario carlos = new Funcionario("Carlos", "1234567809", 2000);

//gb.Registrar(carlos);

//Console.WriteLine(carlos.Nome);
//Console.WriteLine(carlos.GetBonificacao());

//Diretor roberta = new Diretor("Roberta", "12345678901", 5000);

//gb.Registrar(roberta);

//Console.WriteLine(roberta.Nome);
//Console.WriteLine(roberta.GetBonificacao());

//Console.WriteLine(gb.GetTotalBonificacao());


//roberta.AumentarSalario();
//Console.WriteLine(roberta.Salario);
//carlos.AumentarSalario();
//Console.WriteLine(carlos.Salario);

//CalcularBonificacao();

UsuarSistema();


void UsuarSistema()
{
    SistemaInterno sistemaInterno = new SistemaInterno();
   
    Diretor roberta = new Diretor("Roberta", "244.567.888.90");
    roberta.Senha = "123";

    GerenteDeConta camila = new GerenteDeConta("Camila", "890.980.455.60");
    camila.Senha = "321";

    Designer pedro = new Designer("Pedro", "833.998.123.90");

    ParceiroComercial parceiro = new ParceiroComercial();
    parceiro.Senha = "333";

    sistemaInterno.Logar(parceiro, "333");
    sistemaInterno.Logar(roberta, "123");
    sistemaInterno.Logar(camila, "321");
}

void CalcularBonificacao()
{
    GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

    Designer pedro = new Designer("Pedro", "833.998.123.90");
    Diretor roberta = new Diretor("Roberta", "244.567.888.90");
    Auxiliar igor = new Auxiliar("Igor", "422.567.870.80");
    GerenteDeConta camila = new GerenteDeConta("Camila", "890.980.455.60");

    gerenciador.Registrar(pedro);
    gerenciador.Registrar(roberta);
    gerenciador.Registrar(igor);
    gerenciador.Registrar(camila);

    Console.WriteLine($"Total de bonificações do mês {gerenciador.GetTotalBonificacao()}");
}