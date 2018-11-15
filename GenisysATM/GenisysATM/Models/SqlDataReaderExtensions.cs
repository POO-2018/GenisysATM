using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace GenisysATM.Models
{
    public static class SqlDataReaderExtensions
    {
        /// <summary>
        /// Obtiene de manera segura el valor de un campo de tipo string.
        /// </summary>
        /// <param name="reader">El objeto reader para extender el método</param>
        /// <param name="columnName">El nombre del campo o columna</param>
        /// <returns>string: El valor del campo o columna</returns>
        public static string SafeGetString(this SqlDataReader reader, string columnName)
        {
            // Obtener el valor del índice mediante el nombre de la columna
            int columnIndex = reader.GetOrdinal(columnName);

            // Verificar si el valor del campo es NULL
            if (!reader.IsDBNull(columnIndex))
            {
                return reader.GetString(columnIndex);
            }

            // Si el valor del campo es NULL, retornar siempre un string.
            return string.Empty;
        }
    }
}
