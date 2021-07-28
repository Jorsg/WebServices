using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Insupan;

namespace Repositorio.Insupan.Insupan
{
    public class Bodega : RepositorioBase<BODEGA>
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

        
    }
}
