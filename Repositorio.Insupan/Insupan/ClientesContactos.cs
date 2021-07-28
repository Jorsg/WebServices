using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Insupan;

namespace Repositorio.Insupan.Insupan
{
    public class ClientesContactos: RepositorioBase<ViewCLIENTES_CONTACTOS>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="documentos"></param>
        /// <returns></returns>
        public ViewCLIENTES_CONTACTOS GetClientesContactos(string cliente)
        {
            var query = Contexto.ViewCLIENTES_CONTACTOS.FirstOrDefault(x => x.CLIENTE_ID == cliente);
            return query;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<ViewCLIENTES_CONTACTOS> TodosClientesContactos()
        {
            var query = GetAll();
            return query.ToList();
        }

    }
}
