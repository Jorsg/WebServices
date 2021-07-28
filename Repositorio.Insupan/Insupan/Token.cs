using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Insupan;

namespace Repositorio.Insupan.Insupan
{
    public class Token : RepositorioBase<TOKEN>
    {
        public bool ValidaToken(string token)
        {
            bool respuesta = false;
            var query = Contexto.TOKEN.FirstOrDefault(x => x.Token1 == token);
            if (query.Token1 != null)
                respuesta = true;

            return respuesta;

        }
    }
}
