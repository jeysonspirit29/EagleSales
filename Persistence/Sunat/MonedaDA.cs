using Common.Model;
using Dapper;
using Persistence.Conexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Sunat
{
    public class MonedaDA
    {
        public IEnumerable<SNTt04_tipo_moneda> ListMoneda(int? idEstado = null)
        {
            var query = "SELECT * FROM SNTt04_tipo_moneda WHERE id_estado= @idEstado";
            using (IDbConnection cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    return cnn.Query<SNTt04_tipo_moneda>(query, new { idEstado });
                }
                catch
                {
                    return new List<SNTt04_tipo_moneda>();
                }
            }
        }
    }
}
