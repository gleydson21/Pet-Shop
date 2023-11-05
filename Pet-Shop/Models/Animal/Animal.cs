namespace Pet_Shop.Models.Animal
{
    public class Animal
    {
        public required string Nome { get; set; }
        public required string Especie { get; set; }
        public required string Raca { get; set; }
        public int Idade { get; set; }
    }
}