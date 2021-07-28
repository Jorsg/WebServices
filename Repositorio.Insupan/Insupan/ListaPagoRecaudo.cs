using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Insupan;

namespace Repositorio.Insupan.Insupan
{
    public class ListaPagoRecaudo : RepositorioBase<ViewPAGO_RECAUDO>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="documentos"></param>
        /// <returns></returns>
        public ViewPAGO_RECAUDO GetListaPagoRecaudo(string recaudo)
        {
            var query = Contexto.ViewPAGO_RECAUDO.FirstOrDefault(x => x.RECAUDO_ID == recaudo);
            return query;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<ViewPAGO_RECAUDO> TodosListaPagoRecaudo()
        {
            var query = GetAll();
            return query.ToList();
        }
       
    }
}
