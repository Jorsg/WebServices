using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositorio.Insupan;
using Dominio.Insupan;

namespace Repositorio.Insupan.Insupan
{
    public class Cartera_TiposDoc : RepositorioBase<ViewCARTERA_DOCUMENTOS>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tipoDocumento"></param>
        /// <returns></returns>
        public ViewCARTERA_DOCUMENTOS GetCarteraTiposDoc(string Documento)
        {
            var query = Contexto.ViewCARTERA_DOCUMENTOS.FirstOrDefault(x => x.DOCUMENTO == Documento);
            return query;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<ViewCARTERA_DOCUMENTOS> TodosCarteraTipoDoc()
        {
            var query = GetAll();
            return query.ToList();
        }

    }
}
