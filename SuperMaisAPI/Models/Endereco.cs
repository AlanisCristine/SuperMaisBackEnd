﻿using Dapper.Contrib.Extensions;

namespace SuperMaisAPI.Models
{
    [Table("endereco")]
    public class Endereco
    {
        [Key]
        public int IdEndereco { get; set; }
        public required string CEP { get; set; }
        public int? TipoVia { get; set; }
        public string? NomeVia { get; set; }
        public string? Numero { get; set; }
        public string? Complemento { get; set; }
        public string? Bairro { get; set; }
        public string? Cidade { get; set; }
        public string? UF { get; set; }
    }
}
