using Common.Model;
using Persistence.Sunat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Sunat
{
    public class MonedaBL
    {
        public IEnumerable<SNTt04_tipo_moneda> ListMoneda(int? idEstado = null)
        {
            return new MonedaDA().ListMoneda(idEstado);
        }
    }
}
