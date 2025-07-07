namespace WebApplication1.Dto
{
    public class MoveDto
    {
        public int Id { get; set; }             // Otomatik atanır (POST'ta gönderme)
        public string Name { get; set; }
        public string Type { get; set; }
        public int Power { get; set; }
        public int Accuracy { get; set; }
        public int PokemonId { get; set; }
    }
}
