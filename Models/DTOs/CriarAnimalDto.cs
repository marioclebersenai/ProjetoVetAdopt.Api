namespace ProjetoVetAdopt.Api.Models.DTOs
{
    public class CriarAnimalDto
    {
        public string? Especie { get; set; }
        public string? Nome { get; set; }
        public int Idade { get; set; }
        public int AbrigoId { get; set; }
    }
}