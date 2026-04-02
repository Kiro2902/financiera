using Financiera.Data.Infrastructure;
using Financiera.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Financiera.Data.Repositories
{
    internal class PrestamoRepositorio : IPrestamo
    {
        private readonly string cadenaConexion;
        public PrestamoRepositorio(IConfiguration config)
        {
            cadenaConexion = config["ConnectionStrings:DB"] ?? string.Empty;
        }

        public bool Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public List<Prestamo> Listar()
        {
            List<Prestamo> listado = new List<Prestamo>();
            using var conexion = new SqlConnection(cadenaConexion);
            using var comando = new SqlCommand("ListarPrestamos", conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            conexion.Open();
            using var reader = comando.ExecuteReader();
            while (reader.Read())
            {
                listado.Add(ConvertirReaderEnObjeto(reader));
            }
            return listado;
        }

        public bool Modificar(Prestamo entity)
        {
            throw new NotImplementedException();
        }

        public Prestamo ObtenerPorId(int id)
        {
            throw new NotImplementedException();
        }

        public int Registrar(Prestamo entity)
        {
            throw new NotImplementedException();
        }

        #region . PRIVATE METHODS .

        private Prestamo ConvertirReaderEnObjeto(SqlDataReader reader)
        {
            return new Prestamo
            {
                ID = reader.GetInt32(0),
                Fecha = reader.GetDateTime(1),
                FechaDeposito = reader.GetDateTime(2),
                ClienteID = reader.GetInt32(3),
                TipoPrestamoID = reader.GetInt32(4),
                Moneda = reader.GetString(5),
                Importe = reader.GetDecimal(6),
                Plazo = reader.GetInt32(7),
                Tasa = reader.GetDecimal(8),
                Estado = reader.GetString(9)
            };
        }

        #endregion
    }
}
