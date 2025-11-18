namespace APLICACIONINVENTARIO.Models
{
    public class Movimiento
    {
        public int Id { get; set; }
        public int ProductoId { get; set; }
        public string Tipo { get; set; } 
        public int Cantidad { get; set; }
        public string Motivo { get; set; }
        public DateTime Fecha { get; set; }

       
        public Producto Producto { get; set; }
    }
