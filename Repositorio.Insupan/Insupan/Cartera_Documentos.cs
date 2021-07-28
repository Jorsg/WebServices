using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositorio.Insupan;
using Dominio.Insupan;

namespace Repositorio.Insupan.Insupan
{
    public class Cartera_Documentos : RepositorioBase<DOCUMENTOS_CC>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="documentos"></param>
        /// <returns></returns>
        public DOCUMENTOS_CC GetCarteraDocumentos(string documentos)
        {
            var query = Contexto.DOCUMENTOS_CC.FirstOrDefault(x => x.DOCUMENTO == documentos);
            return query;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<DOCUMENTOS_CC> TodosCarteraDocumento()
        {
            var query = GetAll();
            return query.ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="carteraDocumento"></param>
        /// <returns></returns>
        public bool InsertCarteraDocumento(DOCUMENTOS_CC carteraDocumento)
        {
            bool respuesta = false;
            try
            {
                Save(carteraDocumento);
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
