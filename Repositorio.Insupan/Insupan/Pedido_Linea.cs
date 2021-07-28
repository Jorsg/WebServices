using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Insupan;
using Repositorio.Insupan;

namespace Repositorio.Insupan.Insupan
{
    public class Pedido_Linea: RepositorioBase<PEDIDO_LINEA>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pedido_linea"></param>
        /// <returns></returns>
        public PEDIDO_LINEA GetPedido_Linea(string pedidolinea)
        {
            var query = Contexto.PEDIDO_LINEA.FirstOrDefault(x => x.PEDIDO == pedidolinea);
            return query;
        }

        public List<PEDIDO_LINEA> GetTodos()
        {
            var query = GetAll();
            return query.ToList();
        }

        public bool InsertPedido_Linea(PEDIDO_LINEA pedidoLinea)
        {
            bool respuesta = false;
            try
            {
               /// var pedidos = new DTO.Mapeo();
                Save(pedidoLinea);
                respuesta = true;
            }
            catch (Exception ex)
            {
                var error = ex.StackTrace;
               throw;
            }
            return respuesta;
        }

        public bool UpdatPedidoLinea(PEDIDO_LINEA pedidoLinea)
        {
            bool respuesta = false;
            try
            {
                Update(pedidoLinea);
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
