using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Model;
using Persistence.Maestro;

namespace BusinessLogic.Maestro
{
    public class MedioPagoBL
    {
        public IEnumerable<MSTt01_medio_pago> ListMedioPago(int? idEstado = null)
        {
            return new MedioPagoDA().ListMedioPago(idEstado);
        }
    }
}
