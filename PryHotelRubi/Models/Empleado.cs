namespace PryHotelRubi.Models
{
    public class Empleado : Persona
    {
        public int id_empleado { set; get; }
        public decimal sueldo { set; get; }
        public int num_h_vendidas {set; get;}
        public Persona usuario { set; get; }
    }
}
