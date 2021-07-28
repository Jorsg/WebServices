using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Insupan; 

namespace Repositorio.Insupan.Insupan
{
    public class EncabezadoPedido : RepositorioBase<ENCABEZADO_PEDIDOS>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="documentos"></param>
        /// <returns></returns>
        public ENCABEZADO_PEDIDOS GetEncabezadoPedido(string pedido)
        {
            var query = Contexto.ENCABEZADO_PEDIDOS.FirstOrDefault(x => x.PEDIDO_ID == pedido);
            return query;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<ENCABEZADO_PEDIDOS> TodosEncabezadoPedido()
        {
            var query = GetAll();
            return query.ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="carteraDocumento"></param>
        /// <returns></returns>
        public bool InsertEncabezadoPedido(ENCABEZADO_PEDIDOS pedido)
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
