namespace ProjetoVetAdopt.Api.Models.DTOs
{
    public class CriarHistoricoDto
    {
        public DateTime DataOcorrencia { get; set; }
        public string? Ocorrencia { get; set; }
        public int AnimalId { get; set; }
    }
}