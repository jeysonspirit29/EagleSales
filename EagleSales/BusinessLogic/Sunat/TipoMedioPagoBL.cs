
using Common.Model;
using Persistence.Sunat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Sunat
{
    public class TipoMedioPagoBL
    {
        public IEnumerable<SNTt01_tipo_medio_pago> ListTipoMedioPago(int? idEstado = null)
        {
            return new TipoMedioPagoDA().ListTipoMedioPago(idEstado);
        }
    }
}
