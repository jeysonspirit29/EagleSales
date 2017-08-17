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
    public class TipoMedioPagoDA
    {

        public IEnumerable<SNTt01_tipo_medio_pago> ListTipoMedioPago(int? idEstado = null)
        {
            var query = "SELECT * FROM SNTt01_tipo_medio_pago WHERE id_estado= @idEstado";
            using (IDbConnection cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    return cnn.Query<SNTt01_tipo_medio_pago>(query, new { idEstado });
                }
                catch
                {
                    return null;
                }
            }
        }
    }
}
