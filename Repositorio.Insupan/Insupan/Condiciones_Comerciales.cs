using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositorio.Insupan;
using Dominio.Insupan;

namespace Repositorio.Insupan.Insupan
{
    public class Condiciones_Comerciales : RepositorioBase<CONDICION_PAGO>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="codicionesComerciales"></param>
        /// <returns></returns>
        public CONDICION_PAGO GetCondicionComercial(string codicionesComerciales)
        {
            var query = Contexto.CONDICION_PAGO.FirstOrDefault(x => x.CONDICION_PAGO1 == codicionesComerciales);
            return query;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<CONDICION_PAGO> TodosCondicionesComerciales()
        {
            var query = GetAll();
            return query.ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        public bool InsertCondicionComercial(CONDICION_PAGO condiciones)
        {
            bool respuesta = false;
            try
            {
                Save(condiciones);
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
