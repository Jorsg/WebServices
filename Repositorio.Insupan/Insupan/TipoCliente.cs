using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositorio.Insupan;
using Dominio.Insupan;

namespace Repositorio.Insupan.Insupan
{
    public class TipoCliente : RepositorioBase<TIPOS_CLIENTE>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public TIPOS_CLIENTE GetTipoCliente(string tipoCliente)
        {
            return Contexto.TIPOS_CLIENTE.FirstOrDefault(x => x.TIPO_CLIENTE_ID == tipoCliente);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<TIPOS_CLIENTE> TodosTipoCliente()
        {
            return GetAll().ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="productos"></param>
        /// <returns></returns>
        public bool InsertTipoCliente(TIPOS_CLIENTE tipocliente)
        {
            bool respuesta = false;
            try
            {
                Save(tipocliente);
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
