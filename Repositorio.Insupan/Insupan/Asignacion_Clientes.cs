using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositorio.Insupan;
using Dominio.Insupan;

namespace Repositorio.Insupan.Insupan
{
    public class Asignacion_Clientes : RepositorioBase<ViewAsignacion_Clientes>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="bodega"></param>
        /// <returns></returns>
        public ViewAsignacion_Clientes GetAsignacionClientes(string idAsesor)
        {
            var query = Contexto.ViewAsignacion_Clientes.FirstOrDefault(x => x.ASESOR_ID == idAsesor);
            return query;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<ViewAsignacion_Clientes> TodasAsignacionClientes()
        {
            var query = GetAll();
            return query.ToList();
        }

    }
}
