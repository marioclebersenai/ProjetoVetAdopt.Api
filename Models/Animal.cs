namespace ProjetoVetAdopt.Api.Models
{
    public class Animal
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Especie { get; set; }
        public int Idade { get; set; }
        public string? Status { get; set; }

        public int AbrigoId { get; set; }
        public Abrigo? Abrigo { get; set; }

        public List<Historico>? Historicos { get; set; }
    }
}