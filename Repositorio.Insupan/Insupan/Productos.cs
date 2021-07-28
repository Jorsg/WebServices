using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositorio.Insupan;
using Dominio.Insupan;

namespace Repositorio.Insupan.Insupan
{
    public class Productos : RepositorioBase<ARTICULO>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public ARTICULO GetProducto(string articulo)
        {
            return Contexto.ARTICULO.FirstOrDefault(x => x.ARTICULO1 == articulo);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<ARTICULO> TodosProductos()
        {
            return GetAll().ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="productos"></param>
        /// <returns></returns>
        public bool InsertProducto(ARTICULO articulo)
        {
            bool respuesta = false;
            try
            {
                Save(articulo);
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
