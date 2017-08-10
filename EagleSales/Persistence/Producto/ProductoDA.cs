using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Persistence.Conexion;
using System.Data.SqlClient;
using Dapper;
using System.Diagnostics;
using Common.Model;

namespace Persistence.Producto
{
    public class ProductoDA
    {
        public IEnumerable<PROt09_producto> BuscarProductos(string cod, string cod02, string nombre, int snVenta, int snCompra, int idEstado)
        {
            using (IDbConnection cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    return cnn.Query<PROt09_producto>("SP_PROD_CNS_Producto",
                                                        new { cod, cod02, nombre, snVenta, snCompra, idEstado },
                                                        commandType: CommandType.StoredProcedure);
                }
                catch(Exception e)
                {
                    Debug.Write(e.Message);
                    return null;
                }
            }
        }
    }
}
