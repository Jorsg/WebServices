using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositorio.Insupan;
using Dominio.Insupan;

namespace Repositorio.Insupan.Insupan
{
    public class ListaPrecios : RepositorioBase<ARTICULO_PRECIO>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="listPrecio"></param>
        /// <returns></returns>
        public ARTICULO_PRECIO GetListaPrecio(string articulo)
        {
            return Contexto.ARTICULO_PRECIO.FirstOrDefault(x => x.ARTICULO == articulo);
        }


        public List<ARTICULO_PRECIO> TodosListaPrecio()
        {
            return GetAll().ToList();
        }


        public bool InsertListaPrecio(ARTICULO_PRECIO articulo)
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
