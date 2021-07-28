using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Insupan;

namespace Repositorio.Insupan.Insupan
{
    public class EncabezadoRecaudos : RepositorioBase<ENCABEZADO_RECAUDOS>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="documentos"></param>
        /// <returns></returns>
        public ENCABEZADO_RECAUDOS GetEncabezadoRecaudo(string recaudo)
        {
            var query = Contexto.ENCABEZADO_RECAUDOS.FirstOrDefault(x => x.RECAUDO_ID == recaudo);
            return query;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<ENCABEZADO_RECAUDOS> TodosEncabezadoRecaudo()
        {
            var query = GetAll();
            return query.ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="carteraDocumento"></param>
        /// <returns></returns>
        public bool InsertEncabezadoRecaudo(ENCABEZADO_RECAUDOS recaudo)
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

        public bool DeleteEncabezado_Recaudo(ENCABEZADO_RECAUDOS recaudo)
        {
            bool respuesta = false;
            try
            {
                Delete(recaudo);
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
