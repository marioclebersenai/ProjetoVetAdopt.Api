namespace ProjetoVetAdopt.Api.Models
{
    public class Historico
    {
        public int Id { get; set; }
        public DateTime DataOcorrencia { get; set; }
        public string? Ocorrencia { get; set; }

        public int AnimalId { get; set; }
        public Animal? Animal { get; set; }
    }
}