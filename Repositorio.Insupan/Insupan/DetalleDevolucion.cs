using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Insupan;


namespace Repositorio.Insupan.Insupan
{
    public class DetalleDevolucion : RepositorioBase<DETALLE_DEVOLUCIONES>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="documentos"></param>
        /// <returns></returns>
        public DETALLE_DEVOLUCIONES GetDetalleDevolucion(string devolucion)
        {
            var query = Contexto.DETALLE_DEVOLUCIONES.FirstOrDefault(x => x.DEVOLUCION_ID == devolucion);
            return query;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<DETALLE_DEVOLUCIONES> TodosDetalleDevolucion()
        {
            var query = GetAll();
            return query.ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="carteraDocumento"></param>
        /// <returns></returns>
        public bool InsertDetalleDevolucion(DETALLE_DEVOLUCIONES devoluciones)
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
