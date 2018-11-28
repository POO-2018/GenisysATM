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
    class ATM
    {
        // Obtener las configuraciones de uso del ATM
        Configuracion configuracion = new Configuracion();

        private static string limiteDolares = Configuracion.ObtenerConfiguracion("MONTOMAXIMODOLARES");
        private static string limiteLempiras = Configuracion.ObtenerConfiguracion("MONTOMAXIMOLEMPIRAS");
        private static string tasaCambio = Configuracion.ObtenerConfiguracion("TASACAMBIODOLARES");
        private string limitePin = Configuracion.ObtenerConfiguracion("INTENTOSPIN");

        // Variables miembro
        private string numeroTarjeta;
        private string pin;

        protected Cliente elCliente = new Cliente();
        protected CuentaCliente laCuenta = new CuentaCliente();
        protected ServicioCliente losServicios = new ServicioCliente();
        protected TarjetaCredito laTarjeta = new TarjetaCredito();

        // Constructores
        public ATM() { }

        public ATM(string laTarjeta="", string elPin="")
        {
            numeroTarjeta = laTarjeta;
            pin = elPin;
        }

        // Métodos
        public bool VerificarInicio(string laCuenta, string elPin)
        {
            this.laCuenta = CuentaCliente.ObtenerCliente(laCuenta);

            if (this.laCuenta.numero == laCuenta && this.laCuenta.pin == elPin)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Evalúa si el monto de retiro es válido.
        /// </summary>
        /// <param name="monto">El monto de retiro a evaluar</param>
        /// <returns>true/false</returns>
        private static bool EvaluarTransaccionLempiras(decimal monto)
        {
            // Las transacciones válidas para el retiro de Lempiras son aquellas que
            // son múltiplos de 100 y menores que el límiteLempiras.
            decimal residuo = 0;

            if (monto > Convert.ToDecimal(limiteLempiras))
            {
                return false;
            }
            else if ((residuo = monto % 100) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool RetiroLempiras(CuentaCliente laCuenta, decimal monto)
        {
            try
            {
                if (ATM.EvaluarTransaccionLempiras(monto))
                {
                    if (laCuenta.saldo <= monto)
                    {
                        throw new CustomException("Saldo insuficiente para realizar la transacción.");
                    }
                    else
                    {
                        // Actualizar el saldo en la base de datos
                        if (CuentaCliente.ActualizarSaldo(laCuenta.numero, monto))
                        {
                            return true;
                        }
                        else
                            throw new CustomException("Error al momento de realizar el retiro. Su saldo no fué afectado.");
                    }
                }
                else
                    throw new CustomException("El monto ingresado de L {0} no es correcto.", monto);
            }
            catch (Exception ex)
            {

                throw new CustomException(ex.Message);
            }
        }

        /// <summary>
        /// Evalúa si el monto de retiro es válido.
        /// </summary>
        /// <param name="monto">El monto de retiro a evaluar</param>
        /// <returns>true/false</returns>
        private static bool EvaluarTransaccionDolares(decimal monto)
        {
            // Las transacciones válidas para el retiro de Lempiras son aquellas que
            // son múltiplos de 100 y menores que el límiteLempiras.
            decimal residuoVeinte, residuoCincuenta = 0;

            if (monto > Convert.ToDecimal(limiteDolares))
            {
                return false;
            }
            else if ((residuoVeinte = monto % 20) == 0)
            {
                return true;
            }
            else if ((residuoCincuenta = monto % 50) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool RetiroDolares(CuentaCliente laCuenta, decimal monto)
        {
            try
            {
                if (ATM.EvaluarTransaccionDolares(monto))
                {
                    if (laCuenta.saldo <= (monto * Convert.ToDecimal(tasaCambio)))
                    {
                        throw new CustomException("Saldo insuficiente para realizar la transacción.");
                    }
                    else
                    {
                        // Actualizar el saldo en la base de datos
                        if (CuentaCliente.ActualizarSaldo(laCuenta.numero, (monto * Convert.ToDecimal(tasaCambio))))
                        {
                            return true;
                        }
                        else
                            throw new CustomException("Error al momento de realizar el retiro. Su saldo no fué afectado.");
                    }
                }
                else
                    throw new CustomException("El monto ingresado de $ {0} no es correcto.", monto);
            }
            catch (Exception ex)
            {

                throw new CustomException(ex.Message);
            }
        }
    }
}
