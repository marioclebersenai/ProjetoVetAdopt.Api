namespace ProjetoVetAdopt.Api.Models.DTOs
{
    public class CriarAbrigoDto
    {
        public string? Nome { get; set; }

        public string? Endereco { get; set; }

        public string? Cidade { get; set; }
        public string? Estado { get; set; }

        public string? Telefone { get; set; }
        public string? ChavePix { get; set; }
    }

    public class AbrigoDto
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Endereco { get; set; }
        
        public string? Telefone { get; set; }

        public int QtdAnimais { get; set; }
    }   
}