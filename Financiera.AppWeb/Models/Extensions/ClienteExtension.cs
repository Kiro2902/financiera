using Financiera.Entities;

namespace Financiera.AppWeb.Models.Extensions
{
    public static class ClienteExtension
    {
        public static ClienteVM toViewModel(this Cliente cliente)
        {
            if (cliente == null) throw new ArgumentNullException("El cliente no ha sido creado");

            return new ClienteVM {
                ID = cliente.ID,
                Nombres = $"{cliente.Apellidos}, {cliente.Nombres}",
                Direccion = cliente.Direccion,
                Email = cliente.Email,
                Telefono = cliente.Telefono,
                TipoClienteID = cliente.TipoClienteID
            };
        }
    }
}
