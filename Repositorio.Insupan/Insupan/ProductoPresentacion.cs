using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositorio.Insupan;
using Dominio.Insupan;

namespace Repositorio.Insupan.Insupan
{
    public class ProductoPresentacion : RepositorioBase<ViewPRODUCTOS_PRESENTACION>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="prductoId"></param>
        /// <returns></returns>
        public ViewPRODUCTOS_PRESENTACION GetProducPresentacion(string prductoId)
        {
            return Contexto.ViewPRODUCTOS_PRESENTACION.FirstOrDefault(x => x.PRODUCTO_ID == prductoId);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<ViewPRODUCTOS_PRESENTACION> TodosProdctoPresenta()
        {
            return GetAll().ToList();
        }


    }
}
