using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Persistence.Conexion;
using Dapper;
using Common.Model;

namespace Persistence.Maestro
{
    public class MedioPagoDA
    {
        public IEnumerable<MSTt01_medio_pago> ListMedioPago(int? idEstado = null)
        {
            var query = "SELECT * FROM MSTt01_medio_pago WHERE id_estado= @idEstado";
            using (IDbConnection cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    return cnn.Query<MSTt01_medio_pago>(query, new { idEstado });
                }
                catch(Exception e)
                {
                    return null;
                }
            }
        }
    }
}
