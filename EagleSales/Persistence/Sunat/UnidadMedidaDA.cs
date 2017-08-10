using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using Persistence.Conexion;
using Common.Model;

namespace Persistence.Sunat
{
    public class UnidadMedidaDA
    {
        public IEnumerable<SNTt06_unidad_medida> ListUnidadMedida(int? idEstado = null)
        {
            var query = "SELECT * FROM SNTt06_unidad_medida WHERE id_estado= @idEstado";
            using (IDbConnection cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    return cnn.Query<SNTt06_unidad_medida>(query, new { idEstado });
                }
                catch
                {
                    return null;
                }
            }
        }
    }
}
