namespace InventarioAPI.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string? Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public string? Categoria { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
    }
}