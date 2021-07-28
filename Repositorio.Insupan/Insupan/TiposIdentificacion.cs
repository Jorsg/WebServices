using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositorio.Insupan;
using Dominio.Insupan;

namespace Repositorio.Insupan.Insupan
{
    public class TiposIdentificacion : RepositorioBase<TIPO_NIT>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public TIPO_NIT GetTipoIdentificacion(string tipoIdentificacion)
        {
            return Contexto.TIPO_NIT.FirstOrDefault(x => x.TIPO == tipoIdentificacion);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<TIPO_NIT> TodosTipoIdentificacion()
        {
            return GetAll().ToList();
        }

       
    }
}
