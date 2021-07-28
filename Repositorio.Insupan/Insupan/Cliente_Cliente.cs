using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Insupan;
using Repositorio.Insupan;

namespace Repositorio.Insupan.Insupan
{
    public class Cliente_Cliente: RepositorioBase<CLIENTE>
    {
        
        /// 
        /// </summary>
        /// <returns></returns>
        public List<CLIENTE> GetTodos()
        {
            var query = GetAll();
            return query.ToList();
        }


    }
}
