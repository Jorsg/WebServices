using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositorio.Insupan;
using Dominio.Insupan;

namespace Repositorio.Insupan.Insupan
{
   public class ProductoLineas : RepositorioBase<CLASIFICACION>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="lineaId"></param>
        /// <returns></returns>
        public CLASIFICACION GetProductoLinea(string clasificacion)
        {
            return Contexto.CLASIFICACION.FirstOrDefault(x => x.CLASIFICACION1 == clasificacion);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<CLASIFICACION> TodosProductosLinea()
        {
            return GetAll().ToList();
        }



    }
}
