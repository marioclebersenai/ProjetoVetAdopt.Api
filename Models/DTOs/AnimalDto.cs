namespace ProjetoVetAdopt.Api.Models.DTOs
{
    public class AnimalDto
    {
        public string? Nome { get; set; }
        public string? Especie { get; set; }
        public int Idade { get; set; }
        public string? NomeAbrigo { get; set; }
        public string? Cidade { get; set; }
        public string? Estado { get; set; }
    }
}