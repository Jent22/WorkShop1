namespace WebApplication7.Models
{
    public class ChipsRequest
    {
        public int Quantity { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Type { get; set; }
        public int Integrity { get; set; }
        public Boolean Disponibilidad { get; set; }
        public string Marca { get; set; }
        public Double VSalud { get; set; }
        public Boolean Calidad { get; set; }
        public DateTime FechaExp { get; set; }
    }
}
