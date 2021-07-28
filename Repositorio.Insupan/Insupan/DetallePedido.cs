using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Insupan;

namespace Repositorio.Insupan.Insupan
{
    public class DetallePedido : RepositorioBase<DETALLE_PEDIDOS>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="documentos"></param>
        /// <returns></returns>
        public DETALLE_PEDIDOS GetDetallePedido(string pedido)
        {
            var query = Contexto.DETALLE_PEDIDOS.FirstOrDefault(x => x.PEDIDO_ID == pedido);
            return query;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<DETALLE_PEDIDOS> TodosDetallePedido()
        {
            var query = GetAll();
            return query.ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="carteraDocumento"></param>
        /// <returns></returns>
        public bool InsertDetallePedido(DETALLE_PEDIDOS pedido)
        {
            bool respuesta = false;
            try
            {
                Save(pedido);
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
