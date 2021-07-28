using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Insupan;

namespace Repositorio.Insupan.Insupan
{
    public class MaestroListaPrecio : RepositorioBase<NIVEL_PRECIO>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="documentos"></param>
        /// <returns></returns>
        public NIVEL_PRECIO GetMaestroListaPrecio(string nivelprecio)
        {
            var query = Contexto.NIVEL_PRECIO.FirstOrDefault(x => x.NIVEL_PRECIO1 == nivelprecio);
            return query;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<NIVEL_PRECIO> TodosMaestrosListasPrecios()
        {
            var query = GetAll();
            return query.ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="carteraDocumento"></param>
        /// <returns></returns>
        public bool InsertMaestrosListaPrecio(NIVEL_PRECIO nivelprecio)
        {
            bool respuesta = false;
            try
            {
                Save(nivelprecio);
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
