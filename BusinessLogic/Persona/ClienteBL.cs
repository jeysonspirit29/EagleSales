using Common.Model;
using Persistence.Persona;
using System.Collections.Generic;

namespace BusinessLogic.Persona
{
    public class ClienteBL
    {
        public IEnumerable<PERt02_cliente> BuscarCliente(string nroDoc, string ruc, string nombre, string codTipoSujeto, int idEstado)
        {
            return new ClienteDA().BuscarCliente(nroDoc,ruc,nombre,codTipoSujeto,idEstado);
        }
    }
}
