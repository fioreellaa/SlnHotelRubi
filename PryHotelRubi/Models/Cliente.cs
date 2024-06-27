namespace PryHotelRubi.Models
{
    public class Cliente : Persona
    {
        public int id_cliente { set; get; }
        public string tarjeta_credito { set; get; }
        public string direccion { set; get; }
        public Persona usuario { set; get; }

    }
}
