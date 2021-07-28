using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Insupan;

namespace Repositorio.Insupan.Insupan
{
    public class EncabezadoDevoluciones : RepositorioBase<ENCABEZADO_DEVOLUCIONES>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="documentos"></param>
        /// <returns></returns>
        public ENCABEZADO_DEVOLUCIONES GetEncabezadoDevolucion(string devolucion)
        {
            var query = Contexto.ENCABEZADO_DEVOLUCIONES.FirstOrDefault(x => x.DEVOLUCION_ID == devolucion);
            return query;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<ENCABEZADO_DEVOLUCIONES> TodosEncabezadoDevolucion()
        {
            var query = GetAll();
            return query.ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="carteraDocumento"></param>
        /// <returns></returns>
        public bool InsertEncabezadoDevolucion(ENCABEZADO_DEVOLUCIONES devoluciones)
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

