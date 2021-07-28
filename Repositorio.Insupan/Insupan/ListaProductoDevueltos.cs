using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Insupan;

namespace Repositorio.Insupan.Insupan
{
    public class ListaProductoDevueltos : RepositorioBase<ViewPRODUCTO_DEVUELTOS>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="documentos"></param>
        /// <returns></returns>
        public ViewPRODUCTO_DEVUELTOS GetListaPagoRecaudo(string devolucion)
        {
            var query = Contexto.ViewPRODUCTO_DEVUELTOS.FirstOrDefault(x => x.DEVOLUCION_ID == devolucion);
            return query;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<ViewPRODUCTO_DEVUELTOS> TodosListaPagoRecaudo()
        {
            var query = GetAll();
            return query.ToList();
        }
    }
}
