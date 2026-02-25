namespace ProjetoVetAdopt.Api.Models
{
    public class Abrigo
    {
        public int Id { get; set; }

        public string? Nome { get; set; }

        public string? Endereco { get; set; }

        public string? Cidade { get; set; }
        public string? Estado { get; set; }

        public string? Telefone { get; set; }
        public string? ChavePix { get; set; }

        public List<Animal>? Animais { get; set; }

    }
}