using Financiera.Data.Infrastructure;
using Financiera.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Financiera.Data.Repositories
{
    public class TipoClienteRepositorio : ITipoCliente
    {
        private readonly string cadenaConexion = string.Empty;

        public TipoClienteRepositorio(IConfiguration config)
        {
            cadenaConexion = config["ConnectionStrings:DB"] ?? string.Empty;
        }

        public bool Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public List<TipoCliente> Listar()
        {
            throw new NotImplementedException();
        }

        public bool Modificar(TipoCliente entity)
        {
            throw new NotImplementedException();
        }

        public TipoCliente ObtenerPorId(int id)
        {
            TipoCliente tipo = null;
            using var conexion = new SqlConnection(cadenaConexion);
            using var comando = new SqlCommand("ObtenerTipoClientePorID", conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("id", id);
            conexion.Open();
            using var reader = comando.ExecuteReader();
            reader.Read();
            tipo = ConvertirReaderEnObjeto(reader);
            return tipo;
        }

        public int Registrar(TipoCliente entity)
        {
            throw new NotImplementedException();
        }

        #region . PRIVATE METHODS .

        private TipoCliente ConvertirReaderEnObjeto(SqlDataReader reader)
        {
            return new TipoCliente
            {
                ID = reader.GetInt32(0),
                Nombre = reader.GetString(1),
                Activo = reader.GetBoolean(2),
            };
        }

        #endregion
    }
}
