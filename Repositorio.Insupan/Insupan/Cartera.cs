using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositorio.Insupan;
using Dominio.Insupan;

namespace Repositorio.Insupan.Insupan
{
    public class Cartera: RepositorioBase<CLIENTE>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns></returns>
        public CLIENTE GetCLIENTE(string cliente)
        {
            var query = Contexto.CLIENTE.FirstOrDefault(x => x.CLIENTE1 == cliente);
            return query;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<CLIENTE> GetTodos()
        {
            var query = GetAll();
            return query.ToList();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns></returns>
        public bool InsertCliente(DTO.DtoClientes cliente)
        {
            bool respuesta = false;
            try
            {
                //Save(cliente);
                var clientes = new DTO.Mapeo();
                Save(clientes.MapearCliente(cliente));
                respuesta = true;
            }
            catch (Exception ex)
            {
                var error = ex.StackTrace;
                throw;
            }
            return respuesta;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns></returns>
        public bool UpdatCliente(CLIENTE cliente)
        {
            bool respuesta = false;
            try
            {
                Update(cliente);
                respuesta = true;
            }
            catch (Exception ex)
            {
                var error = ex.StackTrace;
                throw;
            }
            return respuesta;
        }

    }
}
