using Dapper.Contrib.Extensions;

namespace SuperMaisAPI.Models
{

    [Table("tipomercadoria")]
    public class Tipomercadoria
    {
        [Key]
        public int idTipoMercadoria { get; set; }
        public required string TipoMercadoria { get; set; }
        [ExplicitKey]
        public required int Departamento_idDepartamento { get; set; }
        [ExplicitKey]
        public required int Departamento_Endereco_IdEndereco { get; set; }
    }
}
