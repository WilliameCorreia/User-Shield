namespace User_Shield.Domain.Entities
{
    public class Usuario
    {
        public Usuario( int id, string username, string password, string cPF, string tipoUsuario, DateTime dataRegistro,
            DateTime dataAtualizacao, int? tempoAcesso, bool ativo, bool passUpdate, bool integraApi, string cNPJ,
            string nomeCompleto, int? estabelecimento, string email, string telefone, string celular, string endereco)
        {
            Id = id;
            Username = username;
            Password = password;
            CPF = cPF;
            TipoUsuario = tipoUsuario;
            DataRegistro = dataRegistro;
            DataAtualizacao = dataAtualizacao;
            TempoAcesso = tempoAcesso;
            Ativo = ativo;
            PassUpdate = passUpdate;
            IntegraApi = integraApi;
            CNPJ = cNPJ;
            NomeCompleto = nomeCompleto;
            Estabelecimento = estabelecimento;
            Email = email;
            Telefone = telefone;
            Celular = celular;
            Endereco = endereco;
        }

        protected Usuario()
        {

        }

        public int Id { get; private set; }
        public string Username { get; private set; }
        public string Password { get; private set; }
        public string CPF { get; private set; }
        public string TipoUsuario { get; private set; }
        public DateTime DataRegistro { get; private set; }
        public DateTime DataAtualizacao { get; private set; }
        public int? TempoAcesso { get; private set; }
        public bool Ativo { get; private set; }
        public bool PassUpdate { get; private set; }
        public bool IntegraApi { get; private set; }
        public string CNPJ { get; private set; }
        public string NomeCompleto { get; private set; }
        public int? Estabelecimento { get; private set; }
        public string Email { get; private set; }
        public string Telefone { get; private set; }
        public string Celular { get; private set; }
        public string Endereco { get; private set; }


        public virtual void Atualizar( string Username, string Password, string CPF, string TipoUsuario, int? TempoAcesso, bool Ativo,
            bool PassUpdate, bool IntegraApi, string CNPJ, string NomeCompleto, int? Estabelecimento, string Email, string Telefone,
            string Celular, string Endereco)
        {
            this.Username = Username;
            this.Password = Password;
            this.CPF = CPF;
            this.TipoUsuario = TipoUsuario;
            this.TempoAcesso = TempoAcesso;
            this.Ativo = Ativo;
            this.PassUpdate = PassUpdate;
            this.IntegraApi = IntegraApi;
            this.CNPJ = CNPJ;
            this.NomeCompleto = NomeCompleto;
            this.Estabelecimento = Estabelecimento;
            this.Email = Email;
            this.Telefone = Telefone;
            this.Celular = Celular;
            this.Endereco = Endereco;
            DataAtualizacao = DateTime.Now;
        }
    }
}
