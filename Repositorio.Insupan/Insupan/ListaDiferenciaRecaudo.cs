using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Insupan;

namespace Repositorio.Insupan.Insupan
{
    public class ListaDiferenciaRecaudo : RepositorioBase<LISTA_DIF_RECAUDO>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="documentos"></param>
        /// <returns></returns>
        public LISTA_DIF_RECAUDO GetListaDiferenciasRecaudo(string recaudo)
        {
            var query = Contexto.LISTA_DIF_RECAUDO.FirstOrDefault(x => x.RECAUDO_ID == recaudo);
            return query;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<LISTA_DIF_RECAUDO> TodosListaDiferenciasRecaudo()
        {
            var query = GetAll();
            return query.ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="carteraDocumento"></param>
        /// <returns></returns>
        public bool InsertListaDiferenciasRecaudo(LISTA_DIF_RECAUDO recaudo)
        {
            bool respuesta = false;
            try
            {
                Save(recaudo);
                respuesta = true;
            }
            catch (Exception)
            {
                throw;
            }
            return respuesta;
        }
    }
}
