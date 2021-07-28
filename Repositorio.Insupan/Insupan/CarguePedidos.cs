using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Insupan;

namespace Repositorio.Insupan.Insupan
{
    public class CarguePedidos : RepositorioBase<CARGUE_PEDIDOS>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="documentos"></param>
        /// <returns></returns>
        public CARGUE_PEDIDOS GetCarguePedidos(string pedido)
        {
            var query = Contexto.CARGUE_PEDIDOS.FirstOrDefault(x => x.PEDIDO_ID == pedido);
            return query;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<CARGUE_PEDIDOS> TodosCarguePedidos()
        {
            var query = GetAll();
            return query.ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="carteraDocumento"></param>
        /// <returns></returns>
        public bool InsertCarguePedidos(CARGUE_PEDIDOS devoluciones)
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
