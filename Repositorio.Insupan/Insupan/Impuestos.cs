using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Insupan;
using Repositorio.Insupan;

namespace Repositorio.Insupan.Insupan
{
    public class Impuestos : RepositorioBase<IMPUESTO>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public IMPUESTO GetImpuesto(string impuesto)
        {
            return Contexto.IMPUESTO.FirstOrDefault(x => x.IMPUESTO1 == impuesto);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<IMPUESTO> TodosImpuestos()
        {
            return GetAll().ToList();
        }
    }
}
