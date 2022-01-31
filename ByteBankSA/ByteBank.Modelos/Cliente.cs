namespace ByteBank
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Profissao { get; set; }

        public Cliente(string nome, string cpf, string profissao)
        {
            Nome = nome;
            Cpf = cpf;
            Profissao = profissao;
        }

        public override bool Equals(object obj)
        {
            Cliente outroCliente = obj as Cliente;

            if (outroCliente == null) return false;

            return Cpf == outroCliente.Cpf;
        }
    }
}
