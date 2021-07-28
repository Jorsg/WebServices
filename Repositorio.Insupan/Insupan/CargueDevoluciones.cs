using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Insupan;


namespace Repositorio.Insupan.Insupan
{
    public class CargueDevoluciones : RepositorioBase<CARGUE_DEVOLUCIONES>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="documentos"></param>
        /// <returns></returns>
        public CARGUE_DEVOLUCIONES GetCargueDevoluciones(string asesor)
        {
            var query = Contexto.CARGUE_DEVOLUCIONES.FirstOrDefault(x => x.ASESOR_ID == asesor);
            return query;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<CARGUE_DEVOLUCIONES> TodosCargueDevoluciones()
        {
            var query = GetAll();
            return query.ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="carteraDocumento"></param>
        /// <returns></returns>
        public bool InsertCargueDevoluciones(CARGUE_DEVOLUCIONES devoluciones)
        {
            bool respuesta = false;
            try
            {
                Save(devoluciones);
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
