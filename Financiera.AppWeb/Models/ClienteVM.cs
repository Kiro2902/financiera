namespace Financiera.AppWeb.Models
{
    public class ClienteVM
    {
        public int ID { get; set; }
        public string Nombres { get; set; } = string.Empty;
        public string Direccion { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public int TipoClienteID { get; set; }
        public string TipoCliente { get; set; } = string.Empty;
    }
}
