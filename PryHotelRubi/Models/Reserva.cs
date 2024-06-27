namespace PryHotelRubi.Models
{
    public class Reserva
    {
        public int id_cliente { set; get; }
        public int id_habitacion { set; get; }
        public DateTime fecha_inicio { set; get; }
        public DateTime fecha_fin { set; get; }
        public string estado { set; get; }
    }
}
