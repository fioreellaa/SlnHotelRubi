namespace PryHotelRubi.Models
{
    public class Habitacion
    {
        public int id_habitacion { set; get; }
        public int num_habitacion { set; get; }
        public decimal precio_noche { set; get; }
        public string estado { set; get; }
        public string tipo { set; get; }
        public string descripcion { set; get; }
    }
}
