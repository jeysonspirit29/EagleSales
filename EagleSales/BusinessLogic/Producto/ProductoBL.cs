
using Common.Model;
using Persistence.Producto;
using System.Collections.Generic;

namespace BusinessLogic.Producto
{
    public class ProductoBL
    {
        public IEnumerable<PROt09_producto> BuscarProducto(string cod, string cod02, string nombre,int snVenta, int snCompra, int idEstado)
        {
            return new ProductoDA().BuscarProductos(cod, cod02, nombre,snVenta, snCompra, idEstado);
        }
    }
}
