using Dapper.Contrib.Extensions;
using System.ComponentModel.DataAnnotations.Schema;
using TableAttribute = Dapper.Contrib.Extensions.TableAttribute;

namespace SuperMaisAPI.Models
{
    [Table("funcionarios")]
    public class Funcionarios
    {
        [Key]
        public int idFuncionarios { get; set; }
        public string? NomeFuncionario { get; set; }
        public required string CPFFuncionario { get; set; }
        public required DateTime DataNascimento { get; set; }
        public required DateTime DataContrato { get; set; }
        public DateTime? DataDemissao { get; set; }
        public required int EnderecoId { get; set; } // Chave estrangeira
        public string? TelefoneFuncionario { get; set; }
        public string? CelularFuncionario { get; set; }
        public int? IdDepartamentoFuncionario { get; set; }
        public required int Cargos_idCargos { get; set; }
        public string? EmailFuncionario { get; set; }
        public required int Departamento_idDepartamento { get; set; }
    }
}
