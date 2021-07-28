using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositorio.Insupan;
using Dominio.Insupan;

namespace Repositorio.Insupan.Insupan
{
    public class Pedido: RepositorioBase<PEDIDO>
    {
        public PEDIDO GetPedido(string pedido)
        {
            var query = Contexto.PEDIDO.FirstOrDefault(x => x.PEDIDO1 == pedido);
            return query;
        }

        public List<PEDIDO> GetTodos()
        {
            var query = GetAll();
            return query.ToList();
        }

        public bool InsertPedido(PEDIDO pedido)
        {
            bool respuesta = false;
            try
            {
                //var pedidos = new DTO.Mapeo();
                Save((pedido));
                respuesta = true;
            }
            catch (Exception ex)
            {
              var error = ex.StackTrace;
              throw;
            }
            return respuesta;

        }

        public bool UpdatPedido(PEDIDO pedido)
        {
            bool respuesta = false;
            try
            {
                Update(pedido);
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
