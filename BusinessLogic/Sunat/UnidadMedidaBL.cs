using Common.Model;
using Persistence.Sunat;
using System.Collections.Generic;

namespace BusinessLogic.Sunat
{
    public class UnidadMedidaBL
    {
        public IEnumerable<SNTt06_unidad_medida> ListUnidadMedida(int? idEstado = null)
        {
            return new UnidadMedidaDA().ListUnidadMedida(idEstado);
        }
    }
}
