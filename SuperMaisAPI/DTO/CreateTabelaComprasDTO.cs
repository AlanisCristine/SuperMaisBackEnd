namespace SuperMaisAPI.DTO
{
    public class CreateTabelaComprasDTO
    {
        public float? PrecoMercadoria { get; set; }
        public int? QtdMercadoria { get; set; }
        public required string Cliente_CPFCliente { get; set; }
    }
}
