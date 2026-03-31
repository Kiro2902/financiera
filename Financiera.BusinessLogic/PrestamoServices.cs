using Financiera.Data.Infrastructure;
using Financiera.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Financiera.BusinessLogic
{
    public class PrestamoServices
    {
        private readonly ICliente clienteDB;
        private readonly ITipoCliente tipoClienteDB;
        public PrestamoServices(ICliente cliente, ITipoCliente tipoCliente) {
            clienteDB = cliente;
            tipoClienteDB = tipoCliente;
        }

        public List<Cliente> ListarClientes()
        {
            return clienteDB.Listar();
        }

        public Cliente ObtenerClientePorID(int id)
        {
            return clienteDB.ObtenerPorId(id);
        }

        public TipoCliente ObtenerTipoClientePorID(int id)
        {
            return tipoClienteDB.ObtenerPorId((int)id);
        }
    }
}
