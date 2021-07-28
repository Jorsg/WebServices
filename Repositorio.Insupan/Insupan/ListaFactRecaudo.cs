using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Insupan;

namespace Repositorio.Insupan.Insupan
{
    public class ListaFactRecaudo : RepositorioBase<ViewFACTURA_RECAUDO>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="documentos"></param>
        /// <returns></returns>
        public ViewFACTURA_RECAUDO GetListaFacturaRecaudo(string recaudo)
        {
            var query = Contexto.ViewFACTURA_RECAUDO.FirstOrDefault(x => x.RECAUDO_ID == recaudo);
            return query;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<ViewFACTURA_RECAUDO> TodosListaFacturaRecaudo()
        {
            var query = GetAll();
            return query.ToList();
        }

        
    }
}
