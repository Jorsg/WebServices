using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositorio.Insupan;
using Dominio.Insupan;

namespace Repositorio.Insupan.Insupan
{
    public class Inventario : RepositorioBase<EXISTENCIA_BODEGA>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="bodegaId"></param>
        /// <returns></returns>
        public EXISTENCIA_BODEGA GetInventario(string bodegaId)
        {
            return Contexto.EXISTENCIA_BODEGA.FirstOrDefault(x => x.BODEGA == bodegaId);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<EXISTENCIA_BODEGA> TodosInventario()
        {
            return GetAll().ToList();
        }

        public bool InsertInventario(EXISTENCIA_BODEGA inventario)
        {
            bool respuesta = false;
            try
            {
                Save(inventario);
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
