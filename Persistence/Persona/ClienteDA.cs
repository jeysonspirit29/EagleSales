using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dapper;
using Persistence.Conexion;
using System.Data.SqlClient;
using Common.Model;

namespace Persistence.Persona
{
    public class ClienteDA
    {
        public IEnumerable<PERt02_cliente> BuscarCliente(string nroDoc, string ruc, string nombre, string codTipoSujeto, int idEstado)
        {
            using (IDbConnection cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    return cnn.Query<PERt02_cliente>("SP_PER_CNS_Cliente",
                                                        new { nroDoc, ruc, nombre, codTipoSujeto, idEstado },
                                                        commandType: CommandType.StoredProcedure);
                }
                catch
                {
                    return null;
                }
            }
        }
    }
}
