using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Agregar los namespaces necesarios
using System.Data;
using System.Data.SqlClient;

namespace GenisysATM.Models
{
    class CuentaCliente
    {
        // Propiedades
        public string numero { get; set; }
        public int idCliente { get; set; }
        public decimal saldo { get; set; }
        public string pin { get; set; }

        // Constructores
        public CuentaCliente() { }

        // Métodos
        public static CuentaCliente ObtenerCliente(string cuenta)
        {
            Conexion conn = new Conexion(@"(local)\sqlexpress", "GenisysATM_V2");
            CuentaCliente laCuenta = new CuentaCliente();
            string sql = @"SELECT *
                           FROM ATM.CuentaCliente
                           WHERE numero = @cuenta";

            SqlCommand cmd = conn.EjecutarComando(sql);
            SqlDataReader rdr;

            try
            {
                using (cmd)
                {
                    cmd.Parameters.Add("@cuenta", SqlDbType.Char, 14).Value = cuenta;

                    rdr = cmd.ExecuteReader();
                }

                while (rdr.Read())
                {
                    laCuenta.numero = rdr.GetString(0);
                    laCuenta.idCliente = rdr.GetInt16(1);
                    laCuenta.saldo = rdr.GetDecimal(2);
                    laCuenta.pin = rdr.GetString(3);
                }

                return laCuenta;
            }
            catch (SqlException ex)
            {
                return laCuenta;
            }
            finally
            {
                conn.CerrarConexion();
            }
        }
    }
}
