using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositorio.Insupan;
using Dominio.Insupan;

namespace Repositorio.Insupan.Insupan
{
    public class Asignacion_Bodegas : RepositorioBase<BODEGA>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="bodega"></param>
        /// <returns></returns>
        public BODEGA GetAsignacionBodegas(string bodega)
        {
            var query = Contexto.BODEGA.FirstOrDefault(x => x.BODEGA1 == bodega);
            return query;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<BODEGA> TodasAsignacionBodegas()
        {
            var query = GetAll();
            return query.ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="asgnaBodega"></param>
        /// <returns></returns>
        public bool InserAsignacionBodega(BODEGA asgnaBodega)
        {
            bool respuesta = false;
            try
            {
                Save(asgnaBodega);
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
