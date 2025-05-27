namespace SuperMaisAPI.DTO
{
    public class FuncionarioComEnderecoDTO
    {
        public int IdFuncionarios { get; set; }
        public string NomeFuncionario { get; set; }
        public string CPFFuncionario { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataContrato { get; set; }
        public DateTime? DataDemissao { get; set; }
        public string TelefoneFuncionario { get; set; }
        public string CelularFuncionario { get; set; }
        public int EnderecoId { get; set; }

        public EnderecoDTO Endereco { get; set; }
    }

    public class EnderecoDTO
    {
        public string Id { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string CEP { get; set; }
        public string? Complemento { get; set; }
    }

}
